using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    public class Validacoes
    {
        /// <summary>
        /// Valida CPF
        /// </summary>
        /// <param name="cpf">string CPF</param>
        /// <returns>true or false</returns>
        public static bool ValidaCPF(string cpf)
        {
            #region Variáveis
            bool ok = true;
            int[] calc = new int[11];
            int i = -1, j = 11, result = 0;
            #endregion

            if (cpf.Trim() == ".   .   -")
                return true;

            // valida se cpf está completo
            if (cpf.Replace(" ", null).Length != 14)
                return ok = false;

            #region distribui os caracteres de cpf em um vetor de inteiros
            foreach (char num in cpf)
            {
                if (num != '-' && num != '.')
                    calc[++i] = Convert.ToInt16(num.ToString());
            }
            #endregion

            #region Valida CPF inválido por possuir todos os números repetidos
            foreach (char num in cpf)
            {
                if (num != '.' && num != '-')
                    if (calc[0] == Convert.ToInt16(num.ToString()))
                        result++;
            }

            if (result == 11)
                return ok == false;
            #endregion

            #region Valida 1º dígito verificador
            result = 0;
            for (i = 0; i < 9; i++)
            {
                result += calc[i] * --j;
            }

            result = (result * 10) % 11;

            if (result == 10)
                result = 0;

            if (result != calc[9])
                return ok = false;
            #endregion

            #region Valida 2º dígito verificador
            j = 12;
            result = 0;
            for (i = 0; i < 10; i++)
            {
                result += calc[i] * --j;
            }

            result = (result * 10) % 11;

            if (result == 10)
                result = 0;

            if (result != calc[10])
                return ok = false;
            #endregion

            return ok;
        }

        /// <summary>
        /// Valida Telefone/Celular
        /// </summary>
        /// <param name="telcel"></param>
        /// <returns>true or false</returns>
        public static bool ValidaTelCel(string telcel)
        {
            bool ok = true;

            ok = Int64.TryParse(telcel.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), out long x);

            // Verifica se é nulo
            if (String.IsNullOrEmpty(telcel.Replace("(", "").Replace(")", "").Replace("-", "").Trim()))
                ok = false;

            //Verifica se o numero possui 11 ou 12 dígitos
            if (telcel.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 11 &&
                telcel.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length != 12)
                ok = false;

            return ok;
        }

        /// <summary>
        /// Verifica se um email é válido. Para ser válido precisa estar no formato ____@___.com___ ou ser nulo
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true or false</returns>
        public static bool ValidaEmail(string email)
        {
            bool ok = String.IsNullOrEmpty(email.Trim()) || 
                   (String.IsNullOrEmpty(email.Trim()) == false && 
                    email.Split('@').Length == 2 && 
                    email.Contains(".com") &&
                    String.IsNullOrEmpty(email.Replace(".com","").Split('@')[1].Trim()) == false &&
                    email.IndexOf(',') == -1 &&
                    email.IndexOf('!') == -1 &&
                    email.IndexOf('?') == -1 &&
                    email.IndexOf('ç') == -1 &&
                    email.IndexOf('\'') == -1 &&
                    email.IndexOf('\\') == -1 &&
                    email.IndexOf('/') == -1 &&
                    email.IndexOf('+') == -1 &&
                    email.IndexOf('=') == -1 &&
                    email.IndexOf('*') == -1 &&
                    email.IndexOf('-') == -1 &&
                    email.IndexOf('#') == -1 &&
                    email.IndexOf('$') == -1 &&
                    email.IndexOf('%') == -1 &&
                    email.IndexOf('¨') == -1 &&
                    email.IndexOf('(') == -1 &&
                    email.IndexOf(')') == -1 &&
                    email.IndexOf('{') == -1 &&
                    email.IndexOf('}') == -1 &&
                    email.IndexOf('[') == -1 &&
                    email.IndexOf(']') == -1 &&
                    email.IndexOf('~') == -1 &&
                    email.IndexOf('^') == -1 &&
                    email.IndexOf('´') == -1 &&
                    email.IndexOf('`') == -1 &&
                    email.IndexOf('°') == -1 &&
                    email.IndexOf('|') == -1 &&
                    email.IndexOf('\"') == -1);

            return ok;
        }

        /// <summary>
        /// Valida se a hora digitada é válida ou não
        /// </summary>
        /// <returns>true or false</returns>
        public static bool ValidaHorario(string horario)
        {
            if (horario.Trim().Length == 5)
                if (Convert.ToInt16(horario.Substring(0, 2)) <= 23)
                    if (Convert.ToInt16(horario.Substring(3, 2)) <= 59)
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
    }
}

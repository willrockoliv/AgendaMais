using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    public class PessoaVO
    {
        private char tipo_pessoa;
        private int id;
        private string nome;
        private string tel_cel;
        private string email;
        private string recado;
        private string cpf;
        private string rg;
        private string uf;
        private string cidade;
        private string bairro;
        private string endereco;
        private string numero;
        private string complemento;
        private string imagem;
        private string bancoDeImagens = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\BD\\imagens\\";
        private bool ativo = true;

        string SalvaImagem(string caminhoImagem)
        {
            if (File.Exists(bancoDeImagens + caminhoImagem))
                return caminhoImagem;

            if (id == 0)
                throw new Exception("Preencha o id antes de preencher a imagem");

            if (String.IsNullOrEmpty(nome))
                throw new Exception("Preencha o nome antes de preencher a imagem");

            if (String.IsNullOrEmpty(caminhoImagem))
                return "";

            string copia = bancoDeImagens + id + "_" + nome.Replace(" ", "_") + Path.GetExtension(caminhoImagem);

            if (caminhoImagem == copia)
                return Path.GetFileName(caminhoImagem);

            if (File.Exists(copia))
                File.Delete(copia);//Path.GetFileName(copia);

            if (File.Exists(caminhoImagem) == false)
               throw new Exception("Desculpe! Não encontrei a imagem que você escolheu...");

            File.Copy(caminhoImagem, copia);

            return imagem = Path.GetFileName(copia);
        }

        public char Tipo_pessoa { get => tipo_pessoa; set => tipo_pessoa = value; }

        public int Id
        {
            get => id; set
            {
                if (value <= 0)
                    throw new Exception("id não pode ser menor ou igual a zero");
                else
                    id = value;
            }
        }

        public string Nome
        {
            get => nome; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome é um dado obrigatório");
                else
                    nome = value;
            }
        }

        public string Tel_cel
        {
            get => tel_cel;
            set
            {
                if (Validacoes.ValidaTelCel(value))
                    tel_cel = value;
                else
                    throw new Exception("Telefone/Celular inválido");
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (Validacoes.ValidaEmail(value))
                    email = value;
                else
                    throw new Exception("Desculpe! O E-mail que você informou não é válido");
            }
        }

        public string Recado { get => recado; set => recado = value; }

        public string Cpf
        {
            get => cpf;
            set
            {
                if (value.Trim() == ".   .   -")
                    cpf = "";
                else if (String.IsNullOrEmpty(value) || Validacoes.ValidaCPF(value))
                    cpf = value;
                else
                    throw new Exception("CPF inválido");
            }
        }

        public string Rg
        {
            get => rg;
            set
            {
                if (value.Trim() == ".   .   -")
                    rg = "";
                else
                    rg = value;
            }
        }

        public string Uf
        {
            get => uf;
            set
            {
                if (value.Length > 2)
                    throw new Exception("UF inválido");
                else
                    uf = value.ToUpper();
            }
        }

        public string Cidade { get => cidade; set => cidade = value; }

        public string Bairro { get => bairro; set => bairro = value; }

        public string Endereco { get => endereco; set => endereco = value; }

        public string Numero { get => numero; set => numero = value; }

        public string Complemento { get => complemento; set => complemento = value; }

        /// <summary>
        /// Caminho completo da imagem
        /// </summary>
        public string Imagem
        {
            get
            {
                if (String.IsNullOrEmpty(imagem))
                    return null;
                else
                    return imagem;
            }
            set
            {
                imagem = SalvaImagem(value);
            }
        }

        public string Imagem_caminho_completo
        {
            get
            {
                if (String.IsNullOrEmpty(imagem))
                    return null;
                else
                    return bancoDeImagens + imagem;
            }
        }

        public bool Ativo { get => ativo; set => ativo = value; }
        
    }
}

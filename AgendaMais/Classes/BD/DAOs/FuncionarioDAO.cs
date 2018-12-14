using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;

namespace AgendaMais.Classes
{
    class FuncionarioDAO : DAO
    {
        static FuncionarioVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                FuncionarioVO f = new FuncionarioVO();
                f.Id = Convert.ToInt32(row["id"]);
                f.Nome = row["nome"].ToString();
                f.Tel_cel = row["tel_cel"].ToString();
                f.Email = row["email"].ToString();
                f.Recado = row["recado"].ToString();
                f.Cpf = row["cpf"].ToString();
                f.Rg = row["rg"].ToString();
                f.Uf = row["uf"].ToString();
                f.Cidade = row["cidade"].ToString();
                f.Bairro = row["bairro"].ToString();
                f.Endereco = row["endereco"].ToString();
                f.Numero = row["numero"].ToString();
                f.Complemento = row["complemento"].ToString();
                f.Imagem = row["imagem"].ToString();
                return f;
            }
            else
                return null;
        }

        static List<FuncionarioVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<FuncionarioVO> listFuncionarioVO = new List<FuncionarioVO>();
                for (int i = 0; i < table.Rows.Count; i++)
                    listFuncionarioVO.Add(MontaVO(table.Rows[i]));
                return listFuncionarioVO;

            }
            else
                return null;
        }

        public static int ProximoID()
        {
            return DB.ProximoID("funcionario");
        }

        public static List<FuncionarioVO> GetTodosRegistros()
        {
            return MontaListVO(DAO.GetTodosRegistros("funcionario"));
        }

        public static FuncionarioVO GetRegistroPorId(int id)
        {
            return MontaVO(DAO.GetRegistroPorId("funcionario", id).Rows[0]);
        }

        public static List<FuncionarioVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("funcionario", condicao));
        }

        public static void InserirRegistros(FuncionarioVO funcionario)
        {
            string sql = "Insert Into funcionario( " +
                            "nome, " +
                            "tel_cel, " +
                            "email, " +
                            "recado, " +
                            "cpf," +
                            "rg, " +
                            "uf, " +
                            "cidade, " +
                            "bairro, " +
                            "endereco, " +
                            "numero, " +
                            "complemento," +
                            "imagem) " +
                         "values(" +
                            "'" + funcionario.Nome + "'," +
                            "'" + funcionario.Tel_cel + "'," +
                            "'" + funcionario.Email + "'," +
                            "'" + funcionario.Recado + "'," +
                            "'" + funcionario.Cpf + "'," +
                            "'" + funcionario.Rg + "'," +
                            "'" + funcionario.Uf + "'," +
                            "'" + funcionario.Cidade + "'," +
                            "'" + funcionario.Bairro + "'," +
                            "'" + funcionario.Endereco + "'," +
                            "'" + funcionario.Numero + "'," +
                            "'" + funcionario.Complemento + "'," +
                            "'" + funcionario.Imagem + "')";
            ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(FuncionarioVO funcionario)
        {
            string sql = "Update funcionario " +
                         "Set nome='" + funcionario.Nome + "'," +
                              " tel_cel='" + funcionario.Tel_cel + "'," +
                              " email='" + funcionario.Email + "'," +
                              " recado='" + funcionario.Recado + "'," +
                              " cpf='" + funcionario.Cpf + "'," +
                              " rg='" + funcionario.Rg + "'," +
                              " uf='" + funcionario.Uf + "'," +
                              " cidade='" + funcionario.Cidade + "'," +
                              " bairro='" + funcionario.Bairro + "'," +
                              " endereco='" + funcionario.Endereco + "'," +
                              " numero='" + funcionario.Numero + "'," +
                              " complemento='" + funcionario.Complemento + "'," +
                              " imagem='" + funcionario.Imagem + "'" +
                         " WHERE id=" + funcionario.Id;
            ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            List<string> sql = new List<string>();
            sql.Add($"Delete From agenda Where id_funcionario = {id}");
            sql.Add($"Delete From funcionario Where id = {id}");
            ExecutaSQL(sql);
        }
    }
}

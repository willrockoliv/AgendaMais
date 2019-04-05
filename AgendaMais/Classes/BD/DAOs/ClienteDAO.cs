using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace AgendaMais.Classes.DAOs
{
    class ClienteDAO : DAO
    {
        static ClienteVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                ClienteVO c = new ClienteVO();
                c.Id = Convert.ToInt32(row["id"]);
                c.Nome = row["nome"].ToString();
                c.Tel_cel = row["tel_cel"].ToString();
                c.Email = row["email"].ToString();
                c.Recado = row["recado"].ToString();
                c.Cpf = row["cpf"].ToString();
                c.Rg = row["rg"].ToString();
                c.Uf = row["uf"].ToString();
                c.Cidade = row["cidade"].ToString();
                c.Bairro = row["bairro"].ToString();
                c.Endereco = row["endereco"].ToString();
                c.Numero = row["numero"].ToString();
                c.Complemento = row["complemento"].ToString();
                c.Imagem = row["imagem"].ToString();
                c.Ativo = Convert.ToBoolean(row["ativo"]);
                return c;
            }
            else
                return null;
        }

        static List<ClienteVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<ClienteVO> listClienteVO = new List<ClienteVO>();
                for (int i = 0; i < table.Rows.Count; i++)
                    listClienteVO.Add(MontaVO(table.Rows[i]));
                return listClienteVO;
            }
            else
                return null;
        }

        public static int ProximoID()
        {
            return DB.ProximoID("cliente");
        }

        public static List<ClienteVO> GetTodosRegistrosAtivos()
        {
            return MontaListVO(DAO.GetTodosRegistrosAtivos("cliente"));
        }

        public static List<ClienteVO> GetTodosRegistrosNaoAtivos()
        {
            return MontaListVO(DAO.GetTodosRegistrosNaoAtivos("cliente"));
        }

        public static List<ClienteVO> GetTodosRegistros()
        {
            return MontaListVO(DAO.GetTodosRegistros("cliente"));
        }

        public static ClienteVO GetRegistroPorId(int id)
        {
            return MontaVO(DAO.GetRegistroPorId("cliente", id).Rows[0]);
        }

        public static List<ClienteVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("cliente", condicao));
        }

        public static void InserirRegistros(ClienteVO cliente)
        {
            string sql = "Insert Into cliente( " +
                            "nome, " +
                            "tel_cel, " +
                            "email, " +
                            "recado, " +
                            "cpf, " +
                            "rg, " +
                            "uf, " +
                            "cidade, " +
                            "bairro, " +
                            "endereco, " +
                            "numero, " +
                            "complemento," +
                            "imagem," +
                            "ativo) " +
                         "values(" +
                            $"'{cliente.Nome}'," +
                            $"'{cliente.Tel_cel}'," +
                            $"'{cliente.Email}'," +
                            $"'{cliente.Recado}'," +
                            $"'{cliente.Cpf}'," +
                            $"'{cliente.Rg}'," +
                            $"'{cliente.Uf}'," +
                            $"'{cliente.Cidade}'," +
                            $"'{cliente.Bairro}'," +
                            $"'{cliente.Endereco}'," +
                            $"'{cliente.Numero}'," +
                            $"'{cliente.Complemento}'," +
                            $"'{cliente.Imagem}'," +
                            $"{cliente.Ativo})";
            ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(ClienteVO cliente)
        {
            string sql = "Update cliente " +
                        $"Set nome='{cliente.Nome}'," +
                              $"tel_cel='{cliente.Tel_cel}'," +
                              $"email='{cliente.Email}'," +
                              $"recado='{cliente.Recado}'," +
                              $"cpf='{cliente.Cpf}'," +
                              $"rg='{cliente.Rg}'," +
                              $"uf='{cliente.Uf}'," +
                              $"cidade='{cliente.Cidade}'," +
                              $"bairro='{cliente.Bairro}'," +
                              $"endereco='{cliente.Endereco}'," +
                              $"numero='{cliente.Numero}'," +
                              $"complemento='{cliente.Complemento}'," +
                              $"imagem='{cliente.Imagem}'," +
                              $"ativo={cliente.Ativo} " +
                         "WHERE id=" + cliente.Id;
            ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            ExecutaSQL($"UPDATE cliente SET ativo={false} WHERE id={id}");
        }
    }
}

using AgendaMais.Classes.BD.VOs;
using AgendaMais.Classes.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.DAOs
{
    class LanctoContaDAO : DB
    {
        static LanctoContaVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                LanctoContaVO lanctoContaVO = new LanctoContaVO();
                lanctoContaVO.Id = Convert.ToInt32(row["id"]);
                lanctoContaVO.Id_conta = Convert.ToInt32(row["id_conta"]);
                if (row["Id_pessoa"] != DBNull.Value)
                    lanctoContaVO.Id_pessoa = row["Id_pessoa"].ToString();
                lanctoContaVO.Data = Convert.ToDateTime(row["data"]);
                lanctoContaVO.Valor = Convert.ToDouble(row["valor"]);
                lanctoContaVO.Fixa = Convert.ToBoolean(row["fixa"]);
                lanctoContaVO.Repetir = Convert.ToBoolean(row["repetir"]);
                if (row["qtd_repeticoes"] != DBNull.Value)
                    lanctoContaVO.Qtd_repeticoes = Convert.ToInt32(row["qtd_repeticoes"]);
                lanctoContaVO.Pago = Convert.ToBoolean(row["pago"]);

                return lanctoContaVO;
            }
            else
                return null;
        }

        static List<LanctoContaVO> MontaListVO(DataTable table_lancto_conta)
        {
            if (table_lancto_conta != null)
            {
                List<LanctoContaVO> listLanctoContaVO = new List<LanctoContaVO>();

                for (int i = 0; i < table_lancto_conta.Rows.Count; i++)
                    listLanctoContaVO.Add(MontaVO(table_lancto_conta.Rows[i]));

                return listLanctoContaVO;
            }
            else
                return null;
        }

        public static int ProximoId()
        {
            return DB.ProximoID("lancto_conta");
        }

        public static List<LanctoContaVO> GetTodosRegistros()
        {
            string sql = "SELECT * FROM lancto_conta ORDER BY data";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetTodosRegistros(string order_by)
        {
            string sql = $"SELECT * FROM lancto_conta ORDER BY {order_by}";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static LanctoContaVO GetRegistroPorId(int id)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE id={id}";
            return MontaVO(DAO.ExecutaSelect(sql).Rows[0]);
        }

        public static List<LanctoContaVO> GetRegistroPorId_conta(int id)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE id_conta={id} ORDER BY data";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistroPorId_conta(int id, string order_by)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE id_conta={id} ORDER BY {order_by}";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistroPorId_pessoa(int id)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE id_pessoa={id} ORDER BY data";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistroPorId_pessoa(int id, string order_by)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE id_pessoa={id} ORDER BY {order_by}";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistroPorPeriodo(DateTime data_ini, DateTime data_fim)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE data BETWEEN '{data_ini}' AND '{data_fim}' ORDER BY data";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistroPorPeriodo(DateTime data_ini, DateTime data_fim, string order_by)
        {
            string sql = $"SELECT * FROM lancto_conta WHERE data BETWEEN '{data_ini}' AND '{data_fim}' ORDER BY {order_by}";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static List<LanctoContaVO> GetRegistros(string condicao)
        {
            string sql = $"SELECT * FROM lancto_conta " + condicao;
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static void InserirRegistros(LanctoContaVO lanctoContaVO)
        {
            string sql = $"INSERT INTO lancto_conta VALUES(" +
                            $"{lanctoContaVO.Id}," +
                            $"{lanctoContaVO.Id_conta}," +
                            $"{lanctoContaVO.Id_pessoa}," +
                            $"'{lanctoContaVO.Data}'," +
                            $"{lanctoContaVO.Valor}," +
                            $"{lanctoContaVO.Fixa}," +
                            $"{lanctoContaVO.Repetir}," +
                            $"{lanctoContaVO.Qtd_repeticoes}," +
                            $"{lanctoContaVO.Pago})";
            ExecutaSQL(sql);
        }

        public static void InserirRegistros(List<LanctoContaVO> listLanctoContaVO)
        {
            List<string> listSql = new List<string>();

            foreach (LanctoContaVO lanctoContaVO in listLanctoContaVO)
            {
                string sql = $"INSERT INTO lancto_conta VALUES(" +
                            $"{lanctoContaVO.Id}," +
                            $"{lanctoContaVO.Id_conta}," +
                            $"{lanctoContaVO.Id_pessoa}," +
                            $"'{lanctoContaVO.Data}'," +
                            $"{lanctoContaVO.Valor.ToString().Replace(',', '.')}," +
                            $"{lanctoContaVO.Fixa}," +
                            $"{lanctoContaVO.Repetir}," +
                            $"{lanctoContaVO.Qtd_repeticoes}," +
                            $"{lanctoContaVO.Pago})";
                listSql.Add(sql);
            }

            ExecutaSQL(listSql);
        }

        public static void AtualizarRegistro(LanctoContaVO lanctoContaVO)
        {
            string sql = $"UPDATE lancto_conta SET " +
                            $"id_conta={lanctoContaVO.Id_conta}," +
                            $"id_pessoa={lanctoContaVO.Id_pessoa}," +
                            $"data='{lanctoContaVO.Data}'," +
                            $"valor={lanctoContaVO.Valor.ToString().Replace(',', '.')}," +
                            $"fixa={lanctoContaVO.Fixa}," +
                            $"repetir={lanctoContaVO.Repetir}," +
                            $"qtd_repeticoes={lanctoContaVO.Qtd_repeticoes}," +
                            $"pago={lanctoContaVO.Pago} " +
                         $"WHERE id={lanctoContaVO.Id}";
            ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(List<LanctoContaVO> listLanctoContaVO)
        {
            List<string> listSql = new List<string>();

            foreach (LanctoContaVO lanctoContaVO in listLanctoContaVO)
            {
                string sql = $"UPDATE lancto_conta SET " +
                            $"id_conta={lanctoContaVO.Id_conta}," +
                            $"id_pessoa={lanctoContaVO.Id_pessoa}," +
                            $"data='{lanctoContaVO.Data}'," +
                            $"valor={lanctoContaVO.Valor.ToString().Replace(',', '.')}," +
                            $"fixa={lanctoContaVO.Fixa}," +
                            $"repetir={lanctoContaVO.Repetir}," +
                            $"qtd_repeticoes={lanctoContaVO.Qtd_repeticoes}," +
                            $"pago={lanctoContaVO.Pago} " +
                         $"WHERE id={lanctoContaVO.Id}";
                listSql.Add(sql);
            }

            ExecutaSQL(listSql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = $"DELETE from lancto_conta WHERE id={id}";
            DB.ExecutaSQL(sql);
        }
    }
}

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
    class ContaDAO : DB
    {
        static ContaVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                ContaVO contaVO = new ContaVO();
                contaVO.Id = Convert.ToInt32(row["id"]);
                contaVO.Descricao = row["descricao"].ToString();
                if (Convert.ToInt16(row["tipo_conta"]) == (int)ContaVO.EnumTipoConta.a_pagar)
                    contaVO.TipoConta = ContaVO.EnumTipoConta.a_pagar;
                else if (Convert.ToInt16(row["tipo_conta"]) == (int)ContaVO.EnumTipoConta.a_receber)
                    contaVO.TipoConta = ContaVO.EnumTipoConta.a_receber;
                else
                    throw new Exception($"TipoConta do registro ID={contaVO.Id} da tabela Conta inválido.");

                contaVO.Ativo = Convert.ToBoolean(row["ativo"]);

                return contaVO;
            }
            else
                return null;
        }

        static List<ContaVO> MontaListVO(DataTable table_conta)
        {
            if (table_conta != null)
            {
                List<ContaVO> listContaVO = new List<ContaVO>();

                for (int i = 0; i < table_conta.Rows.Count; i++)
                    listContaVO.Add(MontaVO(table_conta.Rows[i]));

                return listContaVO;
            }
            else
                return null;
        }

        public static int ProximoId()
        {
            return DB.ProximoID("conta");
        }

        public static List<ContaVO> GetTodosRegistros()
        {
            string sql = "SELECT * FROM conta";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static ContaVO GetRegistroPorId(int id)
        {
            string sql = $"SELECT * FROM conta WHERE id={id}";
            return MontaVO(DAO.ExecutaSelect(sql).Rows[0]);
        }

        public static List<ContaVO> GetRegistros(string condicao)
        {
            string sql = $"SELECT * FROM conta " + condicao;
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static void InserirRegistros(ContaVO contaVO)
        {
            string sql = $"INSERT INTO conta VALUES(" +
                            $"{contaVO.Id}," +
                            $"'{contaVO.Descricao}'," +
                            $"{(int)contaVO.TipoConta}," +
                            $"{contaVO.Ativo})";
            ExecutaSQL(sql);
        }

        public static void InserirRegistros(List<ContaVO> listContaVO)
        {
            List<string> listSql = new List<string>();

            foreach (ContaVO contaVO in listContaVO)
            {
                string sql = $"INSERT INTO conta VALUES(" +
                                $"{contaVO.Id}," +
                                $"'{contaVO.Descricao}'," +
                                $"{(int)contaVO.TipoConta}," +
                                $"{contaVO.Ativo})";
                listSql.Add(sql);
            }

            ExecutaSQL(listSql);
        }

        public static void AtualizarRegistro(ContaVO contaVO)
        {
            string sql = $"UPDATE conta SET " +
                            $"descricao='{contaVO.Descricao}'," +
                            $"tipo_conta={(int)contaVO.TipoConta}," +
                            $"ativo={contaVO.Ativo}) " +
                            $"WHERE id={contaVO.Id},";
            ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(List<ContaVO> listContaVO)
        {
            List<string> listSql = new List<string>();

            foreach (ContaVO contaVO in listContaVO)
            {
                string sql = $"UPDATE conta SET " +
                            $"descricao='{contaVO.Descricao}'," +
                            $"tipo_conta={(int)contaVO.TipoConta}," +
                            $"ativo={contaVO.Ativo}) " +
                            $"WHERE id={contaVO.Id},";
                listSql.Add(sql);
            }
            
            ExecutaSQL(listSql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = $"UPDATE conta SET ativo={false} WHERE id={id}";
            DB.ExecutaSQL(sql);
        }
    }
}

using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class VendaDAO : DAO
    {
        static VendaVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                VendaVO vendaVO = new VendaVO();
                vendaVO.Id = Convert.ToInt32(row["id"]);
                vendaVO.Valor = Convert.ToDouble(row["valor"]);
                vendaVO.Custo = Convert.ToDouble(row["custo"]);
                vendaVO.Desconto = Convert.ToDouble(row["desconto"]);
                vendaVO.Data_hora = Convert.ToDateTime(row["data_hora"]);
                return vendaVO;
            }
            else
                return null;
        }

        static List<VendaVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<VendaVO> listVendaVO = new List<VendaVO>();
                for (int i = 0; i < table.Rows.Count; i++)
                    listVendaVO.Add(MontaVO(table.Rows[i]));
                return listVendaVO;
            }
            else
                return null;
        }

        public List<VendaVO> GetTodosRegistros()
        {
            return MontaListVO(DAO.GetTodosRegistros("venda"));
        }

        public static VendaVO GetRegistroPorId(int id)
        {
            return MontaVO(DAO.GetRegistroPorId("venda", id).Rows[0]);
        }

        public static List<VendaVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("venda", condicao));
        }

        public static void InserirRegistros(VendaVO venda)
        {
            string sql = "Insert Into venda(" +
                            "valor," +
                            "custo," +
                            "desconto," +
                            "data_hora" +
                         ")" +
                         "Values(" +
                            venda.Valor + "," +
                            venda.Custo + "," +
                            venda.Desconto + "," +
                            "'" + venda.Data_hora + "'," +
                         ")";
            ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(VendaVO venda)
        {
            string sql = "Update venda " +
                         "Set " +
                            "valor=" + venda.Valor + "," +
                            "custo=" + venda.Custo + "," +
                            "desconto=" + venda.Desconto + "," +
                            "data_hora='" + venda.Data_hora + "'" +
                         " where id=" + venda.Id;
            ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = String.Format("Delete From venda Where id={0}", id);
            ExecutaSQL(sql);
        }
    }
}

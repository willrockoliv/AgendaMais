using AgendaMais.Classes.VOs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class ItemVendaDAO : DAO
    {
        static ItemVendaVO MontaVO(DataRow row)
        {
            ItemVendaVO itemVendaVO = new ItemVendaVO();
            itemVendaVO.Id_produto = Convert.ToInt32(row["id_produto"]);
            itemVendaVO.Id_venda = Convert.ToInt32(row["id_venda"]);
            itemVendaVO.Quantidade = Convert.ToInt32(row["quantidade"]);
            itemVendaVO.Desconto = Convert.ToDouble(row["desconto"]);
            return itemVendaVO;
        }

        static List<ItemVendaVO> MontaListItemVenda(DataTable table)
        {
            List<ItemVendaVO> listItemVendaVO = new List<ItemVendaVO>();
            foreach (DataRow row in table.Rows)
                listItemVendaVO.Add(MontaVO(row));
            return listItemVendaVO;
        }

        public static List<ItemVendaVO> GetTodosRegistros()
        {
            return MontaListItemVenda(DAO.GetTodosRegistros("item_venda"));
        }

        public static List<ItemVendaVO> GetRegistroPorId(int id_produto, int id_venda)
        {
            string condicao = string.Format("where id_produto={0} and id_venda={1})", id_produto, id_venda);
            return MontaListItemVenda(DAO.GetRegistros("item_venda", condicao));
        }

        public static List<ItemVendaVO> GetRegistroPorIdProduto(int id_produto)
        {
            string condicao = string.Format("where id_produto={0})", id_produto);
            return MontaListItemVenda(DAO.GetRegistros("item_venda", condicao));
        }

        public static List<ItemVendaVO> GetRegistroPorIdVenda(int id_venda)
        {
            string condicao = string.Format("where id_venda={0}", id_venda);
            return MontaListItemVenda(DAO.GetRegistros("item_venda", condicao));
        }

        public static List<ItemVendaVO> GetRegistros(string condicao)
        {
            return MontaListItemVenda(DAO.GetRegistros("item_venda", condicao));
        }

        public static void InserirRegistros(ItemVendaVO itemVenda)
        {
            string sql = "Insert Into item_venda(" +
                            "id_produto, " +
                            "id_venda, " +
                            "quantidade, " +
                            "desconto) " +
                          "values(" +
                            itemVenda.Id_produto + "," +
                            itemVenda.Id_venda + "," +
                            itemVenda.Quantidade + "," +
                            itemVenda.Desconto + ")";
            DAO.ExecutaSQL(sql);
        }

        public static void InserirRegistros(ItemVendaVO[] itemVenda)
        {
            string sql = "Insert Into item_venda(" +
                            "id_produto, " +
                            "id_venda, " +
                            "quantidade, " +
                            "desconto) " +
                          "values ";

            string values = "";

            for (int i = 0; i < itemVenda.Length; i++)
            {
                values += "(" +
                              itemVenda[i].Id_produto + "," +
                              itemVenda[i].Id_venda + "," +
                              itemVenda[i].Quantidade + "," +
                              itemVenda[i].Desconto +
                              ")";
            }

            DAO.ExecutaSQL(sql + values);
        }

        public static void AtualizarRegistro(ItemVendaVO itemVenda)
        {
            string sql = "UPDATE item_venda SET " +
                            "quantidade=" + itemVenda.Quantidade + "," +
                            "desconto=" + itemVenda.Desconto +
                         "WHERE " +
                            "id_produto=" + itemVenda.Id_produto + " AND " +
                            "id_venda=" + itemVenda.Id_venda;
            DAO.ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = "DELETE item_venda WHERE id=" + id;
            DAO.ExecutaSQL(sql);
        }
    }
}

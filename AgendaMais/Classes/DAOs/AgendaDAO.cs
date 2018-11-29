using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;

namespace AgendaMais.Classes.DAOs
{
    class AgendaDAO : DB
    {
        static AgendaVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                AgendaVO agendaVO = new AgendaVO();
                agendaVO.Id = Convert.ToInt32(row["id"]);
                agendaVO.Id_venda = Convert.ToInt32(row["id_venda"]);
                agendaVO.Id_cliente = Convert.ToInt32(row["id_cliente"]);
                agendaVO.Nome_cliente = row["nome_cliente"].ToString();
                agendaVO.Tel_cel = row["tel_cel"].ToString();
                agendaVO.Id_funcionario = Convert.ToInt32(row["id_funcionario"]);
                agendaVO.Nome_funcionario = row["nome_funcionario"].ToString();
                agendaVO.Data = Convert.ToDateTime(row["data"]);
                agendaVO.Hora = Convert.ToDateTime(row["hora"]);
                agendaVO.Obs = row["obs"].ToString();
                agendaVO.Status = Convert.ToChar(row["status"]);

                List<ItemVendaVO> listItemVendaVO = ItemVendaDAO.GetRegistroPorIdVenda(agendaVO.Id_venda);
                List<ProdutoVO> listProdutoVO = new List<ProdutoVO>();
                foreach (ItemVendaVO item in listItemVendaVO)
                    listProdutoVO.Add(ProdutoDAO.GetRegistroPorId(item.Id_produto));

                agendaVO.Itens = listProdutoVO;

                //string sql = string.Format("select p.descricao, p.vl_venda from item_venda iv inner join produto p on iv.id_produto=p.id where iv.id_venda={0}", agendaVO.Id_venda);
                //DataTable table_serv_prod = DAO.ExecutaSelect(sql);
                //agendaVO.Itens = new List<ProdutoVO>();
                //for (int i = 0; i < table_serv_prod.Rows.Count; i++)
                //{
                //    ProdutoVO p = new ProdutoVO();
                //    p.Descricao = table_serv_prod.Rows[i]["descricao"].ToString();
                //    p.Vl_venda = Convert.ToDouble(table_serv_prod.Rows[i]["vl_venda"]);
                //    agendaVO.Itens.Add(p);
                //}

                return agendaVO;
            }
            else
                return null;
        }

        static List<AgendaVO> MontaListVO(DataTable table_agenda)
        {
            if (table_agenda != null)
            {
                List<AgendaVO> listAgenda = new List<AgendaVO>();

                for (int i = 0; i < table_agenda.Rows.Count; i++)
                    listAgenda.Add(MontaVO(table_agenda.Rows[i]));

                return listAgenda;
            }
            else
                return null;
        }

        public static List<AgendaVO> GetTodosRegistros()
        {
            string sql = "select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario " +
                         "from agenda a " +
                         "inner join cliente c on a.id_cliente=c.id " +
                         "inner join funcionario f on a.id_funcionario=f.id " +
                         "order by a.data, a.hora";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static AgendaVO GetRegistroPorId(int id)
        {
            string sql = string.Format("select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario " +
                                       "from agenda a " +
                                       "inner join cliente c on a.id_cliente=c.id " +
                                       "inner join funcionario f on a.id_funcionario=f.id " +
                                       "where a.id = {0}", id);
            return MontaVO(DAO.ExecutaSelect(sql).Rows[0]);
        }

        public static List<AgendaVO> GetRegistros(string condicao)
        {
            string sql = "select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario " +
                         "from agenda a " +
                         "inner join cliente c on a.id_cliente=c.id " +
                         "inner join funcionario f on a.id_funcionario=f.id " +
                         condicao;
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static void InserirRegistros(AgendaVO agendaVO)
        {
            #region  Monta VendaVO
            VendaVO vendaVO = new VendaVO();
            //vendaVO.Id = agendaVO.Id;
            foreach (ProdutoVO item in agendaVO.Itens)
                vendaVO.Valor += item.Vl_venda;
            vendaVO.Desconto = 0;
            vendaVO.Data = agendaVO.Data;
            vendaVO.Hora = agendaVO.Hora;
            #endregion

            #region Monta ItensVendaVO
            List<ItemVendaVO> listItemVendaVO = new List<ItemVendaVO>();
            foreach (ProdutoVO p in agendaVO.Itens)
            {
                ItemVendaVO item = new ItemVendaVO();
                item.Id_produto = p.Id;
                item.Id_venda = agendaVO.Id_venda;
                item.Quantidade = 1;
                item.Desconto = 0;

                for (int i = 0; i < listItemVendaVO.Count; i++)
                {
                    if (listItemVendaVO[i].Id_produto == item.Id_produto)
                    {
                        listItemVendaVO[i].Quantidade++;
                        break;
                    }
                    else if (i == listItemVendaVO.Count - 1)
                    {
                        listItemVendaVO.Add(item);
                        break;
                    }
                }

                if (listItemVendaVO.Count == 0)
                    listItemVendaVO.Add(item);
            }
            #endregion

            string insert_venda = "Insert Into venda(" +
                                     "valor," +
                                     "desconto," +
                                     "data," +
                                     "hora) " +
                                  "Values(" +
                                     vendaVO.Valor.ToString().Replace(',', '.') + "," +
                                     vendaVO.Desconto.ToString().Replace(',', '.') + "," +
                                     "'" + vendaVO.Data + "'," +
                                     "'" + vendaVO.Hora + "'" +
                                  ");";

            string insert_agenda = "Insert Into agenda(" +
                                      "id_venda," +
                                      "id_cliente," +
                                      "id_funcionario," +
                                      "data," +
                                      "hora," +
                                      "obs," +
                                      "status" +
                                   ")" +
                                   "Values(" +
                                      agendaVO.Id_venda + "," +
                                      agendaVO.Id_cliente + "," +
                                      agendaVO.Id_funcionario + "," +
                                      "'" + agendaVO.Data + "'," +
                                      "'" + agendaVO.Hora + "'," +
                                      "'" + agendaVO.Obs + "'," +
                                      "'" + agendaVO.Status + "'" +
                                   ");";

            string insert_item_venda = "Insert Into item_venda(" +
                                         "id_produto, " +
                                         "id_venda, " +
                                         "quantidade, " +
                                         "desconto) " +
                                       "values ";

            string values_item_venda = "";
            for (int i = 0; i < listItemVendaVO.Count; i++)
            {
                values_item_venda += "(" +
                                        listItemVendaVO[i].Id_produto + "," +
                                        listItemVendaVO[i].Id_venda + "," +
                                        listItemVendaVO[i].Quantidade + "," +
                                        listItemVendaVO[i].Desconto.ToString().Replace(',', '.') +
                                     ")";
                if (i != listItemVendaVO.Count - 1)
                    values_item_venda += ",";
            }
            values_item_venda += ";";
            insert_item_venda += values_item_venda;

            List<string> list_sql = new List<string>();
            list_sql.Add(insert_venda);
            list_sql.Add(insert_agenda);
            list_sql.Add(insert_item_venda);
            ExecutaSQL(list_sql);

            #region old
            //try
            //{
            //    ExecutaSQL(insert_venda);
            //}
            //catch (Exception erro)
            //{
            //    throw new Exception("Erro ao inserir na tabela venda: " + erro.Message);
            //}

            //try
            //{
            //    ExecutaSQL(insert_agenda);
            //}
            //catch (Exception erro)
            //{
            //    ExecutaSQL("delete from venda where id=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence venda_id_seq restart with " + agendaVO.Id_venda);

            //    throw new Exception("Erro ao inserir na tabela agenda: " + erro.Message);
            //}

            //try
            //{
            //    ExecutaSQL(insert_item_venda);
            //}
            //catch (Exception erro)
            //{
            //    ExecutaSQL("delete from agenda where id_venda=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence agenda_id_seq restart with " + agendaVO.Id_venda);

            //    ExecutaSQL("delete from venda where id=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence venda_id_seq restart with " + agendaVO.Id_venda);

            //    throw new Exception("Erro ao inserir na tabela item_venda: " + erro.Message);
            //}
            #endregion
        }

        public static void AtualizarRegistro(AgendaVO agendaVO)
        {
            #region  Monta VendaVO
            VendaVO vendaVO = new VendaVO();
            vendaVO.Id = agendaVO.Id_venda;
            foreach (ProdutoVO item in agendaVO.Itens)
                vendaVO.Valor += item.Vl_venda;
            vendaVO.Desconto = 0;
            vendaVO.Data = agendaVO.Data;
            vendaVO.Hora = agendaVO.Hora;
            #endregion

            #region Monta ItensVendaVO
            List<ItemVendaVO> listItemVendaVO = new List<ItemVendaVO>();
            foreach (ProdutoVO p in agendaVO.Itens)
            {
                ItemVendaVO item = new ItemVendaVO();
                item.Id_produto = p.Id;
                item.Id_venda = agendaVO.Id_venda;
                item.Quantidade = 1;
                item.Desconto = 0;

                for (int i = 0; i < listItemVendaVO.Count; i++)
                {
                    if (listItemVendaVO[i].Id_produto == item.Id_produto)
                    {
                        listItemVendaVO[i].Quantidade++;
                        break;
                    }
                    else if (i == listItemVendaVO.Count - 1)
                    {
                        listItemVendaVO.Add(item);
                        break;
                    }
                }

                if (listItemVendaVO.Count == 0)
                    listItemVendaVO.Add(item);
            }
            #endregion

            List<string> list_sql = new List<string>();

            string update_venda = "UPDATE venda SET " +
                                  "valor=" + vendaVO.Valor.ToString().Replace(',', '.') + "," +
                                  "desconto=" + vendaVO.Desconto.ToString().Replace(',', '.') + "," +
                                  "data='" + vendaVO.Data + "'," +
                                  "hora='" + vendaVO.Hora + "' " +
                                  "WHERE id=" + vendaVO.Id;
            list_sql.Add(update_venda);

            string update_agenda = "Update agenda " +
                                   "Set id_venda=" + agendaVO.Id_venda + "," +
                                       "id_cliente=" + agendaVO.Id_cliente + "," +
                                       "id_funcionario=" + agendaVO.Id_funcionario + "," +
                                       "data='" + agendaVO.Data + "'" + "," +
                                       "hora='" + agendaVO.Hora + "'" + "," +
                                       "obs='" + agendaVO.Obs + "'" + "," +
                                       "status='" + agendaVO.Status + "'" +
                                   "where id=" + agendaVO.Id;
            list_sql.Add(update_agenda);

            foreach (ItemVendaVO item in listItemVendaVO)
                list_sql.Add("UPDATE item_venda SET " +
                                       "quantidade=" + item.Quantidade + ", " +
                                       "desconto=" + item.Desconto.ToString().Replace(',', '.') + " " +
                                       "WHERE id_produto=" + item.Id_produto + " and " +
                                              "id_venda=" + item.Id_venda);

            ExecutaSQL(list_sql);

            #region old
            //try
            //{
            //    ExecutaSQL(update_venda);
            //}
            //catch (Exception erro)
            //{
            //    throw new Exception("Erro ao atualizar na tabela venda: " + erro.Message);
            //}

            //try
            //{
            //    ExecutaSQL(update_agenda);
            //}
            //catch (Exception erro)
            //{
            //    ExecutaSQL("delete from venda where id=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence venda_id_seq restart with " + agendaVO.Id_venda);

            //    throw new Exception("Erro ao atualizar na tabela agenda: " + erro.Message);
            //}

            //try
            //{
            //    ExecutaSQL(insert_item_venda);
            //}
            //catch (Exception erro)
            //{
            //    ExecutaSQL("delete from agenda where id_venda=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence agenda_id_seq restart with " + agendaVO.Id_venda);

            //    ExecutaSQL("delete from venda where id=" + agendaVO.Id_venda);
            //    ExecutaSQL("alter sequence venda_id_seq restart with " + agendaVO.Id_venda);

            //    throw new Exception("Erro ao inserir na tabela item_venda: " + erro.Message);
            //}
            #endregion
        }

        public static void DeletarRegistro(int id)
        {
            string sql = String.Format("Delete From agenda Where id={0}", id);
            ExecutaSQL(sql);
        }
    }
}

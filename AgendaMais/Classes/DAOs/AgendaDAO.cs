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
                agendaVO.Id_cliente = Convert.ToInt32(row["id_cliente"]);
                agendaVO.Nome_cliente = row["nome_cliente"].ToString();
                agendaVO.Tel_cel = row["tel_cel"].ToString();
                agendaVO.Id_funcionario = Convert.ToInt32(row["id_funcionario"]);
                agendaVO.Nome_funcionario = row["nome_funcionario"].ToString();
                agendaVO.Data_hora = Convert.ToDateTime(row["data_hora"]);
                agendaVO.Obs = row["obs"].ToString();
                agendaVO.Status = Convert.ToChar(row["status"]);

                List<ItemAgendaVO> listItemVendaVO = ItemAgendaDAO.GetRegistroPorIdAgenda(agendaVO.Id);
                List<ProdutoVO> listProdutoVO = new List<ProdutoVO>();
                if (listItemVendaVO != null)
                    foreach (ItemAgendaVO item in listItemVendaVO)
                        for (int i = 0; i < item.Quantidade; i++)
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
                         "order by a.data_hora";
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
            #region Monta ItensVendaVO
            List<ItemAgendaVO> listItemAgendaVO = new List<ItemAgendaVO>();
            foreach (ProdutoVO p in agendaVO.Itens)
            {
                ItemAgendaVO item = new ItemAgendaVO();
                item.Id_produto = p.Id;
                item.Id_agenda = agendaVO.Id;
                item.Quantidade = 1;
                item.Desconto = 0;

                for (int i = 0; i < listItemAgendaVO.Count; i++)
                {
                    if (listItemAgendaVO[i].Id_produto == item.Id_produto)
                    {
                        listItemAgendaVO[i].Quantidade++;
                        break;
                    }
                    else if (i == listItemAgendaVO.Count - 1)
                    {
                        listItemAgendaVO.Add(item);
                        break;
                    }
                }

                if (listItemAgendaVO.Count == 0)
                    listItemAgendaVO.Add(item);
            }
            #endregion

            string insert_agenda = "Insert Into agenda(" +
                                      "id_cliente," +
                                      "id_funcionario," +
                                      "data_hora," +
                                      "obs," +
                                      "status" +
                                   ")" +
                                   "Values(" +
                                      agendaVO.Id_cliente + "," +
                                      agendaVO.Id_funcionario + "," +
                                      "'" + agendaVO.Data_hora + "'," +
                                      "'" + agendaVO.Obs + "'," +
                                      "'" + agendaVO.Status + "'" +
                                   ");";

            string insert_item_agenda = "Insert Into item_agenda(" +
                                            "id_produto, " +
                                            "id_agenda, " +
                                            "quantidade, " +
                                            "desconto) " +
                                       "values ";

            string values_item_agenda = "";
            for (int i = 0; i < listItemAgendaVO.Count; i++)
            {
                values_item_agenda += "(" +
                                        listItemAgendaVO[i].Id_produto + "," +
                                        listItemAgendaVO[i].Id_agenda + "," +
                                        listItemAgendaVO[i].Quantidade + "," +
                                        listItemAgendaVO[i].Desconto.ToString().Replace(',', '.') +
                                     ")";
                if (i != listItemAgendaVO.Count - 1)
                    values_item_agenda += ",";
            }
            values_item_agenda += ";";
            insert_item_agenda += values_item_agenda;

            List<string> list_sql = new List<string>();
            list_sql.Add(insert_agenda);
            list_sql.Add(insert_item_agenda);
            ExecutaSQL(list_sql);
        }

        public static void AtualizarRegistro(AgendaVO agendaVO)
        {
            #region Monta ItemAgendaVO
            List<ItemAgendaVO> listItemAgendaVO = new List<ItemAgendaVO>();
            foreach (ProdutoVO p in agendaVO.Itens)
            {
                ItemAgendaVO item = new ItemAgendaVO();
                item.Id_produto = p.Id;
                item.Id_agenda = agendaVO.Id;
                item.Quantidade = 1;
                item.Desconto = 0;

                for (int i = 0; i < listItemAgendaVO.Count; i++)
                {
                    if (listItemAgendaVO[i].Id_produto == item.Id_produto)
                    {
                        listItemAgendaVO[i].Quantidade++;
                        break;
                    }
                    else if (i == listItemAgendaVO.Count - 1)
                    {
                        listItemAgendaVO.Add(item);
                        break;
                    }
                }

                if (listItemAgendaVO.Count == 0)
                    listItemAgendaVO.Add(item);
            }
            #endregion

            List<string> list_sql = new List<string>();

            string update_agenda = "Update agenda " +
                                   "Set id_cliente=" + agendaVO.Id_cliente + "," +
                                       "id_funcionario=" + agendaVO.Id_funcionario + "," +
                                       "data_hora='" + agendaVO.Data_hora + "'" + "," +
                                       "obs='" + agendaVO.Obs + "'" + "," +
                                       "status='" + agendaVO.Status + "'" +
                                   "where id=" + agendaVO.Id;
            list_sql.Add(update_agenda);

            foreach (ItemAgendaVO item in listItemAgendaVO)
                list_sql.Add("UPDATE item_venda SET " +
                                       "quantidade=" + item.Quantidade + ", " +
                                       "desconto=" + item.Desconto.ToString().Replace(',', '.') + " " +
                                       "WHERE id_produto=" + item.Id_produto + " and " +
                                              "id_agenda=" + item.Id_agenda);

            ExecutaSQL(list_sql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = String.Format("Delete From agenda Where id={0}", id);
            ExecutaSQL(sql);
        }
    }
}

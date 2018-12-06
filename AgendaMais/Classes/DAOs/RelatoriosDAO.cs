using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class RelatoriosDAO : DB
    {
        #region Relatório DRE
        public struct DRE
        {
            public double
                receita_produto,
                receita_servico,
                receita_total,
                custo_produto,
                custo_servico,
                custo_total;
        }
        private DRE dre = new DRE();

        public DRE Dre { get => dre; }

        public void relatorio_DRE(DateTime data_ini, DateTime data_fim)
        {
            string sql = "select " +
                            "(case when " +
                                "sum(case when p.controla_estoque = 't' then(case when ia.vl_venda is null then 0 else ia.vl_venda end) else 0 end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when p.controla_estoque = 't' then(case when ia.vl_venda is null then 0 else ia.vl_venda end) else 0 end) " +
                            "end) as receita_produto,  " +
                            "(case when " +
                                "sum(case when p.controla_estoque = 'f' then(case when ia.vl_venda is null then 0 else ia.vl_venda end) else 0 end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when p.controla_estoque = 'f' then(case when ia.vl_venda is null then 0 else ia.vl_venda end) else 0 end) " +
                            "end) as receita_servico, " +
                            "(case when " +
                                "sum(case when ia.vl_venda is null then 0 else ia.vl_venda end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when ia.vl_venda is null then 0 else ia.vl_venda end) " +
                            "end) as receita_total, " +
                            "(case when " +
                                "sum(case when p.controla_estoque = 't' then(case when ia.vl_custo is null then 0 else ia.vl_custo end) else 0 end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when p.controla_estoque = 't' then(case when ia.vl_custo is null then 0 else ia.vl_custo end) else 0 end) " +
                            "end) as custo_produto, " +
                            "(case when " +
                                "sum(case when p.controla_estoque = 'f' then(case when ia.vl_custo is null then 0 else ia.vl_custo end) else 0 end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when p.controla_estoque = 'f' then(case when ia.vl_custo is null then 0 else ia.vl_custo end) else 0 end) " +
                            "end) as custo_servico, " +
                            "(case when " +
                                "sum(case when ia.vl_custo is null then 0 else ia.vl_custo end) is null " +
                            "then " +
                                "0 " +
                            "else " +
                                "sum(case when ia.vl_custo is null then 0 else ia.vl_custo end) " +
                            "end) as custo_total " +
                         "from item_agenda ia " +
                         "inner " +
                         "join produto p " +
                         "on ia.id_produto = p.id " +
                         "inner " +
                         "join agenda a " +
                         "on a.id = ia.id_agenda " +
                         "where " +
                            $"a.data_hora between '{data_ini.ToString()}' and '{data_fim.ToString()}' and " +
                             "a.status = 'C'";

            DataTable dt = ExecutaSelect(sql);
            if (dt.Rows.Count != 0)
                dre = new DRE
                {
                    receita_produto = Convert.ToDouble(dt.Rows[0]["receita_produto"]),
                    receita_servico = Convert.ToDouble(dt.Rows[0]["receita_servico"]),
                    receita_total = Convert.ToDouble(dt.Rows[0]["receita_total"]),
                    custo_produto = Convert.ToDouble(dt.Rows[0]["custo_produto"]),
                    custo_servico = Convert.ToDouble(dt.Rows[0]["custo_servico"]),
                    custo_total = Convert.ToDouble(dt.Rows[0]["custo_total"])
                };
        }
        #endregion

        #region Relatório Frequencia de Agendamentos
        public struct FreqAgendamentos
        {
            public int id_cliente;
            public string nome;
            public int qtd_agendamentos;
            public int confirmados;
            public int cancelados;
            public int pendentes;
            public int frequencia;
            public DateTime possivel_data_retorno;
        }

        private List<FreqAgendamentos> listFreqAgendamentos = new List<FreqAgendamentos>();

        public List<FreqAgendamentos> ListFreqAgendamentos { get => listFreqAgendamentos; }

        public void relatorio_FrequenciaDeAgendamentos()
        {
            List<ClienteVO> listClienteVO = ClienteDAO.GetTodosRegistros();

            foreach (ClienteVO clienteVO in listClienteVO)
            {
                string sql = "select " +
                                "status, " +
                                "data_hora " +
                             "from " +
                                "agenda " +
                            $"where id_cliente={clienteVO.Id} " +
                             "order by " +
                                "data_hora";

                DataTable dt = ExecutaSelect(sql);

                if (dt == null || dt.Rows.Count == 0)
                    return;

                FreqAgendamentos f = new FreqAgendamentos();
                f.id_cliente = clienteVO.Id;
                f.nome = clienteVO.Nome;

                DateTime data_anterior = new DateTime();
                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToChar(row["status"]) == 'C')
                        f.confirmados++;
                    else if (Convert.ToChar(row["status"]) == 'N')
                        f.cancelados++;
                    else if (Convert.ToChar(row["status"]) == 'P')
                        f.pendentes++;
                    f.qtd_agendamentos++;

                    if (f.confirmados == 1)
                        data_anterior = Convert.ToDateTime(row["data_hora"]);
                    else if(f.qtd_agendamentos == dt.Rows.Count)
                    {
                        if (Convert.ToChar(row["status"]) == 'C')
                        {
                            TimeSpan data = Convert.ToDateTime(row["data_hora"]) - data_anterior;
                            f.frequencia += data.Days;
                        }
                        if (f.confirmados > 1)
                        {
                            f.frequencia = f.frequencia / (f.confirmados - 1);
                            f.possivel_data_retorno = data_anterior.AddDays(f.frequencia);
                        }
                    }
                    else if(Convert.ToChar(row["status"]) == 'C')
                    {
                        TimeSpan data = Convert.ToDateTime(row["data_hora"]) - data_anterior;
                        f.frequencia += data.Days;
                        data_anterior = Convert.ToDateTime(row["data_hora"]);
                    }
                }

                listFreqAgendamentos.Add(f);
            }
        }
    }
    #endregion
}


using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static AgendaMais.Classes.VOs.AgendaVO;

namespace AgendaMais.Classes
{
    public class MetodosAgendamento
    {
        #region Variáveis Globais
        public enum ProdutoOuItem { produto, item }
        public List<ProdutoVO> listProdutos = new List<ProdutoVO>();
        public List<ProdutoVO> listItens = new List<ProdutoVO>();
        public List<TextBox> listTxtItens = new List<TextBox>();
        public List<ProdutoVO> listItensSelecionados = new List<ProdutoVO>();
        public List<TextBox> listTxtItensSelecionados = new List<TextBox>();
        public List<Panel> listPanAgendamentos = new List<Panel>();
        public List<AgendaVO> listAgenda = new List<AgendaVO>();

        #endregion

        #region Métodos Auxiliares
        /// <summary>
        /// Construtor do TextBox que exibe descrição e valor de venda do produto ou item selecionado
        /// </summary>
        /// <param name="posicao">Posição no FlowLayoutPanel</param>
        /// <param name="descricao">Descrição do produto ou item selecionado</param>
        /// <param name="vl_venda">Valor de venda do produto ou item selecionado</param>
        /// <returns>TextBox com decrição e valor de venda do produto ou item selecionado</returns>
        public TextBox ConstrutorProdutoOuItem(int posicao, string descricao, double vl_venda, ProdutoOuItem produtoOuItem)
        {
            TextBox txt = new TextBox();
            txt.Name = posicao.ToString();
            txt.BackColor = Color.FromArgb(215, 217, 223);
            txt.BorderStyle = BorderStyle.None;
            txt.Enabled = true;
            txt.Cursor = Cursors.Hand;
            txt.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, (0));
            txt.ForeColor = Color.DimGray;
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.Size = new Size(480, 53);
            txt.Text = descricao + "\r\n" + vl_venda.ToString("C");
            txt.WordWrap = false;
            txt.TabStop = false;
            if (produtoOuItem == ProdutoOuItem.produto)
                txt.Click += new EventHandler(txtProduto_Click);
            else if (produtoOuItem == ProdutoOuItem.item)
                txt.Click += new EventHandler(txtItem_Click);

            return txt;
        }

        /// <summary>
        /// Contrutor do Panel que exibe os detalhes do agendamento do funcionário selecionado
        /// </summary>
        /// <param name="dia_semana">dia da semana por extenso</param>
        /// <param name="horario">horário do agendamento</param>
        /// <param name="nome_cliente">no do cliente</param>
        /// <param name="Serv_prod">serviços e produtos referentes ao agendamento</param>
        /// <param name="id">posição do Panel no flpAgendaFuncionario</param>
        /// <returns></returns>
        Panel ConstrutorAgendamentosFuncionario(DateTime data, string horario, string nome_cliente, List<ProdutoVO> Serv_prod, int id)
        {
            Panel panAgendaFuncionario = new Panel();
            panAgendaFuncionario.Anchor = AnchorStyles.Top;
            panAgendaFuncionario.BackColor = Color.FromArgb(215, 217, 223);
            panAgendaFuncionario.Size = new Size(483, 65);
            panAgendaFuncionario.Name = "panAgendaFuncionario" + id;

            #region txtDiaSemana
            TextBox txtDiaSemana = new TextBox();
            txtDiaSemana.BackColor = Color.FromArgb(215, 217, 223);
            txtDiaSemana.BorderStyle = BorderStyle.None;
            txtDiaSemana.Enabled = false;
            txtDiaSemana.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaSemana.ForeColor = Color.FromArgb(64, 64, 64);
            txtDiaSemana.Location = new Point(7, 8);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.ReadOnly = true;
            txtDiaSemana.Size = new Size(65, 24);
            txtDiaSemana.TabIndex = 0;
            txtDiaSemana.Text = String.Format("{0} ({1})", DiaSemana(data).ToUpper().Substring(0, 3), data.Day);
            txtDiaSemana.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtHorario
            TextBox txtHorario = new TextBox();
            txtHorario.BackColor = Color.FromArgb(215, 217, 223);
            txtHorario.BorderStyle = BorderStyle.None;
            txtHorario.Enabled = false;
            txtHorario.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHorario.ForeColor = Color.FromArgb(64, 64, 64);
            txtHorario.Location = new Point(7, 32);
            txtHorario.Name = "txtHorario";
            txtHorario.ReadOnly = true;
            txtHorario.Size = new Size(65, 24);
            txtHorario.Text = horario;
            txtHorario.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region txtNomeCliente 
            TextBox txtNomeCliente = new TextBox();
            txtNomeCliente.BackColor = Color.FromArgb(215, 217, 223);
            txtNomeCliente.BorderStyle = BorderStyle.None;
            txtNomeCliente.Enabled = false;
            txtNomeCliente.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomeCliente.Location = new Point(78, 19);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(186, 24);
            txtNomeCliente.Text = nome_cliente;
            txtNomeCliente.TextAlign = HorizontalAlignment.Center;
            #endregion

            #region cbItensServicosCliente 
            ComboBox cbItensServicosCliente = new ComboBox();
            cbItensServicosCliente.FlatStyle = FlatStyle.Flat;
            cbItensServicosCliente.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbItensServicosCliente.FormattingEnabled = true;
            cbItensServicosCliente.Location = new Point(275, 4);
            cbItensServicosCliente.Name = "cbItensServicosCliente" + id;
            cbItensServicosCliente.Size = new Size(197, 30);
            foreach (ProdutoVO x in Serv_prod)
                cbItensServicosCliente.Items.Add(x.Descricao);
            if (cbItensServicosCliente.Items.Count != 0)
                cbItensServicosCliente.SelectedIndex = 0;
            cbItensServicosCliente.SelectedIndexChanged += new EventHandler(cbItensServicosCliente_SelectedIndexChanged);
            #endregion

            #region txtValorItensServico 
            if (Serv_prod.Count != 0)
            {
                TextBox txtValorItensServico = new TextBox();
                txtValorItensServico.BackColor = Color.FromArgb(215, 217, 223);
                txtValorItensServico.BorderStyle = BorderStyle.None;
                txtValorItensServico.Enabled = false;
                txtValorItensServico.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                txtValorItensServico.ForeColor = Color.FromArgb(64, 64, 64);
                txtValorItensServico.Location = new Point(374, 37);
                txtValorItensServico.Name = "txtValorItensServico" + id;
                txtValorItensServico.ReadOnly = true;
                txtValorItensServico.Size = new Size(97, 20);
                txtValorItensServico.Text = Serv_prod[0].Vl_venda.ToString("C");
                txtValorItensServico.TextAlign = HorizontalAlignment.Right;

                panAgendaFuncionario.Controls.Add(txtValorItensServico);
            }
            #endregion

            
            panAgendaFuncionario.Controls.Add(cbItensServicosCliente);
            panAgendaFuncionario.Controls.Add(txtNomeCliente);
            panAgendaFuncionario.Controls.Add(txtHorario);
            panAgendaFuncionario.Controls.Add(txtDiaSemana);

            return panAgendaFuncionario;
        }

        /// <summary>
        /// select 
        ///    a.*, 
        ///    c.nome as nome_cliente, 
        ///    c.tel_cel as tel_cel, 
        ///    f.nome as nome_funcionario 
        /// from 
        ///    agenda a 
        /// inner join 
        ///    cliente c 
        ///    on 
        ///       a.id_cliente = c.id 
        /// inner join 
        ///    funcionario f 
        ///    on 
        ///       a.id_funcionario = f.id 
        /// where 
        ///    between 
        ///       a.data = '{0}' and a.data = '{1}' and 
        ///       a.status = '{2}' and 
        ///       a.status = '{3}' and
        ///       a.status = '{4}' and 
        ///       f.id = {5}
        /// order by
        ///    a.data,
        ///    a.hora"
        /// </summary>
        public void Atualiza_listAgendaPorFuncionario(DateTime data_ini, DateTime data_fim, char status1, char status2, char status3, int id_funcionario)
        {
            listPanAgendamentos.Clear();
            listAgenda.Clear();

            // select agendamentos
            listAgenda = AgendaDAO.GetRegistros(string.Format("where a.data_hora between '{0}' and '{1}' and " +
                                                              "(a.status='{2}' or a.status='{3}' or a.status='{4}') and " +
                                                              "f.id = {5} " +
                                                              "order by a.data_hora",
                                                              data_ini.ToString(), data_fim.ToString(), status1, status2, status3, id_funcionario));
        }

        /// <summary>
        /// Exibe os agendamentos do funcionário selecionado
        /// </summary>
        /// <param name="flpAgendaFuncionario"></param>
        public void ExibeAgendamentosFuncionario(FlowLayoutPanel flpAgendaFuncionario)
        {

            flpAgendaFuncionario.Controls.Clear();
            listPanAgendamentos.Clear();
            if (listAgenda != null)
            {
                flpAgendaFuncionario.Visible = false;

                for (int i = 0; i < listAgenda.Count; i++)
                {

                    listPanAgendamentos.Add(ConstrutorAgendamentosFuncionario(listAgenda[i].Data_hora,
                                                                              listAgenda[i].Data_hora.ToString("HH:mm"),
                                                                              listAgenda[i].Nome_cliente,
                                                                              listAgenda[i].Itens,
                                                                              flpAgendaFuncionario.Controls.Count));
                    flpAgendaFuncionario.Controls.Add(listPanAgendamentos[i]);
                }
                flpAgendaFuncionario.Visible = true;
            }
        }

        /// <summary>
        /// Retornar uma string com o dia da semana por extenso
        /// </summary>
        /// <param name="data">data que se deseja saber o dia da semana</param>
        /// <returns></returns>
        public string DiaSemana(DateTime data)
        {
            if (data.DayOfWeek == 0)
                return "DOMINGO";
            else if ((int)data.DayOfWeek == 1)
                return "SEGUNDA";
            else if ((int)data.DayOfWeek == 2)
                return "TERÇA";
            else if ((int)data.DayOfWeek == 3)
                return "QUARTA";
            else if ((int)data.DayOfWeek == 4)
                return "QUINTA";
            else if ((int)data.DayOfWeek == 5)
                return "SEXTA";
            else
                return "SABADO";
        }

        /// <summary>
        /// Exibe os produtos no FlowLayoutPanel passado por parâmetro
        /// </summary>
        /// <param name="flpProdutos">FlowLayoutPanel que conterá os produtos</param>
        /// <param name="grupoProduto">Id do produto como filtro dos produtos a serem exibidos</param>
        public void ExibeProdutos(FlowLayoutPanel flpProdutos, int grupoProduto)
        {
            listProdutos = ProdutoDAO.GetTodosRegistros();

            flpProdutos.Controls.Clear();

            if (listProdutos != null)
                for (int i = 0; i < listProdutos.Count; i++)
                    if (listProdutos[i].Id_grupo_produto == grupoProduto || grupoProduto == 0)
                        flpProdutos.Controls.Add(ConstrutorProdutoOuItem(i, listProdutos[i].Descricao, listProdutos[i].Vl_venda, ProdutoOuItem.produto));
        }

        /// <summary>
        /// Remove os itens selecionados
        /// </summary>
        /// <param name="flpItens">FlowLayoutPanel que contém os itens</param>
        public void RemoveItensSelecionados(FlowLayoutPanel flpItens)
        {
            for (int i = 0; i < listItensSelecionados.Count; i++)
                listItens.Remove(listItensSelecionados[i]);

            listItensSelecionados.Clear();
            listTxtItensSelecionados.Clear();
            flpItens.Controls.Clear();

            for (int i = 0; i < listItens.Count; i++)
                flpItens.Controls.Add(ConstrutorProdutoOuItem(flpItens.Controls.Count, listItens[i].Descricao, listItens[i].Vl_venda, ProdutoOuItem.item));
        }

        Panel ConstrutorItensConclusao(ProdutoVO produto)
        {
            Panel panItem = new Panel();
            panItem.Location = new Point(3, 42);
            panItem.Size = new Size(584, 33);

            TextBox txtDescricao = new TextBox();
            txtDescricao.BackColor = Color.FromArgb(215, 217, 223);
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.ForeColor = Color.Gray;
            txtDescricao.Location = new Point(43, 1);
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(380, 30);
            txtDescricao.TabIndex = 6;
            txtDescricao.Text = produto.Descricao.ToUpper(); ;

            TextBox txtValor = new TextBox();
            txtValor.BackColor = Color.FromArgb(215, 217, 223);
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.ForeColor = Color.Black;
            txtValor.Location = new Point(413, 1);
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(168, 30);
            txtValor.Text = produto.Vl_venda.ToString("C");
            txtValor.TextAlign = HorizontalAlignment.Right;

            panItem.Controls.Add(txtDescricao);
            panItem.Controls.Add(txtValor);

            return panItem;
        }

        public void ExibeItensConlusao(FlowLayoutPanel flpItens, TextBox txtTotal)
        {
            flpItens.Controls.Clear();

            double vl_total = 0;

            for (int i = 0; i < listItens.Count; i++)
            {
                flpItens.Controls.Add(ConstrutorItensConclusao(listItens[i]));
                vl_total += listItens[i].Vl_venda;
            }

            txtTotal.Text = vl_total.ToString("C");
        }

        public void ExibeItens(FlowLayoutPanel flpItens, AgendaVO agendaVO)
        {
            List<ItemAgendaVO> listItemAgenda = ItemAgendaDAO.GetRegistroPorIdAgenda(agendaVO.Id);

            if (listItemAgenda != null)
                foreach (ItemAgendaVO item in listItemAgenda)
                {
                    for (int i = 0; i < item.Quantidade; i++)
                    {
                        ProdutoVO p = new ProdutoVO();
                        p = ProdutoDAO.GetRegistroPorId(item.Id_produto);
                        listItens.Add(p);
                        TextBox txtItem = ConstrutorProdutoOuItem(flpItens.Controls.Count, p.Descricao, p.Vl_venda, ProdutoOuItem.item);
                        flpItens.Controls.Add(txtItem);
                        listTxtItens.Add(txtItem);
                    }
                }
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Este evento adiciona o produto à lista de itens
        /// </summary>
        private void txtProduto_Click(object sender, EventArgs e)
        {
            TextBox txtProduto = (TextBox)sender;
            int posicao_produto = Convert.ToInt32(txtProduto.Name);
            FlowLayoutPanel flpItens = (FlowLayoutPanel)((txtProduto.FindForm().Controls.Find("panItensEServicos", false)[0]).Controls.Find("flpItens", false)[0]);
            TextBox txtItem = ConstrutorProdutoOuItem(flpItens.Controls.Count, listProdutos[posicao_produto].Descricao, listProdutos[posicao_produto].Vl_venda, ProdutoOuItem.item);

            listItens.Add(listProdutos[posicao_produto]);
            flpItens.Controls.Add(txtItem);
            listTxtItens.Add(txtItem);
        }

        /// <summary>
        /// Este evento seleciona o item clicado
        /// </summary>
        private void txtItem_Click(object sender, EventArgs e)
        {
            TextBox txtItem = new TextBox();
            txtItem = (TextBox)sender;
            int posicao_item = Convert.ToInt32(txtItem.Name);

            //se o item já foi selecionado, vai deselecionar-lo
            if (listTxtItensSelecionados.Contains(listTxtItens[posicao_item])) //if (listItensSelecionados.Contains(listItens[posicao_item]))
            {
                listItensSelecionados.Remove(listItens[posicao_item]);
                listTxtItensSelecionados.Remove(listTxtItensSelecionados[posicao_item]);
                txtItem.BackColor = Color.FromArgb(215, 217, 223);
            }
            // senão vai selecioná-lo
            else
            {
                listItensSelecionados.Add(listItens[posicao_item]);
                listTxtItensSelecionados.Add(listTxtItens[posicao_item]);
                txtItem.BackColor = Color.FromArgb(109, 126, 146);
            }
        }

        /// <summary>
        /// Este evento atualiza o texto do txtValorItensServico, conforme o item é selecionado no cbItensServicosCliente
        /// </summary>
        private void cbItensServicosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int id = Convert.ToInt32(cb.Name.Replace("cbItensServicosCliente", ""));
            FlowLayoutPanel flpAgendaFuncionario = (FlowLayoutPanel)((cb.FindForm().Controls.Find("panAgendamento", false)[0]).Controls.Find("flpAgendaFuncionario", false)[0]);
            Panel panAgendamentoFuncionario = (Panel)flpAgendaFuncionario.Controls.Find("panAgendaFuncionario" + id, false)[0];
            TextBox txtValorItensServico = (TextBox)panAgendamentoFuncionario.Controls.Find("txtValorItensServico" + id, false)[0];
            txtValorItensServico.Text = listAgenda[id].Itens[cb.SelectedIndex].Vl_venda.ToString("C");
        }
        #endregion
    }
}

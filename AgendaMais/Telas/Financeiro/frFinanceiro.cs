using AgendaMais.Telas.Relatorios;
using AgendaMais.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaMais.Classes;
using AgendaMais.Classes.BD.VOs;
using AgendaMais.Classes.BD.DAOs;

namespace AgendaMais.Telas.Financeiro
{
    public partial class frFinanceiro : Form
    {
        #region Variáveis
        enum EnumLayout { a_receber, a_pagar };
        static EnumLayout tela_atual;
        #endregion

        #region Métodos Auxiliares
        void LayoutTela(EnumLayout p_enumLayout)
        {
            tela_atual = p_enumLayout;

            if (p_enumLayout == EnumLayout.a_receber)
            {
                ptbContasReceber.Image = Resources.contas_receber;
                ptbContasReceber.Size = new Size(195, 92);

                ptbContasPagar.Image = Resources.contas_pagar_leave;
                ptbContasPagar.Size = new Size(73, 92);

                panCabecalho.BackColor = Color.FromArgb(56, 87, 35);

                panTotal.BackColor = Color.FromArgb(37, 58, 22);
                panPago.BackColor = Color.FromArgb(42, 66, 26);
                lblPanPagoLegenda.Text = "Recebido";
                panPendente.BackColor = Color.FromArgb(58, 90, 26);
                panVencido.BackColor = Color.FromArgb(75, 117, 47);
                panVenceHoje.BackColor = Color.FromArgb(98, 153, 61);
            }
            else if (p_enumLayout == EnumLayout.a_pagar)
            {
                ptbContasReceber.Image = Resources.contas_receber_leave;
                ptbContasReceber.Size = new Size(73, 92);

                ptbContasPagar.Image = Resources.contas_pagar;
                ptbContasPagar.Size = new Size(195, 92);

                panCabecalho.BackColor = Color.FromArgb(158, 0, 0);

                panTotal.BackColor = Color.FromArgb(92, 0, 0);
                panPago.BackColor = Color.FromArgb(142, 0, 0);
                lblPanPagoLegenda.Text = "Pago";
                panPendente.BackColor = Color.FromArgb(176, 0, 0);
                panVencido.BackColor = Color.FromArgb(230, 0, 0);
                panVenceHoje.BackColor = Color.FromArgb(255, 45, 45);
            }
        }

        Panel PanLancto(LanctoContaVO lanctoContaVO)
        {
            // 
            // ptbPago
            // 
            PictureBox ptbPago = new PictureBox();
            if (lanctoContaVO.Pago)
                ptbPago.BackColor = Color.DarkSeaGreen;
            else if (!lanctoContaVO.Pago)
                ptbPago.BackColor = Color.White;
            ptbPago.BackgroundImage = Resources.checked__2_;
            ptbPago.BackgroundImageLayout = ImageLayout.Zoom;
            ptbPago.BorderStyle = BorderStyle.FixedSingle;
            ptbPago.Location = new Point(18, 3);
            ptbPago.Size = new Size(34, 34);
            // 
            // txtDia
            // 
            TextBox txtDia = new TextBox();
            txtDia.BackColor = Color.White;
            txtDia.BorderStyle = BorderStyle.None;
            txtDia.Enabled = false;
            txtDia.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDia.ForeColor = Color.Black;
            txtDia.Location = new Point(87, 9);
            txtDia.ReadOnly = true;
            txtDia.Size = new Size(59, 20);
            txtDia.Text = lanctoContaVO.Data.Day.ToString();
            txtDia.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            TextBox txtDescricao = new TextBox();
            txtDescricao.BackColor = Color.White;
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Enabled = false;
            txtDescricao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Location = new Point(152, 9);
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(348, 20);
            txtDescricao.Text = ContaDAO.GetRegistroPorId(lanctoContaVO.Id_conta).Descricao;
            txtDescricao.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPessoa
            // 
            TextBox txtPessoa = new TextBox();
            txtPessoa.BackColor = Color.White;
            txtPessoa.BorderStyle = BorderStyle.None;
            txtPessoa.Enabled = false;
            txtPessoa.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtPessoa.ForeColor = Color.Black;
            txtPessoa.Location = new Point(506, 9);
            txtPessoa.ReadOnly = true;
            txtPessoa.Size = new Size(348, 20);
            if (!String.IsNullOrEmpty(lanctoContaVO.Id_pessoa))
                txtPessoa.Text = PessoaDAO.GetRegistroPorId(lanctoContaVO.Id_pessoa[0], Convert.ToInt32(lanctoContaVO.Id_pessoa.ToString().Replace("C", "").Replace("F", ""))).Nome;
            else
                txtPessoa.Text = "-";
            txtPessoa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            TextBox txtValor = new TextBox();
            txtValor.BackColor = Color.White;
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Enabled = false;
            txtValor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtValor.ForeColor = Color.Black;
            txtValor.Location = new Point(860, 9);
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(161, 20);
            txtValor.Text = lanctoContaVO.Valor.ToString("C");
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // panLancto
            // 
            Panel panLancto = new Panel();
            panLancto.Anchor = AnchorStyles.Top;
            panLancto.BackColor = Color.White;
            panLancto.Name = lanctoContaVO.Id.ToString(); ;
            panLancto.Size = new Size(1026, 40);
            panLancto.Controls.Add(txtValor);
            panLancto.Controls.Add(txtPessoa);
            panLancto.Controls.Add(ptbPago);
            panLancto.Controls.Add(txtDia);
            panLancto.Controls.Add(txtDescricao);

            return panLancto;
        }

        void CarregarLanctos(DateTime data_ini, DateTime data_fim, ContaVO.EnumTipoConta enumTipoConta)
        {
            List<LanctoContaVO> listLanctoContaVO = LanctoContaDAO.GetRegistroPorPeriodo(data_ini, data_fim, "data");
            flpLanctos.Visible = false;
            flpLanctos.Controls.Clear();
            if (listLanctoContaVO != null)
                foreach (LanctoContaVO lanctoContaVO in listLanctoContaVO)
                    if ((int)tela_atual == (int)ContaDAO.GetRegistroPorId(lanctoContaVO.Id_conta).TipoConta)
                        flpLanctos.Controls.Add(PanLancto(lanctoContaVO));
            flpLanctos.Visible = true;
        }
        #endregion

        public frFinanceiro()
        {

            InitializeComponent();
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            DateTime data_ini = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime data_fim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);
            try
            {
                using (new Carregando("Carregando lançamentos...", Resources.carregando_relatorio))
                {
                    CarregarLanctos(data_ini, data_fim, ContaVO.EnumTipoConta.a_receber);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Parece que ocorreu erro ao carregar os lançamentos.\n\n{erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos
        #region Contas a Receber
        private void ptbContasReceber_Click(object sender, EventArgs e)
        {
            LayoutTela(EnumLayout.a_receber);
            DateTime data_ini = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime data_fim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);
            try
            {
                using (new Carregando("Carregando lançamentos...", Resources.carregando_relatorio))
                {
                    CarregarLanctos(data_ini, data_fim, ContaVO.EnumTipoConta.a_receber);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Parece que ocorreu erro ao carregar os lançamentos.\n\n{erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbContasReceber_MouseEnter(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.a_receber)
                ptbContasReceber.Image = Resources.contas_receber_enter;
        }

        private void ptbContasReceber_MouseLeave(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.a_receber)
                ptbContasReceber.Image = Resources.contas_receber_leave;
        }
        #endregion

        #region Contas a Pagar
        private void ptbContasPagar_Click(object sender, EventArgs e)
        {
            LayoutTela(EnumLayout.a_pagar);
            DateTime data_ini = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            DateTime data_fim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);
            try
            {
                using (new Carregando("Carregando lançamentos...", Resources.carregando_relatorio))
                {
                    CarregarLanctos(data_ini, data_fim, ContaVO.EnumTipoConta.a_receber);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Parece que ocorreu erro ao carregar os lançamentos.\n\n{erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbContasPagar_MouseEnter(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.a_pagar)
                ptbContasPagar.Image = Resources.contas_pagar_enter;
        }

        private void ptbContasPagar_MouseLeave(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.a_pagar)
                ptbContasPagar.Image = Resources.contas_pagar_leave;
        }
        #endregion

        #region ptbMenuInferior
        #region ptbRelatorios
        private void ptbRelatorios_Click(object sender, EventArgs e)
        {
            frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
            frFrequenciaDeAgendamento.Show();
        }

        private void ptbRelatorios_MouseEnter(object sender, EventArgs e)
        {
            ptbRelatorios.Image = Resources.Relatorios;
        }

        private void ptbRelatorios_MouseLeave(object sender, EventArgs e)
        {
            ptbRelatorios.Image = ptbRelatorios.Image = Resources.Relatorios_transparency;
        }
        #endregion

        #region ptbAgendamento
        private void ptbAgendamento_Click(object sender, EventArgs e)
        {
            frAgendamento frAgendamento;
            using (new Carregando("Carregando..."))
                frAgendamento = new frAgendamento();
            frAgendamento.ShowDialog();
        }

        private void ptbAgendamento_MouseEnter(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.agendamento;
        }

        private void ptbAgendamento_MouseLeave(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.agendamento_transparency;
        }
        #endregion

        #region ptbCadCliente
        private void ptbClientes_Click(object sender, EventArgs e)
        {
            frCadCliente frCadCliente = new frCadCliente();
            frCadCliente.ShowDialog();
        }

        private void ptbClientes_MouseEnter(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4_;
        }

        private void ptbClientes_MouseLeave(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4__transparency;
        }
        #endregion

        #endregion

        #endregion


    }
}

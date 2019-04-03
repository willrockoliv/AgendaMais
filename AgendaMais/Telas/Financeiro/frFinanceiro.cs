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

namespace AgendaMais.Telas.Financeiro
{
    public partial class frFinanceiro : Form
    {
        enum EnumLayout { contas_receber, contas_pagar };
        static EnumLayout tela_atual;

        void LayoutTela(EnumLayout p_enumLayout)
        {
            tela_atual = p_enumLayout;

            if (p_enumLayout == EnumLayout.contas_receber)
            {
                ptbContasReceber.Image = Resources.contas_receber;
                ptbContasReceber.Size = new Size(195, 92);

                ptbContasPagar.Image = Resources.contas_pagar_leave;
                ptbContasPagar.Size = new Size(73, 92);

                panCabecalho.BackColor = Color.FromArgb(56, 87, 35);

                panTotal.BackColor = Color.FromArgb(37,58,22);
                panPago.BackColor = Color.FromArgb(42,66,26);
                lblPanPagoLegenda.Text = "Recebido";
                panPendente.BackColor = Color.FromArgb(58,90,26);
                panVencido.BackColor = Color.FromArgb(75,117,47);
                panVenceHoje.BackColor = Color.FromArgb(98,153,61);
            }
            else if(p_enumLayout == EnumLayout.contas_pagar)
            {
                ptbContasReceber.Image = Resources.contas_receber_leave;
                ptbContasReceber.Size = new Size(73, 92);

                ptbContasPagar.Image = Resources.contas_pagar;
                ptbContasPagar.Size = new Size(195, 92);

                panCabecalho.BackColor = Color.FromArgb(158, 0, 0);

                panTotal.BackColor = Color.FromArgb(92,0,0);
                panPago.BackColor = Color.FromArgb(142,0,0);
                lblPanPagoLegenda.Text = "Pago";
                panPendente.BackColor = Color.FromArgb(176,0,0);
                panVencido.BackColor = Color.FromArgb(230,0,0);
                panVenceHoje.BackColor = Color.FromArgb(255,45,45);
            }
        }

        public frFinanceiro()
        {
            InitializeComponent();
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
        }

        #region Eventos
        #region Contas a Receber
        private void ptbContasReceber_Click(object sender, EventArgs e)
        {
            LayoutTela(EnumLayout.contas_receber);
        }

        private void ptbContasReceber_MouseEnter(object sender, EventArgs e)
        {
            if(tela_atual != EnumLayout.contas_receber)
                ptbContasReceber.Image = Resources.contas_receber_enter;
        }

        private void ptbContasReceber_MouseLeave(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.contas_receber)
                ptbContasReceber.Image = Resources.contas_receber_leave;
        }
        #endregion

        #region Contas a Pagar
        private void ptbContasPagar_Click(object sender, EventArgs e)
        {
            LayoutTela(EnumLayout.contas_pagar);
        }

        private void ptbContasPagar_MouseEnter(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.contas_pagar)
                ptbContasPagar.Image = Resources.contas_pagar_enter;
        }

        private void ptbContasPagar_MouseLeave(object sender, EventArgs e)
        {
            if (tela_atual != EnumLayout.contas_pagar)
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

using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Properties;
using AgendaMais.Telas.Relatorios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaMais.Telas
{
    public partial class frDRE : Form
    {
        public double receitaProd;
        public double receitaServ;
        public double receitaTotal;
        public double CustoProd;
        public double custoServ;
        public double custoTotal;
        public double lucroLiquido;

        void ExibeDRE(DateTime dataIni, DateTime dataFim)
        {
            using (new Carregando("Processando dados..."))
            {
                RelatoriosDAO relatoriosDAO = new RelatoriosDAO();
                relatoriosDAO.relatorio_DRE(dataIni, dataFim);


                receitaProd = relatoriosDAO.Dre.receita_produto;
                receitaServ = relatoriosDAO.Dre.receita_servico;
                receitaTotal = relatoriosDAO.Dre.receita_total;
                CustoProd = relatoriosDAO.Dre.custo_produto;
                custoServ = relatoriosDAO.Dre.custo_servico;
                custoTotal = relatoriosDAO.Dre.custo_total;
                lucroLiquido = relatoriosDAO.Dre.receita_total - relatoriosDAO.Dre.custo_total;

                lblReceitaServ.Text = $"SERVIÇOS ...................................... {receitaServ.ToString("C")}";
                lblReceitaProd.Text = $"PRODUTOS .................................... {receitaProd.ToString("C")}";
                lblReceitaTotal.Text = $"TOTAL ............................................. {receitaTotal.ToString("C")}";

                lblCustoServ.Text = $"SERVIÇOS ...................................... {custoServ.ToString("C")}";
                lblCustoProd.Text = $"PRODUTOS .................................... {CustoProd.ToString("C")}";
                lblCustoTotal.Text = $"TOTAL ............................................. {custoTotal.ToString("C")}";

                lblLucroLiquido.Text = $"LUCRO LÍQUIDO ...................................... {lucroLiquido.ToString("C")}";
            }
        }

        public frDRE()
        {
            InitializeComponent();
        }

        private void frDRE_Load(object sender, EventArgs e)
        {
            dtpDataIni.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDataFim.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month),23,59,59);
            ExibeDRE(dtpDataIni.Value, dtpDataFim.Value);
        }

        private void ptbCarregar_MouseHover(object sender, EventArgs e)
        {
            ptbCarregar.BackColor = Color.FromArgb(83, 122, 87);
        }

        private void ptbCarregar_MouseLeave(object sender, EventArgs e)
        {
            ptbCarregar.BackColor = Color.Transparent;
        }

        private void ptbCarregar_Click(object sender, EventArgs e)
        {
            ExibeDRE(dtpDataIni.Value, dtpDataFim.Value);
        }

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
    }
}

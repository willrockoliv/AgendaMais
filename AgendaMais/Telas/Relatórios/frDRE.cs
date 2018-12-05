using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dtpDataFim.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
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
    }
}

using AgendaMais.Classes;
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
                //SqlParameter[] sqlParameters = new SqlParameter[2];
                //sqlParameters[0] = new SqlParameter("@data_ini", SqlDbType.SmallDateTime);
                //sqlParameters[0].Value = dataIni;
                //sqlParameters[1] = new SqlParameter("@data_fim", SqlDbType.SmallDateTime);
                //sqlParameters[1].Value = dataFim;

                //DataTable tbDRE = BD.ExecutaSelect("sp_DRE", sqlParameters);

                //receitaProd = Convert.ToDouble(tbDRE.Rows[0]["receitaProd"]);
                //receitaServ = Convert.ToDouble(tbDRE.Rows[0]["receitaServ"]);
                //receitaTotal = Convert.ToDouble(tbDRE.Rows[0]["receitaTotal"]);
                //CustoProd = Convert.ToDouble(tbDRE.Rows[0]["CustoProd"]);
                //custoServ = Convert.ToDouble(tbDRE.Rows[0]["custoServ"]);
                //custoTotal = Convert.ToDouble(tbDRE.Rows[0]["custoTotal"]);
                //lucroLiquido = Convert.ToDouble(tbDRE.Rows[0]["lucroLiquido"]);

                //lblReceitaServ.Text = $"SERVIÇOS ...................................... {receitaServ.ToString("C")}";
                //lblReceitaProd.Text = $"PRODUTOS .................................... {receitaProd.ToString("C")}";
                //lblReceitaTotal.Text = $"TOTAL ............................................. {receitaTotal.ToString("C")}";

                //lblCustoServ.Text = $"SERVIÇOS ...................................... {custoServ.ToString("C")}";
                //lblCustoProd.Text = $"PRODUTOS .................................... {CustoProd.ToString("C")}";
                //lblCustoTotal.Text = $"TOTAL ............................................. {custoTotal.ToString("C")}";

                //lblLucroLiquido.Text = $"LUCRO LÍQUIDO ...................................... {lucroLiquido.ToString("C")}";
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
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

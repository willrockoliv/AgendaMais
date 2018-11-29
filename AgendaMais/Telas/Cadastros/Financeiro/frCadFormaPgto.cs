using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frCadFormaPgto : Form
    {
        public frCadFormaPgto()
        {
            InitializeComponent();
        }

        private void ckbCartao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCartao.Checked)
                gpbCartao.Enabled = true;
            else
                gpbCartao.Enabled = false;
        }
    }
}

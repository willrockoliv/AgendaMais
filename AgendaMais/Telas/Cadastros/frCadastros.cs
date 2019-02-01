using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMais.Telas.Cadastros
{
    public partial class frCadastros : Form
    {
        public frCadastros()
        {
            InitializeComponent();
        }

        #region Eventos Click
        private void Clientes_Click(object sender, EventArgs e)
        {
            frCadCliente frCadCliente = new frCadCliente();
            frCadCliente.Show();
        }

        private void txtFuncionarios_Click(object sender, EventArgs e)
        {
            frCadFuncionarios frCadFuncionarios = new frCadFuncionarios();
            frCadFuncionarios.Show();
        }

        private void txtProdServ_Click(object sender, EventArgs e)
        {
            frCadProdServ frCadProdServ = new frCadProdServ();
            frCadProdServ.Show();
        }
        #endregion

        #region Eventos Complementares
        private void Menu_MouseHover(object sender, EventArgs e)
        {
            if (sender is Panel)
                ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
            else if (sender is TextBox)
            {
                FlowLayoutPanel flp = (FlowLayoutPanel)(((TextBox)sender).FindForm().Controls.Find("flpMenu", false)[0]);
                Panel pan = (Panel)(flp.Controls.Find(((TextBox)sender).Name.Replace("txt","pan"), false)[0]);
                pan.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel)
                ((Panel)sender).BorderStyle = BorderStyle.None;
            else if (sender is TextBox)
            {
                FlowLayoutPanel flp = (FlowLayoutPanel)(((TextBox)sender).FindForm().Controls.Find("flpMenu", false)[0]);
                Panel pan = (Panel)(flp.Controls.Find(((TextBox)sender).Name.Replace("txt", "pan"), false)[0]);
                pan.BorderStyle = BorderStyle.None;
            }
        }

        #endregion
    }
}

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
    public partial class frPesquisaFuncionarios : Form
    {
        public int codigo = -1;

        public frPesquisaFuncionarios()
        {
            InitializeComponent();

            //Carrega o arquivo funcionarios.txt e lista na ltbFuncionarios
            string[] arquivoFuncionarios = new string[10];
            string[] lista = new string[arquivoFuncionarios.Length];

            for (int i = 0; i < arquivoFuncionarios.Length; i++)
            {
                string[] temp = arquivoFuncionarios[i].Split('|');
                lista[i] = temp[0] + "  >>  " + temp[3];
                ltbFuncionarios.Items.Add(lista[i]);
            }
        }

        /// <summary>
        /// Neste evento a variável int codigo recebe o código do funcionario selecionado da ltbFuncionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            if (ltbFuncionarios.SelectedIndex != -1)
            {
                string[] temp = ltbFuncionarios.SelectedItem.ToString().Replace(">>", "|").Split('|');
                codigo = Convert.ToInt16(temp[0].Trim());
                this.Close();
            }
            else
                return;
        }

        /// <summary>
        /// Fecha a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

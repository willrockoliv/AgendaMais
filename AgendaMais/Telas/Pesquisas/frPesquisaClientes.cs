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

namespace AgendaMais
{
    public partial class frPesquisaClientes : Form
    {
        public DataRow cliente = null;
        DataTable Clientes = new DataTable();

        public frPesquisaClientes()
        {
            InitializeComponent();

            FuncionarioDAO TablePessoa = new FuncionarioDAO();
            Clientes = TablePessoa.DBCommand("SELECT p.nome FROM pessoa p JOIN grupo_pessoa gp ON p.id_grupo_pessoa = gp.id_grupo_pessoa WHERE gp.tipo_grupo = 'C' ORDER BY nome");

            foreach (DataRow cliente in Clientes.Rows)
            {
                ltbClientes.Items.Add(cliente["nome"]);
            }

            #region OLD
            /*
            //Carrega o arquivo clientes.txt e lista na ltbClientes

            CarregaArquivo Arquivo = new CarregaArquivo();
            string[] arquivoClientes = Arquivo.Clientes();
            string[] lista = new string[arquivoClientes.Length];

            for (int i = 0; i < arquivoClientes.Length; i++)
            {
                string[] temp = arquivoClientes[i].Split('|');
                lista[i] = temp[0] + "  >>  " + temp[3];
                ltbClientes.Items.Add(lista[i]);
            }
            */
            #endregion
        }

        /// <summary>
        /// Neste evento a variável int codigo recebe o código do cliente selecionado da ltbClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (ltbClientes.SelectedIndex == -1)
                return;
            else
            {
                cliente = Clientes.Rows[ltbClientes.SelectedIndex];
                this.Close();
            }

            #region OLD
            /*
            if (ltbClientes.SelectedIndex != -1)
            {
                string[] temp = ltbClientes.SelectedItem.ToString().Replace(">>", "|").Split('|');
                codigo = Convert.ToInt16(temp[0].Trim());
                this.Close();
            }
            else
                return;
            */
            #endregion
        }

        /// <summary>
        /// Fecha a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

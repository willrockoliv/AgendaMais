using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using AgendaMais.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frCadCliente : Form
    {
        #region Variáveis
        List<ClienteVO> listClienteVO = new List<ClienteVO>();
        int index = -1;
        //bool alterar = false;
        #endregion

        #region Métodos Auxiliares
        /// <summary>
        /// Exibe dados do cliente selecionado nos seus respecticvos campos
        /// </summary>
        void ExibeCliente(ClienteVO clienteVO)
        {
            txtNome.Text = clienteVO.Nome;
            mkbTelCel.Text = clienteVO.Tel_cel;
            txtEmail.Text = clienteVO.Email;
            mkbCPF.Text = clienteVO.Cpf;
            txtRG.Text = clienteVO.Rg;
            txtEndereco.Text = clienteVO.Endereco;
            txtBairro.Text = clienteVO.Bairro;
            txtNr.Text = clienteVO.Numero;
            txtCidade.Text = clienteVO.Cidade;
            txtComplemento.Text = clienteVO.Complemento;
            ptbImagemCliente.ImageLocation = clienteVO.Imagem_caminho_completo;
        }

        /// <summary>
        /// Limpa todos os campos da tela
        /// </summary>
        void LimpaCampos()
        {
            ptbImagemCliente.ImageLocation = null;
            txtNome.Text = null;
            mkbTelCel.Text = null;
            txtEmail.Text = null;
            mkbCPF.Text = null;
            txtRG.Text = null;
            txtEndereco.Text = null;
            txtBairro.Text = null;
            txtNr.Text = null;
            txtCidade.Text = null;
            txtComplemento.Text = null;

            index = -1;
        }

        /// <summary>
        /// Preenche os atributos de ClienteVO
        /// </summary>
        /// <param name="id">id do cliente desejado</param>
        /// <returns></returns>
        ClienteVO MontaClienteVO(int id)
        {
            ClienteVO c = new ClienteVO();
            if (id == 0)
                c.Id = Convert.ToInt32(ClienteDAO.ExecutaSelect("select id from cliente order by id desc limit 1").Rows[0]["id"]) + 1;
            else
                c.Id = id;
            c.Nome = txtNome.Text.Trim();
            c.Tel_cel = mkbTelCel.Text.Trim();
            c.Email = txtEmail.Text.Trim();
            c.Cpf = mkbCPF.Text.Trim();
            c.Rg = txtRG.Text.Trim();
            c.Endereco = txtEndereco.Text.Trim();
            c.Bairro = txtBairro.Text.Trim();
            c.Numero = txtNr.Text.Trim();
            c.Cidade = txtCidade.Text.Trim();
            c.Complemento = txtComplemento.Text.Trim();
            c.Imagem = ptbImagemCliente.ImageLocation;

            return c;
        }

        bool ValidaCampos()
        {
            errorProvider.Clear();

            bool ok = true;

            if(String.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Ops! Acho que você esqueceu de informar o nome!");
                ok = false;
            }

            if (!Validacoes.ValidaCPF(mkbCPF.Text))
            {
                errorProvider.SetError(mkbCPF, "Desculpe, esse CPF não é válido!");
                ok = Validacoes.ValidaCPF(mkbCPF.Text);
            }

            if (!Validacoes.ValidaEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Desculpe, esse E-mail está num formato válido");
                ok = Validacoes.ValidaEmail(txtEmail.Text);
            }

            if (!Validacoes.ValidaTelCel(mkbTelCel.Text))
            {
                errorProvider.SetError(mkbTelCel, "Desculpe, informe um número de celular válido.\nAssim eu posso enviar um lembrete para ele quando estiver perto da horário agendado.");
                ok = Validacoes.ValidaTelCel(mkbTelCel.Text);
            }

            return ok;
        }
        #endregion

        #region Load e Initialize
        void CarregamentoInicial()
        {
            using (new Carregando())
            {
                // Preenche o AutoComplete para sugerir cliente
                listClienteVO = ClienteDAO.GetTodosRegistros();
                if (listClienteVO != null)
                {
                    AutoCompleteStringCollection listNomes = new AutoCompleteStringCollection();
                    foreach (ClienteVO c in listClienteVO)
                        listNomes.Add(c.Nome);
                    txtNome.AutoCompleteCustomSource = listNomes;
                }
            }
        }

        public frCadCliente()
        {
            InitializeComponent();
            CarregamentoInicial();
        }

        public frCadCliente(ClienteVO clienteVO)
        {
            CarregamentoInicial();
            InitializeComponent();
            ExibeCliente(clienteVO);
        }
        #endregion

        #region Eventos

        #region txtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.ToUpper();
            txtNome.Select(txtNome.Text.Length, 0);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            ClienteVO clienteVO = new ClienteVO();
            if (listClienteVO != null)
                for (int i = 0; i < listClienteVO.Count; i++)
                {
                    clienteVO = listClienteVO[i];
                    if (clienteVO.Nome.ToUpper() == txtNome.Text.ToUpper())
                    {
                        index = i;
                        ExibeCliente(listClienteVO[index]);
                    }
                }
        }
        #endregion

        #region Salvar
        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            //Salvar cadastro novo
            if (index < 0 || index >= listClienteVO.Count)
            {
                try
                {
                    ClienteVO clienteVO = MontaClienteVO(0);
                    ClienteDAO.InserirRegistros(clienteVO);
                    listClienteVO.Add(clienteVO);
                    index = listClienteVO.Count - 1;
                    MessageBox.Show("Cliente salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //Alterar um cadastro
            else
            {
                ClienteVO clienteVO = MontaClienteVO(listClienteVO[index].Id);

                #region string msg
                string msg = String.Format("Verifiquei você alterou dados do cliente: " +
                                                    "\n\nNome: {0}" +
                                                    "\nTel./Cel.: {1}" +
                                                    "\nEmail: {2}" +
                                                    "\nCPF: {3}" +
                                                    "\nRG: {4}" +
                                                    "\nEndereço: {5}" +
                                                    "\nN°: {6}" +
                                                    "\nBairro: {7}" +
                                                    "\nCidade: {8}" +
                                                    "\nComplemtento: {9}" +
                                                    "\n\nDeseja confirmar a atualização do cadastro?",
                                              clienteVO.Nome,
                                              clienteVO.Tel_cel,
                                              clienteVO.Email,
                                              clienteVO.Cpf,
                                              clienteVO.Rg,
                                              clienteVO.Endereco,
                                              clienteVO.Numero,
                                              clienteVO.Bairro,
                                              clienteVO.Cidade,
                                              clienteVO.Complemento);
                #endregion

                if (MessageBox.Show(msg, "Atualizar Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ClienteDAO.AtualizarRegistro(clienteVO);
                        listClienteVO[index] = clienteVO;
                        MessageBox.Show("Cliente atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
        }
        #endregion

        #region Cancelar
        private void lblCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        #endregion

        #region Navegação

        #region Anterior
        private void ptbAnterior_Click(object sender, EventArgs e)
        {
            if (listClienteVO == null)
                return;

            if (index < 0)
                return;
            else if (index == 0)
            {
                index--;
                LimpaCampos();
            }
            else
            {
                index--;
                ExibeCliente(listClienteVO[index]);
            }
        }

        private void ptbAnterior_MouseHover(object sender, EventArgs e)
        {
            ptbAnterior.BackColor = Color.FromArgb(115, 115, 115);
        }

        private void ptbAnterior_MouseLeave(object sender, EventArgs e)
        {
            ptbAnterior.BackColor = Color.Transparent;
        }
        #endregion

        #region Proximo
        private void ptbProximo_Click(object sender, EventArgs e)
        {
            if (listClienteVO == null)
                return;

            if (index >= listClienteVO.Count)
                return;
            else if (index == listClienteVO.Count - 1)
                return;
            else
            {
                index++;
                ExibeCliente(listClienteVO[index]);
            }
        }

        private void ptbProximo_MouseHover(object sender, EventArgs e)
        {
            ptbProximo.BackColor = Color.FromArgb(115, 115, 115);
        }

        private void ptbProximo_MouseLeave(object sender, EventArgs e)
        {
            ptbProximo.BackColor = Color.Transparent;
        }
        #endregion

        #endregion

        #region Imagem
        private void ptbImagemCliente_MouseHover(object sender, EventArgs e)
        {
            if (ptbImagemCliente.ImageLocation == null)
            {
                ptbImagemCliente.BackgroundImage = Resources.perfil_add;
            }
        }

        private void ptbImagemCliente_MouseLeave(object sender, EventArgs e)
        {
            if (ptbImagemCliente.ImageLocation == null)
            {
                ptbImagemCliente.BackgroundImage = Resources.perfil;
            }
        }

        private void ptbImagemCliente_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                ptbImagemCliente.ImageLocation = openFileDialog.FileName;
        }
        #endregion

        #endregion
    }
}

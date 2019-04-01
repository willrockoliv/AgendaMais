using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using AgendaMais.Properties;
using AgendaMais.Telas.Relatorios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frAgendamento : Form
    {
        #region Variáveis Globais
        public bool alteracao = false;
        private AgendaVO agendaVO = new AgendaVO();
        private ClienteVO clienteVO = new ClienteVO();
        private ClienteVO novoCliente = new ClienteVO();
        private List<FuncionarioVO> listFuncionarioVO = FuncionarioDAO.GetTodosRegistrosAtivos();
        private FuncionarioVO funcionarioVOSelecionado = new FuncionarioVO();
        private enum TipoLayoutTela { cliente, agendamento, funcionario, conclusao }
        private MetodosAgendamento metodosAgendamento;
        private List<ClienteVO> listCliente = new List<ClienteVO>();
        #endregion

        #region Métodos Auxiliares

        #region Validações
        /// <summary>
        /// Valida os campos do Panel Clientes
        /// </summary>
        /// <returns>true or false</returns>
        bool ValidaCamposCliente()
        {
            errorProvider.Clear();

            bool ok = true;

            // CPF
            if (!Validacoes.ValidaCPF(mkbCPF.Text))//(mkbCPF.Text.Trim() != ".   .   -" && Validacoes.ValidaCPF(mkbCPF.Text) == false)
            {
                errorProvider.SetError(mkbCPF, "Desculpe, este CPF é inválido");
                ok = false;
            }

            // Telefone ou Celular
            if (Validacoes.ValidaTelCel(mkbTelCel.Text) == false)
            {
                errorProvider.SetError(mkbTelCel, "Não se esqueça do telefone, assim poderemos avisá-los para você");
                ok = false;
            }

            // Nome
            if (String.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                errorProvider.SetError(txtNome, "Qual o nome do seu cliente?");
                ok = false;
            }

            // Email
            if (Validacoes.ValidaEmail(txtEmail.Text) == false)
            {
                errorProvider.SetError(txtEmail, "Desculpe, Acredito que este emeil esteja incorreto!");
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Valida os campos do Panel Agendamento
        /// </summary>
        /// <returns>true or false</returns>
        bool ValidaCamposAgendamento()
        {
            bool ok = true;

            // Horário
            if (Validacoes.ValidaHorario(mkbHorario.Text) == false)
            {
                errorProvider.SetError(mkbHorario, "Ops! Este horário não é válido!");
                ok = false;
            }

            if (Convert.ToDateTime(dtpData.Value.Date.ToString("dd/MM/yyyy")) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")))
                if (MessageBox.Show("Esta data é menor que a data atual \n Deseja continuar mesmo assim?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    ok = false;

            if (metodosAgendamento.listAgenda != null)
                foreach (AgendaVO agendaVO in metodosAgendamento.listAgenda)
                {
                    if (agendaVO.Data_hora == Convert.ToDateTime(dtpData.Text + " " + mkbHorario.Text))
                        if (MessageBox.Show("O funcionário escolhido já possui um agendamento neste horário! \n\nDeseja continuar mesmo assim?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            ok = false;
                }

            return ok;
        }

        bool ValidaCamposItensEServicos()
        {
            if (flpItens.Controls.Count < 1)
            {
                errorProvider.SetError(flpItens, "Acho que você esqueceu de selecionar o serviço/produto. \nPor favor, selecione pelo um item.");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Verifica pelo nome informado se o cliente é novo ou já existe no cadastro de clientes
        /// </summary>
        /// <param name="nome">nome do cliente</param>
        /// <returns>
        /// retorna 0 se o cliente é novo
        /// ou 
        /// retorna 1 se o cliente já existente
        /// </returns>
        int VerificaClienteNovo(string nome)
        {
            int retorno = 0;

            if (listCliente != null)
                foreach (ClienteVO c in listCliente)
                {
                    if (txtNome.Text == c.Nome)
                    {
                        retorno = 1;
                        break;
                    }
                }

            return retorno;
        }

        /// <summary>
        /// Verifica se há alteração no cadastro do cliente
        /// </summary>
        /// <param name="id">id do cliente infomado</param>
        /// <returns>
        /// retorna 0 caso não haja alteração
        /// ou
        /// retorna 1 caso haja alteração
        /// </returns>
        int VerificaAlteracaoCliente(int id)
        {
            int retorno = 0;
            ClienteVO clienteVO = ClienteDAO.GetRegistroPorId(id);

            if (clienteVO.Tel_cel != mkbTelCel.Text.Trim())
                retorno = 1;
            if (clienteVO.Email != txtEmail.Text.Trim())
                retorno = 1;
            if (clienteVO.Cpf.Replace(".", "").Replace("-", "").Trim() != mkbCPF.Text.Replace(".", "").Replace("-", "").Trim())
                retorno = 1;
            if (clienteVO.Rg.Replace(".", "").Replace("-", "").Trim() != txtRG.Text.Replace(".", "").Replace("-", "").Trim())
                retorno = 1;
            if (clienteVO.Endereco != txtEndereco.Text.Trim())
                retorno = 1;
            if (clienteVO.Bairro != txtBairro.Text.Trim())
                retorno = 1;
            if (clienteVO.Numero != txtNr.Text.Trim())
                retorno = 1;
            if (clienteVO.Cidade != txtCidade.Text.Trim())
                retorno = 1;
            if (clienteVO.Complemento != txtComplemento.Text.Trim())
                retorno = 1;

            return retorno;
        }

        /// <summary>
        /// Este método retorna o proximo id ou o id do cliente caso já exista
        /// </summary>
        /// <param name="nome">nome do cliente</param>
        int ClienteId(string nome)
        {
            int retorno = ClienteDAO.ProximoID();

            if (listCliente != null)
                foreach (ClienteVO c in listCliente)
                {
                    if (txtNome.Text == c.Nome)
                    {
                        retorno = c.Id;
                        break;
                    }
                }

            return retorno;
        }
        #endregion

        /// <summary>
        /// Define qual Panel estará em visível
        /// </summary>
        /// <param name="p_TipoLayoutTela"></param>
        void LayoutTela(TipoLayoutTela p_TipoLayoutTela)
        {
            panCliente.Visible = TipoLayoutTela.cliente == p_TipoLayoutTela;
            panAgendamento.Visible = TipoLayoutTela.agendamento == p_TipoLayoutTela;
            panItensEServicos.Visible = TipoLayoutTela.funcionario == p_TipoLayoutTela;
            panConclusao.Visible = TipoLayoutTela.conclusao == p_TipoLayoutTela;
        }

        /// <summary>
        /// Exibe os dados do agendamento passado por parâmetro nos campos de cada Panel
        /// </summary>
        /// <param name="agendaVO"></param>
        void ExibeDados(AgendaVO agendaVO)
        {
            clienteVO = ClienteDAO.GetRegistroPorId(agendaVO.Id_cliente);
            if (clienteVO != null)
            {
                ptbImagemCliente.ImageLocation = clienteVO.Imagem_caminho_completo;
                txtNome.Text = agendaVO.Nome_cliente;
                mkbTelCel.Text = agendaVO.Tel_cel;
                txtEmail.Text = clienteVO.Email.ToString();
                mkbCPF.Text = clienteVO.Cpf.ToString();
                txtRG.Text = clienteVO.Rg.ToString();
                txtEndereco.Text = clienteVO.Endereco.ToString();
                txtNr.Text = clienteVO.Numero.ToString();
                txtBairro.Text = clienteVO.Bairro.ToString();
                txtCidade.Text = clienteVO.Cidade.ToString();
                txtComplemento.Text = clienteVO.Complemento.ToString();
                dtpData.Text = agendaVO.Data_hora.ToString("dd/MM/yyyy");
                mkbHorario.Text = agendaVO.Data_hora.ToString("HH:mm");
            }

            for (int i = 0; i < listFuncionarioVO.Count; i++)
            {
                if (listFuncionarioVO[i].Id == agendaVO.Id_funcionario)
                {
                    funcionarioVOSelecionado = listFuncionarioVO[i];
                    SelecionaFuncionario((Panel)(flpFuncionarios.Controls[i]));
                }
            }

            metodosAgendamento.ExibeItens(flpItens, agendaVO);

            ExibeConclusao();
        }

        /// <summary>
        /// Exibe os funcionários no flpFuncionarios
        /// </summary>
        void ExibeFuncionarios()
        {
            if (listFuncionarioVO != null)
                for (int i = 0; i < listFuncionarioVO.Count; i++)
                    flpFuncionarios.Controls.Add(ConstrutorFuncionario(listFuncionarioVO[i].Imagem_caminho_completo, listFuncionarioVO[i].Nome));
        }

        /// <summary>
        /// Construtor do Panel com a foto e o nome do funcionário
        /// </summary>
        /// <param name="caminho_imagem"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        Panel ConstrutorFuncionario(string caminho_imagem, string nome)
        {
            Panel panFuncionario = new Panel();
            panFuncionario.Name = nome;
            panFuncionario.BackColor = Color.FromArgb(69, 102, 136);
            panFuncionario.Size = new Size(100, 100);
            panFuncionario.Cursor = Cursors.Hand;
            panFuncionario.Click += new EventHandler(Funcionario_Click);

            PictureBox ptbImagem = new PictureBox();
            ptbImagem.Name = nome;
            ptbImagem.Location = new Point(15, 3);
            ptbImagem.Size = new Size(70, 70);
            ptbImagem.ImageLocation = caminho_imagem;
            ptbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagem.Click += new EventHandler(Funcionario_Click);

            TextBox txtNome = new TextBox();
            txtNome.Name = nome;
            txtNome.BackColor = Color.FromArgb(69, 102, 136);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.Hand;
            txtNome.Location = new Point(3, 76);
            txtNome.Size = new Size(94, 13);
            txtNome.Text = nome.ToUpper();
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.ForeColor = Color.White;
            txtNome.ReadOnly = true;
            txtNome.Click += new EventHandler(Funcionario_Click);

            panFuncionario.Controls.Add(ptbImagem);
            panFuncionario.Controls.Add(txtNome);

            return panFuncionario;
        }

        /// <summary>
        /// Destaca o funcionários delecionado no flpFuncioonários
        /// </summary>
        /// <param name="panFuncionarioSelecionado">Panel a ser destacado</param>
        void SelecionaFuncionario(Panel panFuncionarioSelecionado)
        {
            panFuncionarioSelecionado.BackColor = Color.White;
            panFuncionarioSelecionado.Controls[1].BackColor = Color.White;
            panFuncionarioSelecionado.Controls[1].ForeColor = Color.Black;

            for (int i = 0; i < listFuncionarioVO.Count; i++)
            {
                if (panFuncionarioSelecionado.Name != flpFuncionarios.Controls[i].Name)
                {
                    flpFuncionarios.Controls[i].BackColor = Color.FromArgb(69, 102, 136);
                    ((Panel)(flpFuncionarios.Controls[i])).Controls[1].BackColor = Color.FromArgb(69, 102, 136);
                    ((Panel)(flpFuncionarios.Controls[i])).Controls[1].ForeColor = Color.White;
                }
                else
                {
                    funcionarioVOSelecionado = listFuncionarioVO[i];
                    ExibeAgendaFuncionarioSelecionado(funcionarioVOSelecionado.Id);
                }
            }
        }

        /// <summary>
        /// Exeibe a agenda do funcionário selecionado no flpAgendaFuncionario
        /// </summary>
        /// <param name="id_funcionario">id do funcionário selecionado</param>
        void ExibeAgendaFuncionarioSelecionado(int id_funcionario)
        {
            using (new Carregando())
            {
                //MetodosAgendamento m = new MetodosAgendamento();
                //m.Atualiza_listAgendaPorFuncionario(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                //                                    Convert.ToDateTime(DateTime.Now.AddDays(6).ToString("dd/MM/yyyy") + " 23:59:59"),
                //                                    'P', 'P', 'P',
                //                                    id_funcionario);
                //m.ExibeAgendamentosFuncionario(flpAgendaFuncionario);

                metodosAgendamento.Atualiza_listAgendaPorFuncionario(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                                                                     Convert.ToDateTime(DateTime.Now.AddDays(6).ToString("dd/MM/yyyy") + " 23:59:59"),
                                                                     'P', 'P', 'P',
                                                                     id_funcionario);
                metodosAgendamento.ExibeAgendamentosFuncionario(flpAgendaFuncionario);
            }
        }

        /// <summary>
        /// Exibe um resumo das informações do agendamento
        /// </summary>
        void ExibeConclusao()
        {
            txtClienteConclusao.Text = txtNome.Text.ToUpper().Trim();
            mbkTelCelConclusao.Text = mkbTelCel.Text;

            txtDataHorarioConclusao.Text = metodosAgendamento.DiaSemana(dtpData.Value).ToUpper().Substring(0, 3) + " " +
                                               dtpData.Value.ToString("dd/MM/yyyy") + " " +
                                               mkbHorario.Text;
            if (String.IsNullOrEmpty(funcionarioVOSelecionado.Nome))
                txtFuncionarioConclusao.Text = "Não informado";
            else
                txtFuncionarioConclusao.Text = funcionarioVOSelecionado.Nome.ToUpper();

            txtDataHorarioConclusao.Text = metodosAgendamento.DiaSemana(dtpData.Value).ToUpper().Substring(0, 3) + " " +
                                                   dtpData.Value.ToString("dd/MM/yyyy") + " " +
                                                   mkbHorario.Text;

            metodosAgendamento.ExibeItensConlusao(flpItensConclusao, txtTotalConclusao);
        }
        #endregion

        #region Load e Initilize
        private void CarregamentoInicial()
        {
            metodosAgendamento = new MetodosAgendamento();

            //Agendamento
            flpFuncionarios.Controls.Clear();
            ExibeFuncionarios();

            //Itens e serviços
            List<GrupoProdutoVO> listGrupoProduto = GrupoProdutoDAO.GetTodosRegistrosAtivos();
            if (listGrupoProduto != null)
            {
                for (int i = 0; i < listGrupoProduto.Count; i++)
                    cbGrupoProduto.Items.Add(listGrupoProduto[i].Descricao);
                cbGrupoProduto.SelectedIndex = 0;
            }
            panQtdItens.Visible = false;
            metodosAgendamento.ExibeProdutos(flpProdutos, 0);
            flpItens.Controls.Clear();

            // Preenche o AutoComplete para sugerir cliente
            listCliente = ClienteDAO.GetTodosRegistrosAtivos();
            if (listCliente != null)
            {
                AutoCompleteStringCollection listNomes = new AutoCompleteStringCollection();
                foreach (ClienteVO c in listCliente)
                    listNomes.Add(c.Nome);
                txtNome.AutoCompleteCustomSource = listNomes;
            }
        }

        public frAgendamento()
        {
            InitializeComponent();
            LayoutTela(TipoLayoutTela.cliente);
            alteracao = false;
            CarregamentoInicial();
        }

        public frAgendamento(AgendaVO p_agendaVO)
        {
            InitializeComponent();
            alteracao = true;
            agendaVO = p_agendaVO;
            LayoutTela(TipoLayoutTela.cliente);
            CarregamentoInicial();
            ExibeDados(p_agendaVO);
        }
        #endregion

        #region Eventos

        #region Cliente
        #region Menu
        private void panClienteMenu_Click(object sender, EventArgs e)
        {
            LayoutTela(TipoLayoutTela.cliente);
        }

        private void panClienteMenu_MouseHover(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.PowderBlue;
        }

        private void panClienteMenu_MouseLeave(object sender, EventArgs e)
        {
            lblCliente.ForeColor = Color.White;
        }
        #endregion

        #region Componentes
        #region txtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.ToUpper();
            txtNome.Select(txtNome.Text.Length, 0);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (listCliente != null)
                foreach (ClienteVO c in listCliente)
                    if (c.Nome.ToUpper() == txtNome.Text.ToUpper())
                    {
                        ptbImagemCliente.ImageLocation = c.Imagem_caminho_completo;
                        mkbTelCel.Text = c.Tel_cel;
                        txtEmail.Text = c.Email;
                        mkbCPF.Text = c.Cpf;
                        txtRG.Text = c.Rg;
                        txtEndereco.Text = c.Endereco;
                        txtBairro.Text = c.Bairro;
                        txtNr.Text = c.Numero;
                        txtCidade.Text = c.Cidade;
                        txtComplemento.Text = c.Complemento;
                    }
        }
        #endregion

        #region mkbTelCel
        /// <summary>
        /// Chama o próximo Panel quando a tecla Enter é pressionada no campo mkbTelCel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mkbTelCel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panProximoCliente_Click(panProximoCliente, e);
                dtpData.Focus();
            }
        }
        #endregion
        #endregion

        #region Botão Próximo
        private void panProximoCliente_Click(object sender, EventArgs e)
        {
            if (ValidaCamposCliente())
                LayoutTela(TipoLayoutTela.agendamento);
        }

        private void panProximoCliente_MouseHover(object sender, EventArgs e)
        {
            panProximoCliente.BackgroundImage = Properties.Resources.panProximo_escuro;
        }

        private void panProximoCliente_MouseLeave(object sender, EventArgs e)
        {
            panProximoCliente.BackgroundImage = Properties.Resources.panProximo_claro;
        }
        #endregion
        #endregion

        #region Agendamento
        #region Menu
        private void panAgendamentoMenu_Click(object sender, EventArgs e)
        {
            if (ValidaCamposCliente())
                LayoutTela(TipoLayoutTela.agendamento);
        }

        private void panAgendamentoMenu_MouseHover(object sender, EventArgs e)
        {
            lblAgendamento.ForeColor = Color.PowderBlue;
        }

        private void panAgendamentoMenu_MouseLeave(object sender, EventArgs e)
        {
            lblAgendamento.ForeColor = Color.White;
        }
        #endregion

        #region  Componentes
        /// <summary>
        /// Evento click disparado pelo Panel que contem a imagem e o nome do funcionário
        /// </summary>
        private void Funcionario_Click(object sender, EventArgs e)
        {
            Panel panFuncionario;
            if (sender is Panel)
            {
                panFuncionario = (Panel)sender;
                SelecionaFuncionario(panFuncionario);
            }
            else if (sender is PictureBox)
            {
                PictureBox ptbImagemFuncionario = (PictureBox)sender;
                FlowLayoutPanel flp = (FlowLayoutPanel)(ptbImagemFuncionario.FindForm().Controls.Find("panAgendamento", false)[0]).Controls.Find("flpFuncionarios", false)[0];
                panFuncionario = (Panel)flp.Controls.Find(ptbImagemFuncionario.Name, false)[0];
                SelecionaFuncionario(panFuncionario);
            }
            else if (sender is TextBox)
            {
                TextBox txtNomeFuncionario = (TextBox)sender;
                FlowLayoutPanel flp = (FlowLayoutPanel)(txtNomeFuncionario.FindForm().Controls.Find("panAgendamento", false)[0]).Controls.Find("flpFuncionarios", false)[0];
                panFuncionario = (Panel)flp.Controls.Find(txtNomeFuncionario.Name, false)[0];
                SelecionaFuncionario(panFuncionario);
            }
        }
        #endregion

        #region Botão Próximo
        private void panProximoAgendamento_Click(object sender, EventArgs e)
        {
            if (ValidaCamposAgendamento())
            {


                LayoutTela(TipoLayoutTela.funcionario);
            }

        }

        private void panProximoAgendamento_MouseHover(object sender, EventArgs e)
        {
            panProximoAgendamento.BackgroundImage = Properties.Resources.panProximo_escuro;
        }

        private void panProximoAgendamento_MouseLeave(object sender, EventArgs e)
        {
            panProximoAgendamento.BackgroundImage = Properties.Resources.panProximo_claro;
        }
        #endregion

        /// <summary>
        ///  Chama o próximo Panel quando a tecla Enter é pressionada no campo mkbHorario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mkbHorario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panProximoAgendamento_Click(panProximoAgendamento, e);
                cbGrupoProduto.Focus();
            }
        }
        #endregion

        #region Itens e Serviços
        #region Menu
        private void panItensEServicosMenu_Click(object sender, EventArgs e)
        {
            if (ValidaCamposCliente())
                if (ValidaCamposAgendamento())
                    LayoutTela(TipoLayoutTela.funcionario);
        }

        private void panItensEServicosMenu_MouseHover(object sender, EventArgs e)
        {
            lblFuncionarioMenu.ForeColor = Color.PowderBlue;
        }

        private void panItensEServicosMenu_MouseLeave(object sender, EventArgs e)
        {
            lblFuncionarioMenu.ForeColor = Color.White;
        }
        #endregion

        #region Componentes
        private void cbGrupoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodosAgendamento.ExibeProdutos(flpProdutos, cbGrupoProduto.SelectedIndex);
        }

        private void flpItens_ControlAdded(object sender, ControlEventArgs e)
        {
            panQtdItens.Visible = true;
            panRemoveItem.Visible = true;
            txtQtdItens.Text = flpItens.Controls.Count.ToString();
        }

        private void flpItens_ControlRemoved(object sender, ControlEventArgs e)
        {
            int qtdItens = flpItens.Controls.Count;
            if (qtdItens == 0)
            {
                panQtdItens.Visible = false;
                panRemoveItem.Visible = false;
            }
            txtQtdItens.Text = qtdItens.ToString();
        }

        private void panRemoveItem_Click(object sender, EventArgs e)
        {
            metodosAgendamento.RemoveItensSelecionados(flpItens);
        }
        #endregion

        #region Botão Próximo
        private void panProximoItensEServicos_Click(object sender, EventArgs e)
        {
            if (ValidaCamposCliente())
                if (ValidaCamposAgendamento())
                    if (ValidaCamposItensEServicos())
                    {
                        ExibeConclusao();
                        LayoutTela(TipoLayoutTela.conclusao);
                    }
        }

        private void panProximoItensEServicos_MouseHover(object sender, EventArgs e)
        {
            panProximoItensEServicos.BackgroundImage = Properties.Resources.panProximo_escuro;
        }

        private void panProximoItensEServicos_MouseLeave(object sender, EventArgs e)
        {
            panProximoItensEServicos.BackgroundImage = Properties.Resources.panProximo_claro;
        }
        #endregion

        /// <summary>
        ///  Chama o próximo Panel quando a tecla Enter é pressionada no Panel panItensEServicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void panItensEServicos_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        panProximoItensEServicos_Click(panProximoItensEServicos, e);
        //    }
        //}
        #endregion

        #region Conclusão

        #region Menu
        private void panConclusaoMenu_Click(object sender, EventArgs e)
        {
            if (ValidaCamposCliente())
                if (ValidaCamposAgendamento())
                    if (ValidaCamposItensEServicos())
                    {
                        ExibeConclusao();
                        LayoutTela(TipoLayoutTela.conclusao);
                    }
        }

        private void panConclusaoMenu_MouseHover(object sender, EventArgs e)
        {
            lblConclusaoMenu.ForeColor = Color.PowderBlue;
        }

        private void panConclusaoMenu_MouseLeave(object sender, EventArgs e)
        {
            lblConclusaoMenu.ForeColor = Color.White;
        }
        #endregion

        #region Botão Concluir
        private void panConcluir_Click(object sender, EventArgs e)
        {
            #region Monta ClienteVO
            ClienteVO clienteVO = new ClienteVO();
            clienteVO.Id = ClienteId(txtNome.Text.Trim());
            clienteVO.Nome = txtNome.Text.Trim();
            clienteVO.Tel_cel = mkbTelCel.Text.Trim();
            clienteVO.Email = txtEmail.Text.Trim();
            clienteVO.Cpf = mkbCPF.Text.Trim();
            clienteVO.Rg = txtRG.Text.Trim();
            clienteVO.Endereco = txtEndereco.Text.Trim();
            clienteVO.Bairro = txtBairro.Text.Trim();
            clienteVO.Numero = txtNr.Text.Trim();
            clienteVO.Cidade = txtCidade.Text.Trim();
            clienteVO.Complemento = txtComplemento.Text.Trim();
            clienteVO.Imagem = ptbImagemCliente.ImageLocation;
            #endregion

            if (MessageBox.Show("Confirma o agendamento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (new Carregando("Salvando Agendamento!"))
                {
                    // 0 == Cliente Novo
                    if (VerificaClienteNovo(clienteVO.Nome) == 0)
                    {
                        try
                        {
                            ClienteDAO.InserirRegistros(clienteVO);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // 1 == Alteração de cadastro de cliente já existente
                    else
                    {
                        if (VerificaAlteracaoCliente(clienteVO.Id) == 1)
                        {
                            #region Mensagem
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

                    #region Monta AgendaVO
                    agendaVO.Id_cliente = clienteVO.Id;
                    if (funcionarioVOSelecionado.Id != 0)
                        agendaVO.Id_funcionario = funcionarioVOSelecionado.Id;
                    agendaVO.Data_hora = Convert.ToDateTime(dtpData.Text + " " + mkbHorario.Text);
                    agendaVO.Obs = "";
                    if (ckbConfirmado.Checked)
                        agendaVO.Status = 'C';
                    else
                        agendaVO.Status = 'P';
                    agendaVO.Itens = metodosAgendamento.listItens;
                    #endregion

                    if (alteracao)
                        AgendaDAO.AtualizarRegistro(agendaVO);
                    else
                    {
                        agendaVO.Id = AgendaDAO.ProximoId();
                        AgendaDAO.InserirRegistros(agendaVO);
                    }
                }
                MessageBox.Show("Agendamento Salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void panConcluir_MouseHover(object sender, EventArgs e)
        {
            panConcluir.BackgroundImage = Properties.Resources.panAgendamento_escuro;
        }

        private void panConcluir_MouseLeave(object sender, EventArgs e)
        {
            panConcluir.BackgroundImage = Properties.Resources.panAgendamento_claro;
        }
        #endregion

        #endregion

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
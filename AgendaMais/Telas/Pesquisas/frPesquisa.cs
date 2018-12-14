using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.Enums;
using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frPesquisa : Form
    {
        #region Variáveis
        EnumPesquisa enumPesquisa;
        List<ClienteVO> listClienteVO = new List<ClienteVO>();
        List<FuncionarioVO> listFuncionarioVO = new List<FuncionarioVO>();
        List<ProdutoVO> listProdutoVO = new List<ProdutoVO>();
        List<GrupoProdutoVO> listGrupoProdutoVO = new List<GrupoProdutoVO>();
        public int index = -1;
        public ClienteVO clienteVO;
        public FuncionarioVO funcionarioVO;
        public ProdutoVO produtoVO;
        public GrupoProdutoVO grupoProdutoVO;
        #endregion

        #region Métodos Auxiliares
        TextBox Construtor(string nome)
        {
            TextBox txtNome = new TextBox();
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.Hand;
            txtNome.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(6, 5);
            txtNome.Name = flpAgendamentos.Controls.Count.ToString();
            txtNome.Text = nome;
            txtNome.Size = new Size(681, 26);
            txtNome.Click += new EventHandler(Click_Cadastro);
            txtNome.ReadOnly = true;
            txtNome.TabStop = false;

            return txtNome;
        }

        void ExibeCadastros()
        {
            flpAgendamentos.Controls.Clear();
            if (enumPesquisa == EnumPesquisa.cliente)
            {
                if (listClienteVO != null)
                    foreach (ClienteVO clienteVO in listClienteVO)
                        flpAgendamentos.Controls.Add(Construtor(clienteVO.Nome));
            }
            else if (enumPesquisa == EnumPesquisa.funcionario)
            {
                if (listFuncionarioVO != null)
                    foreach (FuncionarioVO funcionarioVO in listFuncionarioVO)
                        flpAgendamentos.Controls.Add(Construtor(funcionarioVO.Nome));
            }
            else if (enumPesquisa == EnumPesquisa.produto)
            {
                if (listProdutoVO != null)
                    foreach (ProdutoVO produtoVO in listProdutoVO)
                        flpAgendamentos.Controls.Add(Construtor(produtoVO.Descricao));
            }
            else
            {
                if (listGrupoProdutoVO != null)
                    foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProdutoVO)
                        flpAgendamentos.Controls.Add(Construtor(grupoProdutoVO.Descricao));
            }
        }

        void CadastroSelecionado()
        {
            if (enumPesquisa == EnumPesquisa.cliente)
            {
                clienteVO = listClienteVO[index];
            }
            else if (enumPesquisa == EnumPesquisa.funcionario)
            {
                funcionarioVO = listFuncionarioVO[index];
            }
            else if (enumPesquisa == EnumPesquisa.produto)
            {
                produtoVO = listProdutoVO[index];
            }
            else
            {
                grupoProdutoVO = listGrupoProdutoVO[index];
            }
        }

        void CarregaGrupos()
        {
            listGrupoProdutoVO = GrupoProdutoDAO.GetTodosRegistros();
            if (listGrupoProdutoVO != null)
            {
                cbGrupo.Items.Clear();
                cbGrupo.Items.Add("Todos");
                foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProdutoVO)
                    cbGrupo.Items.Add(grupoProdutoVO.Descricao);
            }
        }

        void CarregaProdutosPorGrupo(int id_grupo_produto)
        {
            try
            {
                using (new Carregando())
                {
                    listProdutoVO = ProdutoDAO.GetRegistrosPorGrupo(id_grupo_produto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ExibeCadastros();
        }

        void CarregaCadastros()
        {
            try
            {
                using (new Carregando())
                {
                    if (enumPesquisa == EnumPesquisa.cliente)
                    {
                        listClienteVO = ClienteDAO.GetTodosRegistros();
                    }
                    else if (enumPesquisa == EnumPesquisa.funcionario)
                    {
                        listFuncionarioVO = FuncionarioDAO.GetTodosRegistros();
                    }
                    else if (enumPesquisa == EnumPesquisa.produto)
                    {
                        listProdutoVO = ProdutoDAO.GetTodosRegistros();
                        CarregaGrupos();
                        lblGrupo.Visible = true;
                        cbGrupo.Visible = true;
                    }
                    else
                    {
                        listGrupoProdutoVO = GrupoProdutoDAO.GetTodosRegistros();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ExibeCadastros();
        }
        #endregion

        #region Load e Initialize
        public frPesquisa(EnumPesquisa p_enumPesquisa)
        {
            InitializeComponent();
            enumPesquisa = p_enumPesquisa;
            CarregaCadastros();
            ExibeCadastros();
        }
        #endregion

        #region Eventos
        private void Abrir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panCancelar_Click(object sender, EventArgs e)
        {
            clienteVO = null;
            funcionarioVO = null;
            produtoVO = null;
            grupoProdutoVO = null;
            Close();
        }

        private void Click_Cadastro(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (clienteVO == null &&
                funcionarioVO == null &&
                produtoVO == null &&
                grupoProdutoVO == null)
            {
                index = Convert.ToInt32(txt.Name);
                CadastroSelecionado();
                txt.BackColor = Color.Gainsboro;
                return;
            }


            if (index == Convert.ToInt32(txt.Name))
            {
                clienteVO = null;
                funcionarioVO = null;
                produtoVO = null;
                grupoProdutoVO = null;
                txt.BackColor = Color.White;
            }
            else
            {
                clienteVO = null;
                funcionarioVO = null;
                produtoVO = null;
                grupoProdutoVO = null;
                TextBox txt_anterior = (TextBox)flpAgendamentos.Controls[index];
                txt_anterior.BackColor = Color.White;

                index = Convert.ToInt32(txt.Name);
                CadastroSelecionado();
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupo.SelectedIndex == 0)
                CarregaCadastros();

            else
                CarregaProdutosPorGrupo(cbGrupo.SelectedIndex);
        }

        private void ptbExcluiCadastro_Click(object sender, EventArgs e)
        {
            if (enumPesquisa == EnumPesquisa.cliente)
            {
                if (clienteVO != null)
                {
                    if (MessageBox.Show("ATENÇÃO: Excluindo o cadastro de um cliente você exluirá junto todo histórico de agendamento do mesmo!" +
                                        $"\n\nTem certeza que deseja exlcuir o cadastro do cliente {clienteVO.Nome} ?", "Excluir Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ClienteDAO.DeletarRegistro(clienteVO.Id);
                            MessageBox.Show("Cliente excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (enumPesquisa == EnumPesquisa.funcionario)
            {
                if (funcionarioVO != null)
                {
                    if (MessageBox.Show("ATENÇÃO: Excluindo o cadastro de um funcionário você exluirá junto todo histórico de agendamento do mesmo!" +
                                        $"\n\nTem certeza que deseja exlcuir o cadastro do funcionário {funcionarioVO.Nome} ?", "Excluir Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            FuncionarioDAO.DeletarRegistro(funcionarioVO.Id);
                            MessageBox.Show("Funcionário excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (enumPesquisa == EnumPesquisa.produto)
            {
                if (produtoVO != null)
                {
                    if (MessageBox.Show("ATENÇÃO: Excluir um produto ou serviço exluirá toda movimentação vinculada à ele!" +
                                       $"\n\nTem certeza que deseja exlcuir o cadastro do produto {produtoVO.Descricao} ?", "Excluir Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ProdutoDAO.DeletarRegistro(produtoVO.Id);
                            MessageBox.Show("Produto excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (grupoProdutoVO != null)
                {
                    if (MessageBox.Show("ATENÇÃO: Excluir um Grupo excluirá o cadastro de todos os produtos/serviços vinculados à ele e,\n" +
                                        "consequentemente, todo histórico de vendas desses produtos também!" +
                                       $"\n\nTem certeza que deseja exlcuir o cadastro do Grupo {grupoProdutoVO.Descricao} ?",
                                       "Excluir Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            GrupoProdutoDAO.DeletarRegistro(grupoProdutoVO.Id);
                            MessageBox.Show("Grupo de Produtos excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion
    }
}

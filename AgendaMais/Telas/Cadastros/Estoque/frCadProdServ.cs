using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.Enums;
using AgendaMais.Classes.VOs;
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
    public partial class frCadProdServ : Form
    {
        #region Variáveis
        List<ProdutoVO> listProdutoVO = new List<ProdutoVO>();
        ProdutoVO produtoVOSelecionado;
        List<GrupoProdutoVO> listGrupoProduto = new List<GrupoProdutoVO>();
        GrupoProdutoVO grupoProdutoVOSelecionado = new GrupoProdutoVO();
        #endregion

        #region Métodos Auxiliares
        void ExibeProduto(ProdutoVO produtoVO)
        {
            produtoVOSelecionado = produtoVO;

            txtCodBarras.Text = produtoVO.Cod_barras;
            txtDescricao.Text = produtoVO.Descricao;
            foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                if (grupoProdutoVO.Id == produtoVO.Id_grupo_produto)
                {
                    cbGrupo.SelectedItem = grupoProdutoVO.Descricao;
                    grupoProdutoVOSelecionado = grupoProdutoVO;
                    break;
                }
            rdbProduto.Checked = produtoVO.Controla_estoque;
            rdbServico.Checked = !produtoVO.Controla_estoque;
            txtQtde.Enabled = produtoVO.Controla_estoque;
            txtQtde.Text = produtoVO.Qtd_estoque.ToString();
            txtPrecoCusto.Text = produtoVO.Vl_custo.ToString("C");
            txtPrecoVenda.Text = produtoVO.Vl_venda.ToString("C");
        }

        void LimpaCampos()
        {
            produtoVOSelecionado = null;
            grupoProdutoVOSelecionado = null;

            txtCodBarras.Text = null;
            txtDescricao.Text = null;
            cbGrupo.SelectedIndex = -1;
            txtQtde.Text = null;
            rdbServico.Checked = true;
            txtPrecoCusto.Text = null;
            txtPrecoVenda.Text = null;
        }

        bool ValidaCampos()
        {
            errorProvider.Clear();
            bool ok = true;

            if (String.IsNullOrEmpty(txtDescricao.Text.Trim()))
            {
                errorProvider.SetError(txtDescricao, "Ops! Não se esqueça de informar a decrição");
                ok = false;
            }

            if (cbGrupo.SelectedIndex == -1)
            {
                errorProvider.SetError(cbGrupo, "Ops, Não se esqueça de informar o Grupo");
                ok = false;
            }

            if (rdbProduto.Checked)
                if (txtQtde.Text.Trim() == "")
                    txtQtde.Text = 0.ToString();
                else if (Int32.TryParse(txtQtde.Text.Trim(), out int qtd))
                    txtQtde.Text = qtd.ToString();
                else
                {
                    ok = false;
                    errorProvider.SetError(txtQtde, "A quantidade que você informou é inválida");
                }

            if (Double.TryParse(txtPrecoVenda.Text.Replace("R$", "").Trim(), out double vl_venda))
                txtPrecoVenda.Text = vl_venda.ToString("C");
            else
                txtPrecoVenda.Text = null;

            if (Double.TryParse(txtPrecoCusto.Text.Replace("R$", "").Trim(), out double vl_custo))
                txtPrecoCusto.Text = vl_custo.ToString("C");
            else
                txtPrecoCusto.Text = null;

            if (string.IsNullOrEmpty(txtPrecoVenda.Text.Trim()))
            {
                errorProvider.SetError(txtPrecoVenda, "Qual é o valor do Serviço/Produto?");
                ok = false;
            }

            return ok;
        }

        void CarregaProdutos()
        {
            listProdutoVO = ProdutoDAO.GetTodosRegistros();
            if (listProdutoVO != null)
            {
                AutoCompleteStringCollection listProdutos = new AutoCompleteStringCollection();
                foreach (ProdutoVO produtoVO in listProdutoVO)
                    listProdutos.Add(produtoVO.Descricao);
                txtDescricao.AutoCompleteCustomSource.Clear();
                txtDescricao.AutoCompleteCustomSource = listProdutos;
            }
        }

        void CarregaGrupos()
        {
            listGrupoProduto = GrupoProdutoDAO.GetTodosRegistros();
            if (listGrupoProduto != null)
            {
                cbGrupo.Items.Clear();
                foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                    cbGrupo.Items.Add(grupoProdutoVO.Descricao);
            }
        }
        #endregion

        #region Load e initialize
        public frCadProdServ()
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaGrupos();
        }
        #endregion

        #region Eventos

        #region RadioButton Tipo de produto
        private void rdbServico_CheckedChanged(object sender, EventArgs e)
        {
            txtQtde.Enabled = false;
            txtQtde.Text = null;
        }

        private void rdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            txtQtde.Enabled = true;
        }
        #endregion

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodBarras.Text.Trim()))
                return;

            foreach (ProdutoVO produtoVO in listProdutoVO)
            {
                if (produtoVO.Cod_barras.Trim() == txtCodBarras.Text.Trim())
                {
                    ExibeProduto(produtoVO);
                    break;
                }
            }
        }

        #region txtdescricao
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = txtDescricao.Text.ToUpper();
            txtDescricao.Select(txtDescricao.Text.Length, 0);
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (listProdutoVO == null)
                return;

            foreach (ProdutoVO produtoVO in listProdutoVO)
            {
                if (produtoVO.Descricao.Trim() == txtDescricao.Text.Trim())
                {
                    ExibeProduto(produtoVO);
                    break;
                }
            }
        }
        #endregion

        private void panCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            ProdutoVO produtoVO = new ProdutoVO();
            produtoVO.Cod_barras = txtCodBarras.Text.Trim();
            produtoVO.Descricao = txtDescricao.Text.Trim();
            produtoVO.Id_grupo_produto = grupoProdutoVOSelecionado.Id;
            produtoVO.Controla_estoque = rdbProduto.Checked;
            if (produtoVO.Controla_estoque)
                produtoVO.Qtd_estoque = Convert.ToInt32(txtQtde.Text);
            produtoVO.Vl_custo = Convert.ToDouble(txtPrecoCusto.Text.Replace("R$", "").Trim());
            produtoVO.Vl_venda = Convert.ToDouble(txtPrecoVenda.Text.Replace("R$", "").Trim());

            //Produto novo
            if (produtoVOSelecionado == null)
            {
                try
                {
                    ProdutoDAO.InserirRegistros(produtoVO);
                    CarregaProdutos();
                    MessageBox.Show("Produto cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Atualização de cadastro já existente
            else
            {
                produtoVO.Id = produtoVOSelecionado.Id;

                try
                {
                    ProdutoDAO.AtualizarRegistro(produtoVO);
                    CarregaProdutos();
                    MessageBox.Show("Produto atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGrupo.SelectedIndex == -1)
                return;

            foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                if (grupoProdutoVO.Descricao == cbGrupo.SelectedItem.ToString())
                    grupoProdutoVOSelecionado = grupoProdutoVO;
        }

        #region Cadastro de Grupo de Produto
        private void panSalvarGrupo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricaoGrupo.Text))
                return;

            if (listGrupoProduto != null)
                foreach (GrupoProdutoVO gpVO in listGrupoProduto)
                    if (txtDescricaoGrupo.Text.Trim() == gpVO.Descricao)
                    {
                        errorProvider.SetError(txtDescricaoGrupo, "Esse grupo já foi cadastrado");
                        return;
                    }

            GrupoProdutoVO grupoProdutoVO = new GrupoProdutoVO();
            grupoProdutoVO.Descricao = txtDescricaoGrupo.Text.Trim();

            try
            {
                GrupoProdutoDAO.InserirRegistros(grupoProdutoVO);
                CarregaGrupos();
                MessageBox.Show("Grupo de Produto cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panCadGrupo.Visible = false;
                txtDescricaoGrupo.Text = null;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panCancelarGrupo_Click(object sender, EventArgs e)
        {
            panCadGrupo.Visible = false;
            txtDescricaoGrupo.Text = null;
        }

        private void txtDescricaoGrupo_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoGrupo.Text = txtDescricaoGrupo.Text.ToUpper();
            txtDescricaoGrupo.Select(txtDescricaoGrupo.Text.Length, 0);
        }

        private void ptbAddGrupo_Click(object sender, EventArgs e)
        {
            panCadGrupo.Visible = !panCadGrupo.Visible;
        }

        private void ptbPesquisaGrupo_Click(object sender, EventArgs e)
        {
            frPesquisa frPesquisa = new frPesquisa(EnumPesquisa.grupo_produto);
            frPesquisa.ShowDialog();
            if (frPesquisa.grupoProdutoVO != null)
                txtDescricaoGrupo.Text = frPesquisa.grupoProdutoVO.Descricao;
        }
        #endregion

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtPrecoCusto.Text.Replace("R$", "").Trim(), out double vl_custo))
                txtPrecoCusto.Text = vl_custo.ToString("C");
            else
                txtPrecoCusto.Text = null;
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtPrecoVenda.Text.Replace("R$", "").Trim(), out double vl_venda))
                txtPrecoVenda.Text = vl_venda.ToString("C");
            else
                txtPrecoVenda.Text = null;
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtQtde.Text.Trim(), out int qtd))
                txtQtde.Text = qtd.ToString();
            else
                txtQtde.Text = null;
        }

        private void ptbPesquisa_Click(object sender, EventArgs e)
        {
            frPesquisa frPesquisa = new frPesquisa(EnumPesquisa.produto);
            frPesquisa.ShowDialog();
            if (frPesquisa.produtoVO != null)
                for (int i = 0; i < listProdutoVO.Count; i++)
                    if (frPesquisa.produtoVO.Descricao == listProdutoVO[i].Descricao)
                    {
                        ExibeProduto(listProdutoVO[i]);
                        break;
                    }
        }


        #endregion

        /* old
        List<ProdutoVO> listProdutoVO = new List<ProdutoVO>();
        ProdutoVO produtoVOSelecionado;
        List<GrupoProdutoVO> listGrupoProduto = new List<GrupoProdutoVO>();
        GrupoProdutoVO grupoProdutoVOSelecionado = new GrupoProdutoVO();

        void ExibeProduto(ProdutoVO produtoVO)
        {
            produtoVOSelecionado = produtoVO;

            txtCodBarras.Text = produtoVO.Cod_barras;
            txtDescricao.Text = produtoVO.Descricao;
            foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                if (grupoProdutoVO.Id == produtoVO.Id_grupo_produto)
                {
                    cbGrupo.SelectedItem = grupoProdutoVO.Descricao;
                    grupoProdutoVOSelecionado = grupoProdutoVO;
                    break;
                }
            txtQtde.Text = produtoVO.Qtd_estoque.ToString();
            rdbProduto.Checked = produtoVO.Controla_estoque;
            rdbServico.Checked = !produtoVO.Controla_estoque;
            txtPrecoCusto.Text = produtoVO.Vl_custo.ToString("C");
            txtPrecoVenda.Text = produtoVO.Vl_venda.ToString("C");
        }

        void LimpaCampos()
        {
            produtoVOSelecionado = null;
            grupoProdutoVOSelecionado = null;

            txtCodBarras.Text = null;
            txtDescricao.Text = null;
            cbGrupo.SelectedIndex = -1;
            txtQtde.Text = null;
            rdbServico.Checked = true;
            txtPrecoCusto.Text = null;
            txtPrecoVenda.Text = null;
        }

        bool ValidaCampos()
        {
            errorProvider.Clear();
            bool ok = true;

            if(String.IsNullOrEmpty(txtDescricao.Text.Trim()))
            {
                errorProvider.SetError(txtDescricao, "Ops! Não se esqueça de informar a decrição");
                ok = false;
            }

            if(cbGrupo.SelectedIndex == -1)
            {
                errorProvider.SetError(cbGrupo, "Ops, Não se esqueça de informar o Grupo");
                ok = false;
            }

            if(string.IsNullOrEmpty(txtPrecoVenda.Text.Trim()))
            {
                errorProvider.SetError(txtPrecoVenda, "Qual é o valor do Serviço/Produto?");
                ok = false;
            }

            return ok;
        }

        public frCadProdServ()
        {
            InitializeComponent();

            listProdutoVO = ProdutoDAO.GetTodosRegistros();
            if (listProdutoVO != null)
            {
                AutoCompleteStringCollection listDescricoes = new AutoCompleteStringCollection();
                foreach (ProdutoVO produtoVO in listProdutoVO)
                    listDescricoes.Add(produtoVO.Descricao);
                txtDescricao.AutoCompleteCustomSource = listDescricoes;
            }

            if (listGrupoProduto != null)
            {
                listGrupoProduto = GrupoProdutoDAO.GetTodosRegistros();
                foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                    cbGrupo.Items.Add(grupoProdutoVO.Descricao);
            }
        }

        private void rdbServico_CheckedChanged(object sender, EventArgs e)
        {
            txtQtde.Enabled = false;
            txtQtde.Text = null;
        }

        private void rdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            txtQtde.Enabled = true;
        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodBarras.Text.Trim()))
                return;

            foreach (ProdutoVO produtoVO in listProdutoVO)
            {
                if (produtoVO.Cod_barras.Trim() == txtCodBarras.Text.Trim())
                {
                    ExibeProduto(produtoVO);
                    break;
                }
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = txtDescricao.Text.ToUpper();
            txtDescricao.Select(txtDescricao.Text.Length, 0);
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (listProdutoVO == null)
                return;

            foreach (ProdutoVO produtoVO in listProdutoVO)
            {
                if (produtoVO.Descricao.Trim() == txtDescricao.Text.Trim())
                {
                    ExibeProduto(produtoVO);
                    break;
                }
            }
        }

        private void panCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            ProdutoVO produtoVO = new ProdutoVO();
            produtoVO.Cod_barras = txtCodBarras.Text.Trim();
            produtoVO.Descricao = txtDescricao.Text.Trim();
            produtoVO.Id_grupo_produto = grupoProdutoVOSelecionado.Id;
            produtoVO.Qtd_estoque = Convert.ToInt32(txtQtde.Text);
            produtoVO.Controla_estoque = rdbProduto.Checked;
            produtoVO.Vl_custo = Convert.ToDouble(txtPrecoCusto.Text.Replace("R$", "").Trim());
            produtoVO.Vl_venda = Convert.ToDouble(txtPrecoVenda.Text.Replace("R$", "").Trim());

            //Produto novo
            if (produtoVOSelecionado == null)
            {
                try
                {
                    ProdutoDAO.InserirRegistros(produtoVO);
                    MessageBox.Show("Produto cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Atualização de cadastro já existente
            else
            {
                produtoVO.Id = produtoVOSelecionado.Id;

                try
                {
                    ProdutoDAO.AtualizarRegistro(produtoVO);
                    MessageBox.Show("Produto atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GrupoProdutoVO grupoProdutoVO in listGrupoProduto)
                if (grupoProdutoVO.Descricao == cbGrupo.SelectedItem.ToString())
                    grupoProdutoVOSelecionado = grupoProdutoVO;
        }
        */
    }
}

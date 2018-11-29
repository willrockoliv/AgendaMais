using AgendaMais.Classes.DAOs;
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
    }
}

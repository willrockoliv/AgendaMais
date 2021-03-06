﻿using AgendaMais.Classes;
using AgendaMais.Classes.Enums;
using AgendaMais.Classes.VOs;
using AgendaMais.Properties;
using AgendaMais.Telas.Relatorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frCadFuncionarios : Form
    {
        #region Variáveis
        List<FuncionarioVO> listFuncionarioVO = new List<FuncionarioVO>();
        int index = -1;
        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Exibe dados do funcionario selecionado nos seus respecticvos campos
        /// </summary>
        void ExibeFuncionario(FuncionarioVO funcionarioVO)
        {
            txtNome.Text = funcionarioVO.Nome;
            mkbTelCel.Text = funcionarioVO.Tel_cel;
            txtEmail.Text = funcionarioVO.Email;
            mkbCPF.Text = funcionarioVO.Cpf;
            txtRG.Text = funcionarioVO.Rg;
            txtEndereco.Text = funcionarioVO.Endereco;
            txtBairro.Text = funcionarioVO.Bairro;
            txtNr.Text = funcionarioVO.Numero;
            txtCidade.Text = funcionarioVO.Cidade;
            txtComplemento.Text = funcionarioVO.Complemento;
            ptbImagemFuncionario.ImageLocation = funcionarioVO.Imagem_caminho_completo;
        }

        /// <summary>
        /// Limpa todos os campos da tela
        /// </summary>
        void LimpaCampos()
        {
            ptbImagemFuncionario.ImageLocation = null;
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
        /// Preenche os atributos de FuncionarioVO
        /// </summary>
        /// <param name="id">id do funcionario desejado</param>
        /// <returns></returns>
        FuncionarioVO MontaFuncionarioVO(int id)
        {
            FuncionarioVO c = new FuncionarioVO();
            if (id == 0)
                c.Id = FuncionarioDAO.ProximoID();
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
            c.Imagem = ptbImagemFuncionario.ImageLocation;

            return c;
        }

        bool ValidaCampos()
        {
            errorProvider.Clear();

            bool ok = true;

            if (String.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Ops! Acho que você esqueceu de informar o nome!");
                ok = false;
            }

            if (listFuncionarioVO != null)
                foreach (FuncionarioVO funcionarioVO in listFuncionarioVO)
                    if (funcionarioVO.Nome == txtNome.Text.Trim())
                    {
                        errorProvider.SetError(txtNome, "Ops! Já existe um funcionário cadastrado com este nome.");
                        ok = false;
                    }

            if (!Validacoes.ValidaCPF(mkbCPF.Text))
            {
                errorProvider.SetError(mkbCPF, "Desculpe, esse CPF é inválido!");
                ok = Validacoes.ValidaCPF(mkbCPF.Text);
            }

            if (!Validacoes.ValidaEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Desculpe, esse E-mail está num formato inválido");
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
        void CarregaCadastros()
        {
            using (new Carregando())
            {
                // Preenche o AutoComplete para sugerir funcionario
                listFuncionarioVO = FuncionarioDAO.GetTodosRegistrosAtivos();
                if (listFuncionarioVO != null)
                {
                    AutoCompleteStringCollection listNomes = new AutoCompleteStringCollection();
                    foreach (FuncionarioVO c in listFuncionarioVO)
                        listNomes.Add(c.Nome);
                    txtNome.AutoCompleteCustomSource = listNomes;
                }
            }
        }

        public frCadFuncionarios()
        {
            InitializeComponent();
            CarregaCadastros();
            if (listFuncionarioVO != null)
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
        }

        public frCadFuncionarios(FuncionarioVO funcionarioVO)
        {
            CarregaCadastros();
            InitializeComponent();
            ExibeFuncionario(funcionarioVO);
            for (int i = 0; i < listFuncionarioVO.Count; i++)
                if (funcionarioVO.Nome == listFuncionarioVO[i].Nome)
                {
                    index = i;
                    lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                }
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
            FuncionarioVO funcionarioVO = new FuncionarioVO();
            if (listFuncionarioVO != null)
                for (int i = 0; i < listFuncionarioVO.Count; i++)
                {
                    funcionarioVO = listFuncionarioVO[i];
                    if (funcionarioVO.Nome.ToUpper() == txtNome.Text.ToUpper())
                    {
                        index = i;
                        ExibeFuncionario(listFuncionarioVO[index]);
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
            if (index < 0 || index >= listFuncionarioVO.Count)
            {
                try
                {
                    FuncionarioVO funcionarioVO = MontaFuncionarioVO(0);
                    FuncionarioDAO.InserirRegistros(funcionarioVO);
                    if (listFuncionarioVO == null)
                        listFuncionarioVO = new List<FuncionarioVO>();
                    listFuncionarioVO.Add(funcionarioVO);
                    index = listFuncionarioVO.Count - 1;
                    lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                    MessageBox.Show("Funcionario salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                FuncionarioVO funcionarioVO = MontaFuncionarioVO(listFuncionarioVO[index].Id);

                #region string msg
                string msg = String.Format("Verifiquei você alterou dados do funcionario: " +
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
                                              funcionarioVO.Nome,
                                              funcionarioVO.Tel_cel,
                                              funcionarioVO.Email,
                                              funcionarioVO.Cpf,
                                              funcionarioVO.Rg,
                                              funcionarioVO.Endereco,
                                              funcionarioVO.Numero,
                                              funcionarioVO.Bairro,
                                              funcionarioVO.Cidade,
                                              funcionarioVO.Complemento);
                #endregion

                if (MessageBox.Show(msg, "Atualizar Cadastro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        FuncionarioDAO.AtualizarRegistro(funcionarioVO);
                        listFuncionarioVO[index] = funcionarioVO;
                        MessageBox.Show("Funcionario atualizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }

            LimpaCampos();
        }
        #endregion

        #region Cancelar
        private void lblCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Navegação

        #region Primeiro
        private void ptbPrimeiro_MouseHover(object sender, EventArgs e)
        {
            ptbPrimeiro.Image = Resources.primeiro_hover;
        }

        private void ptbPrimeiro_MouseLeave(object sender, EventArgs e)
        {
            ptbPrimeiro.Image = Resources.primeiro;
        }

        private void ptbPrimeiro_Click(object sender, EventArgs e)
        {
            if (listFuncionarioVO == null)
                return;

            if (index < 0)
                return;
            else
            {
                index = -1;
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                LimpaCampos();
            }
        }
        #endregion

        #region Anterior
        private void ptbAnterior_Click(object sender, EventArgs e)
        {
            if (listFuncionarioVO == null)
                return;

            if (index < 0)
                return;
            else if (index == 0)
            {
                index--;
                LimpaCampos();
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
            }
            else
            {
                index--;
                ExibeFuncionario(listFuncionarioVO[index]);
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
            }
        }

        private void ptbAnterior_MouseHover(object sender, EventArgs e)
        {
            ptbAnterior.Image = Resources.anterior_hover;
        }

        private void ptbAnterior_MouseLeave(object sender, EventArgs e)
        {
            ptbAnterior.Image = Resources.anterior1;
        }
        #endregion

        #region Proximo
        private void ptbProximo_Click(object sender, EventArgs e)
        {
            if (listFuncionarioVO == null)
                return;

            if (index >= listFuncionarioVO.Count)
                return;
            else if (index == listFuncionarioVO.Count - 1)
                return;
            else
            {
                index++;
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                ExibeFuncionario(listFuncionarioVO[index]);
            }
        }

        private void ptbProximo_MouseHover(object sender, EventArgs e)
        {
            ptbProximo.Image = Resources.proximo_hover;
        }

        private void ptbProximo_MouseLeave(object sender, EventArgs e)
        {
            ptbProximo.Image = Resources.proximo1;
        }
        #endregion

        #region Ultimo
        private void ptbUltimo_MouseHover(object sender, EventArgs e)
        {
            ptbUltimo.Image = Resources.ultimo_hover;
        }

        private void ptbUltimo_MouseLeave(object sender, EventArgs e)
        {
            ptbUltimo.Image = Resources.ultimo;
        }

        private void ptbUltimo_Click(object sender, EventArgs e)
        {
            if (listFuncionarioVO == null)
                return;

            if (index >= listFuncionarioVO.Count)
                return;
            else if (index == listFuncionarioVO.Count - 1)
                return;
            else
            {
                index = listFuncionarioVO.Count - 1;
                lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                ExibeFuncionario(listFuncionarioVO[index]);
            }
        }
        #endregion

        #endregion

        #region Imagem
        private void ptbImagemFuncionario_MouseHover(object sender, EventArgs e)
        {
            if (ptbImagemFuncionario.ImageLocation == null)
            {
                ptbImagemFuncionario.BackgroundImage = Resources.perfil_add;
            }
        }

        private void ptbImagemFuncionario_MouseLeave(object sender, EventArgs e)
        {
            if (ptbImagemFuncionario.ImageLocation == null)
            {
                ptbImagemFuncionario.BackgroundImage = Resources.perfil;
            }
        }

        private void ptbImagemFuncionario_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                ptbImagemFuncionario.ImageLocation = openFileDialog.FileName;
        }
        #endregion

        private void ptbPesquisa_Click(object sender, EventArgs e)
        {
            frPesquisa frPesquisa = new frPesquisa(EnumPesquisa.funcionario);
            frPesquisa.ShowDialog();
            CarregaCadastros();
            if (frPesquisa.funcionarioVO != null)
                for (int i = 0; i < listFuncionarioVO.Count; i++)
                    if (frPesquisa.funcionarioVO.Nome == listFuncionarioVO[i].Nome)
                    {
                        index = i;
                        lblQtdFuncionarios.Text = $"{index + 1} de {listFuncionarioVO.Count}";
                        ExibeFuncionario(listFuncionarioVO[i]);
                        break;
                    }
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
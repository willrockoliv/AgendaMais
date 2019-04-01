using AgendaMais.Classes;
using AgendaMais.Classes.BD.DAOs;
using AgendaMais.Properties;
using AgendaMais.Telas;
using AgendaMais.Telas.Configurações;
using AgendaMais.Telas.Relatorios;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frPrincipal : Form
    {
        #region Variáveis Globais
        public static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        MetodosAgenda metodosAgenda = new MetodosAgenda();
        enum EnumMenu { cadastros, relatorios, configuracoes, notificacao, nenhum };
        #endregion

        #region Métodos
        void LayoutMenu(EnumMenu enumMenu)
        {
            if (enumMenu == EnumMenu.cadastros)
            {
                panMenuCadastros.Visible = !panMenuCadastros.Visible;
                panMenuRelatorios.Visible = false;
                panMenuConfiguracoes.Visible = false;
                flpMenuNotificacao.Visible = false;
            }
            else if (enumMenu == EnumMenu.configuracoes)
            {
                panMenuCadastros.Visible = false;
                panMenuRelatorios.Visible = false;
                panMenuConfiguracoes.Visible = !panMenuConfiguracoes.Visible;
                flpMenuNotificacao.Visible = false;
            }
            else if (enumMenu == EnumMenu.relatorios)
            {
                panMenuCadastros.Visible = false;
                panMenuRelatorios.Visible = !panMenuRelatorios.Visible;
                panMenuConfiguracoes.Visible = false;
                flpMenuNotificacao.Visible = false;
            }
            else if (enumMenu == EnumMenu.nenhum)
            {
                panMenuCadastros.Visible = false;
                panMenuRelatorios.Visible = false;
                panMenuConfiguracoes.Visible = false;
                flpMenuNotificacao.Visible = false;
            }
            else if(enumMenu == EnumMenu.notificacao)
            {
                panMenuCadastros.Visible = false;
                panMenuRelatorios.Visible = false;
                panMenuConfiguracoes.Visible = false;
                flpMenuNotificacao.Visible = !flpMenuNotificacao.Visible;
            }
        }
        #endregion

        #region Load e Initialize
        public frPrincipal()
        {
            using (new Carregando("Quase lá..."))
            {
                InitializeComponent();
            }

            try
            {
                using (new Carregando("Estou preparando\ntudo para você!"))
                {
                    metodosAgenda.Atualiza_listAgenda(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                                                      Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59"),
                                                      'P', 'P', 'P');
                    flpAgendamentos.Controls.Clear();
                    if (metodosAgenda.listAgenda != null)
                    {
                        metodosAgenda.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
                        metodosAgenda.AtualizaStatus(flpAgendamentos);
                    }

                    NotificacoesDAO.CarregarNotificacoes(flpMenuNotificacao, panNotificacao);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timer1.Start();
        }
        #endregion

        #region Eventos

        #region Menu

        #region Notificacao

        private void panNotificacao_Click(object sender, EventArgs e)
        {
            LayoutMenu(EnumMenu.notificacao);
            panNotificacao.BackgroundImage = Resources.notificacao1;
        }

        private void panNotificacao_MouseEnter(object sender, EventArgs e)
        {
            panNotificacao.BackColor = Color.FromArgb(170, 16, 41, 99);
        }

        private void panNotificacao_MouseLeave(object sender, EventArgs e)
        {
            panNotificacao.BackColor = Color.FromArgb(0, 16, 41, 99);
        }

        #endregion

        #region panAgenda
        private void panAgenda_MouseEnter(object sender, EventArgs e)
        {
            panAgenda.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblAgenda.ForeColor = Color.PowderBlue;
        }

        private void panAgenda_MouseLeave(object sender, EventArgs e)
        {
            panAgenda.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblAgenda.ForeColor = Color.White;
        }

        private void panAgenda_Click(object sender, EventArgs e)
        {
            frAgendados frAgendados = new frAgendados();
            frAgendados.Show();
            LayoutMenu(EnumMenu.nenhum);
        }
        #endregion

        #region panCadastros
        private void Cadastros_Click(object sender, EventArgs e)
        {
            LayoutMenu(EnumMenu.cadastros);
        }

        private void panCadastros_MouseEnter(object sender, EventArgs e)
        {
            panCadastros.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblCadastros.ForeColor = Color.PowderBlue;
        }

        private void panCadastros_MouseLeave(object sender, EventArgs e)
        {
            panCadastros.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblCadastros.ForeColor = Color.White;

        }

        #region Clientes
        private void panCadClientes_Click(object sender, EventArgs e)
        {
            frCadCliente frCadCliente = new frCadCliente();
            panMenuCadastros.Visible = !panMenuCadastros.Visible;
            frCadCliente.Show();
        }

        private void panCadClientes_MouseEnter(object sender, EventArgs e)
        {
            panCadClientes.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblCadClientes.ForeColor = Color.PowderBlue;
        }

        private void panCadClientes_MouseLeave(object sender, EventArgs e)
        {
            panCadClientes.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblCadClientes.ForeColor = Color.White;
        }
        #endregion

        #region Funcionarios
        private void panCadFuncionarios_Click(object sender, EventArgs e)
        {
            frCadFuncionarios frCadFuncionarios = new frCadFuncionarios();
            panMenuCadastros.Visible = !panMenuCadastros.Visible;
            frCadFuncionarios.Show();
        }

        private void panCadFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            panCadFuncionarios.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblCadFuncionarios.ForeColor = Color.PowderBlue;
        }

        private void panCadFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            panCadFuncionarios.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblCadFuncionarios.ForeColor = Color.White;
        }
        #endregion

        #region Produtos e Serviços
        private void panCadProdServ_Click(object sender, EventArgs e)
        {
            frCadProdServ frCadProdServ = new frCadProdServ();
            panMenuCadastros.Visible = !panMenuCadastros.Visible;
            frCadProdServ.Show();
        }

        private void panCadProdServ_MouseEnter(object sender, EventArgs e)
        {
            panCadProdServ.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblCadProdServ.ForeColor = Color.PowderBlue;
        }

        private void panCadProdServ_MouseLeave(object sender, EventArgs e)
        {
            panCadProdServ.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblCadProdServ.ForeColor = Color.White;
        }
        #endregion
        #endregion

        #region panRelatorios
        private void panRelatorios_Click(object sender, EventArgs e)
        {
            LayoutMenu(EnumMenu.relatorios);
        }

        private void panRelatorios_MouseEnter(object sender, EventArgs e)
        {
            panRelatorios.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblRelatorios.ForeColor = Color.PowderBlue;
        }

        private void panRelatorios_MouseLeave(object sender, EventArgs e)
        {
            panRelatorios.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblRelatorios.ForeColor = Color.White;
        }

        #region panFreqAgendamento
        private void panFreqAgendamento_Click(object sender, EventArgs e)
        {
            frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
            panMenuRelatorios.Visible = !panMenuRelatorios.Visible;
            frFrequenciaDeAgendamento.Show();
        }

        private void panFreqAgendamento_MouseEnter(object sender, EventArgs e)
        {
            panFreqAgendamento.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblFreqAgendamento.ForeColor = Color.PowderBlue;
        }

        private void panFreqAgendamento_MouseLeave(object sender, EventArgs e)
        {
            panFreqAgendamento.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblFreqAgendamento.ForeColor = Color.White;
        }
        #endregion

        #region panDRE
        private void panDRE_Click(object sender, EventArgs e)
        {
            frDRE frDRE = new frDRE();
            panMenuRelatorios.Visible = !panMenuRelatorios.Visible;
            frDRE.Show();
        }

        private void panDRE_MouseEnter(object sender, EventArgs e)
        {
            panDRE.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblDRE.ForeColor = Color.PowderBlue;
        }

        private void panDRE_MouseLeave(object sender, EventArgs e)
        {
            panDRE.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblDRE.ForeColor = Color.White;
        }
        #endregion

        #endregion

        #region panConfiguracoes
        private void panConfiguracoes_MouseEnter(object sender, EventArgs e)
        {
            panConfiguracoes.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblConfiguracoes.ForeColor = Color.PowderBlue;
        }

        private void panConfiguracoes_MouseLeave(object sender, EventArgs e)
        {
            panConfiguracoes.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblConfiguracoes.ForeColor = Color.White;
        }

        private void lblConfiguracoes_Click(object sender, EventArgs e)
        {
            LayoutMenu(EnumMenu.configuracoes);
        }

        #region Alterar Senha
        private void panAlterarSenha_Click(object sender, EventArgs e)
        {
            frAlterarSenha frAlterarSenha = new frAlterarSenha();
            frAlterarSenha.Show();
        }

        private void panAlterarSenha_MouseEnter(object sender, EventArgs e)
        {
            panAlterarSenha.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblAlterarSenha.ForeColor = Color.PowderBlue;
        }

        private void panAlterarSenha_MouseLeave(object sender, EventArgs e)
        {
            panAlterarSenha.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblAlterarSenha.ForeColor = Color.White;
        }
        #endregion

        #endregion

        #endregion

        #region Eventos Botões Principais

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
        public void ptbAgendamento_Click(object sender, EventArgs e)
        {
            frAgendamento frAgendamento;
            using (new Carregando("Carregando..."))
                frAgendamento = new frAgendamento();
            frAgendamento.ShowDialog();

            using (new Carregando())
            {
                metodosAgenda.Atualiza_listAgenda(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                                                  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59"),
                                                  'P', 'P', 'P');

                if (metodosAgenda.listAgenda != null)
                {
                    metodosAgenda.ExibeAgendamentos(flpAgendamentos, Enum_TipoExibicaoAgenda.hoje);
                    metodosAgenda.AtualizaStatus(flpAgendamentos);
                }
            }
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

        #endregion

        private void frPrincipal_Click(object sender, EventArgs e)
        {
            LayoutMenu(EnumMenu.nenhum);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metodosAgenda.AtualizaStatus(flpAgendamentos);
        }

        #endregion
    }
}

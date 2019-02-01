using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using AgendaMais.Classes.Windows;
using AgendaMais.Properties;
using AgendaMais.Telas;
using AgendaMais.Telas.Cadastros;
using AgendaMais.Telas.Relatórios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaMais
{
    public partial class frPrincipal : Form
    {
        #region Variáveis Globais
        public static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        MetodosAgenda metodosAgenda = new MetodosAgenda();
        #endregion

        #region Validações Iniciais
        bool ValidaLicenca(string login, string senha)
        {
            login += ".txt";

            try
            {
                using (new Carregando("Verificando..."))
                {
                    using (new ExecutarComoAdmin())
                    {
                        GoogleDrive.Download(login, $"{mainPath}\\BD\\{login}");
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao consultar Licença de Uso\n\n" + erro.Message);
            }

            if (File.Exists($"{mainPath}\\BD\\{login}"))
            {
                string[] licenca = File.ReadAllLines($"{mainPath}\\BD\\{login}");

                if (licenca[0] != "key=true")
                {
                    MessageBox.Show("Desculpe, existe algo de errado com a sua licença de uso.");
                    File.Delete($"{mainPath}\\BD\\{login}");
                    return false;
                }
                if (licenca[1] != "senha=" + senha)
                {
                    MessageBox.Show("Ops! Senha icorreta");
                    File.Delete($"{mainPath}\\BD\\{login}");
                    return false;
                }
                File.Delete($"{mainPath}\\BD\\{login}");

                return true;
            }
            else
                throw new Exception("Ops! Não encontrei o usuário informado!");
        }

        #region Valida Comunicação com PostgreSQL
        void ValidaServicoPostgreSQL()
        {
            string servicoPostgreSQL = "PostgreSQL9.6";
            try
            {
                if (ServicosWindows.StatusServico(servicoPostgreSQL) == false)
                {
                    try
                    {
                        using (new Carregando("Iniciando Serviço..."))
                        {
                            using (new ExecutarComoAdmin())
                            {
                                ServicosWindows.IniciarServico(servicoPostgreSQL);
                            }
                        }
                    }
                    catch
                    {
                        using (new Carregando("Falha em iniciar serviço\nExecutando pg_restartxlog..."))
                        {
                            Restartxlog();
                        }
                        using (new Carregando("Tentando iniciar\nserviço novamente..."))
                        {
                            ServicosWindows.IniciarServico(servicoPostgreSQL);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Puxa me desculpe, o Serviço de Banco de Dados está parado ou ainda está iniciando.\n" +
                                "Aguarde mais um pouco. Caso o problema persista reinicie o computador. " +
                                "\n\nErro: " + erro.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        static void Restartxlog()
        {
            #region  Teste
            //if (File.Exists("C:\\AgendaMais\\pgsql\\data\\postmaster.pid"))
            //{
            //    File.Delete("C:\\AgendaMais\\pgsql\\data\\postmaster.pid");
            //    CMD cmd = new CMD();
            //    string comand = "\"C:\\AgendaMais\\pgsql\\bin\\pg_resetxlog\" -f ../data";
            //    string result = cmd.ExecutarCMD(comand);
            //}
            #endregion

            #region oficial
            if (File.Exists($"{mainPath}\\pgsql\\data\\postmaster.pid"))
            {
                File.Delete($"{mainPath}\\pgsql\\data\\postmaster.pid");
                CMD cmd = new CMD();
                string comand = $"\"{mainPath}\\pgsql\\bin\\pg_resetxlog\" -f ../data";
                string result = cmd.ExecutarCMD(comand);
            }
            #endregion
        }

        static void ValidaConexaoBD()
        {
            try
            {
                using (var connect = ConnectionDataBase.ConnectionDataBases()) { }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show(erro.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        #endregion

        void ValidaPastasDoSistema()
        {
            if (!Directory.Exists(mainPath + "\\BD"))
            {
                Directory.CreateDirectory(mainPath + "\\BD");
                Directory.CreateDirectory(mainPath + "\\BD\\imagens");
            }
            else if (!Directory.Exists(mainPath + "\\BD\\imagens"))
                Directory.CreateDirectory(mainPath + "\\BD\\imagens");
        }
        #endregion

        #region Load e Initialize
        public frPrincipal()
        {
            #region Validações iniciais
            // Verificação de Serviço de Banco de Dados
            try
            {
                using (new Carregando("Verificando Serviço\nde Banco de Dados"))
                {
                    ValidaServicoPostgreSQL();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao iniciar Serviço PostgreSQL9.6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            // Verificação de Conexão com Banco de Dados
            try
            {
                using (new Carregando("Verificando Conexão\ncom Banco de Dados"))
                {
                    ValidaConexaoBD();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Sem conexão com Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            // Verificação de Pastas do Sistema
            try
            {
                using (new Carregando("Verificando\nPastas do Sistema"))
                {
                    ValidaPastasDoSistema();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro na validação de pastas do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            #endregion

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
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Focus();
            txtLogin.Focus();
            timer1.Start();
        }
        #endregion

        #region Eventos
        #region Menu

        #region panRelatorios
        private void panRelatorios_Click(object sender, EventArgs e)
        {
            panMenuRelatorios.Visible = !panMenuRelatorios.Visible;
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

        #region panAgenda
        private void panAgenda_MouseHover(object sender, EventArgs e)
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
        }
        #endregion

        #region panCadastros
        private void Cadastros_Click(object sender, EventArgs e)
        {
            panMenuCadastros.Visible = !panMenuCadastros.Visible;
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

        #region panConfiguracoes
        private void panConfiguracoes_MouseHover(object sender, EventArgs e)
        {
            panConfiguracoes.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblConfiguracoes.ForeColor = Color.PowderBlue;
        }

        private void panConfiguracoes_MouseLeave(object sender, EventArgs e)
        {
            panConfiguracoes.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblConfiguracoes.ForeColor = Color.White;
        }
        #endregion

        #endregion

        #region Eventos Botões Principais

        #region ptbRelatorios
        private void ptbRelatorios_Click(object sender, EventArgs e)
        {
            frFrequenciaDeAgendamento frFrequenciaDeAgendamento = new frFrequenciaDeAgendamento();
            frFrequenciaDeAgendamento.Show();
        }

        private void ptbRelatorios_MouseHover(object sender, EventArgs e)
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

        private void ptbAgendamento_MouseHover(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.calendary;
        }

        private void ptbAgendamento_MouseLeave(object sender, EventArgs e)
        {
            ptbAgendamento.Image = Resources.calendary_transparency;
        }
        #endregion

        #region ptbCadCliente
        private void ptbClientes_Click(object sender, EventArgs e)
        {
            frCadCliente frCadCliente = new frCadCliente();
            frCadCliente.ShowDialog();
        }

        private void ptbClientes_MouseHover(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4_;
        }

        private void ptbClientes_MouseLeave(object sender, EventArgs e)
        {
            ptbClientes.Image = Resources.peaple__4__transparency;
        }
        #endregion

        #endregion

        #region Login
        private void panEntrar_MouseHover(object sender, EventArgs e)
        {
            panEntrar.BackColor = Color.FromArgb(41, 57, 85);
        }

        private void panEntrar_MouseLeave(object sender, EventArgs e)
        {
            panEntrar.BackColor = Color.FromArgb(54, 78, 111);
        }

        private void panEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                errorProvider.SetError(txtLogin, "Informe o usuário");
                return;
            }
            if (txtSenha.Text == "")
            {
                errorProvider.SetError(txtSenha, "Informe a senha");
                return;
            }

            try
            {
                panLogin.Visible = !ValidaLicenca(txtLogin.Text.Trim(), txtSenha.Text.Trim());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panEntrar_Click(panEntrar, e);
            }
        }
        #endregion

        private void frPrincipal_Click(object sender, EventArgs e)
        {
            panMenuRelatorios.Visible = false;
            panMenuCadastros.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metodosAgenda.AtualizaStatus(flpAgendamentos);
        }
        #endregion


    }
}

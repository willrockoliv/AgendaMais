using AgendaMais.Classes;
using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using AgendaMais.Classes.Windows;
using AgendaMais.Properties;
using AgendaMais.Telas.Cadastros;
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
        string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        MetodosAgenda metodosAgenda = new MetodosAgenda();
        #endregion

        #region Valida Comunicação com PostgreSQL
        static void ValidaServicoPostgreSQL()
        {
            string servicoPostgreSQL = "postgresql-x64-9.6";
            try
            {
                if (ServicosWindows.StatusServico(servicoPostgreSQL) == false)
                {
                    using (new ExecutarComoAdmin())
                    {
                        using (new Carregando())
                        {
                            ServicosWindows.IniciarServico(servicoPostgreSQL);
                        }
                    }
                }
            }

            catch
            {
                try
                {
                    Restartxlog();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        static void Restartxlog()
        {
            if (File.Exists("C:\\Program Files\\PostgreSQL\\9.6\\data\\postmaster.pid"))
            {
                File.Delete("C:\\Program Files\\PostgreSQL\\9.6\\data\\postmaster-copia.pid");
                File.Move("C:\\Program Files\\PostgreSQL\\9.6\\data\\postmaster.pid", "C:\\Program Files\\PostgreSQL\\9.6\\data\\postmaster-copia.pid");
                CMD cmd = new CMD();
                string comand = "\"C:\\Program Files\\PostgreSQL\\9.6\\bin\\pg_resetxlog\" -f ../data";
                string result = cmd.ExecutarCMD(comand);
                //result = cmd.ExecutarCMD("set pguser=postgres");
                //result = cmd.ExecutarCMD("set pgpassword=postgres");
                //result = cmd.ExecutarCMD("pg_resetxlog -f ../data");
                //string servicoPostgreSQL = "postgresql-x64-9.6";
                //ServicosWindows.IniciarServico(servicoPostgreSQL);
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

        #region Load e Initialize
        public frPrincipal()
        {
            //ValidaServicoPostgreSQL();
            ValidaPastasDoSistema();
            InitializeComponent();
            try
            {
                using (new Carregando("Só um momentinho\nJá iremos iniciar..."))
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
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timer1.Start();
        }
        #endregion

        #region Menu

        #region panFinanceiro
        private void panFinanceiro_MouseHover(object sender, EventArgs e)
        {
            panFinanceiro.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblFinanceiro.ForeColor = Color.PowderBlue;
        }

        private void panFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            panFinanceiro.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblFinanceiro.ForeColor = Color.White;
        }
        #endregion

        #region Agenda
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
        private void panCadastros_MouseHover(object sender, EventArgs e)
        {
            panCadastros.BackColor = Color.FromArgb(170, 16, 41, 99);
            lblCadastros.ForeColor = Color.PowderBlue;
        }

        private void panCadastros_MouseLeave(object sender, EventArgs e)
        {
            panCadastros.BackColor = Color.FromArgb(0, 16, 41, 99);
            lblCadastros.ForeColor = Color.White;
        }
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

        #region ptbFinanceiro
        private void ptbFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void ptbFinanceiro_MouseHover(object sender, EventArgs e)
        {
            try
            {
                ptbFinanceiro.Image = Image.FromFile(mainPath + "\\BD\\money.png");
            }
            catch
            {
            }
        }

        private void ptbFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                ptbFinanceiro.Image = Image.FromFile(mainPath + "\\BD\\money-transparency.png");
            }
            catch
            {
            }
        }
        #endregion

        #region ptbAgendamento
        public void ptbAgendamento_Click(object sender, EventArgs e)
        {
            frAgendamento frAgendamento;
            using (new Carregando("Carregando..."))
                frAgendamento = new frAgendamento();
            frAgendamento.ShowDialog();

            if (metodosAgenda.listAgenda != null)
            {
                using (new Carregando())
                {
                    metodosAgenda.Atualiza_listAgenda(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00"),
                                                      Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59"),
                                                      'P', 'P', 'P');
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            metodosAgenda.AtualizaStatus(flpAgendamentos);
        }

        private void Cadastros_Click(object sender, EventArgs e)
        {
            frCadastros frCadastros = new frCadastros();
            frCadastros.Show();
        }
    }
}

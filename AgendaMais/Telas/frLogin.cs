using AgendaMais.Classes;
using AgendaMais.Classes.Windows;
using Ionic.Zip;
using Npgsql;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgendaMais.Telas
{
    public partial class frLogin : Form
    {
        #region Variáveis
        public static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static bool Login { get; private set; }
        #endregion

        #region Validações Iniciais
        void ValidaPrimeiroAcesso()
        {
            if (File.Exists(mainPath + "\\pgsql.zip"))
            {
                Process.Start(mainPath + "\\Config_BD.exe");
                Process.GetCurrentProcess().Kill();
            }
        }

        void ValidaVersao()
        {
            try
            {
                using (new Carregando("Buscando Atualizações..."))
                {
                    GoogleDrive.Download("versao.txt", $"{mainPath}\\BD\\versao.txt");
                }
            }
            catch
            {
            }

            if (File.Exists($"{mainPath}\\BD\\versao.txt"))
            {
                string[] versao = File.ReadAllLines($"{mainPath}\\BD\\versao.txt", Encoding.Default);

                if (versao[0] == "AtualizacaoCritica=true")
                {
                    if (versao[1] != lblVersao.Text)
                    {
                        MessageBox.Show("Opa! Acho que encontrei uma atualiação muito importante! Preciso atualizar antes de iniciar tudo bem?! :)", "Atualização Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaVersao();
                    }
                }
                else
                {
                    if (versao[1] != lblVersao.Text)
                    {
                        if (MessageBox.Show("Encontrei uma versão mais atual do programa\n\n" +
                                       "Deseja Atualizar agora?", "Atualização Encontrada!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            AtualizaVersao();
                        }
                    }
                }
                File.Delete($"{mainPath}\\BD\\versao.txt");
            }
        }

        void AtualizaVersao()
        {
            try
            {
                using (new Carregando("Buscando Atualizações..."))
                {
                    Directory.Delete($"{mainPath}\\Update", true);
                    Directory.CreateDirectory(mainPath + "\\Update");

                    GoogleDrive.Download("Update.zip", $"{mainPath}\\Update\\Update.zip");
                    ExtrairArquivoZip($"{mainPath}\\Update\\Update.zip", $"{mainPath}\\Update\\");
                    File.Delete($"{mainPath}\\Update\\Update.zip");

                    Process.Start($"{mainPath}\\Update\\Update.exe");
                    Process.GetProcesses("AgendaMais.exe");
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {
                MessageBox.Show("Não consegui fazer o Download da nova versão! Vou tentar novamente mais tarde ok?");
            }
        }

        bool ValidaLicenca(string login, string senha)
        {
            login += ".txt";

            try
            {
                using (new Carregando("Verificando..."))
                {
                    GoogleDrive.Download(login, $"{mainPath}\\BD\\{login}");
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
                            ServicosWindows.IniciarServico(servicoPostgreSQL);
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
                if (erro.Message == "Serviço PostgreSQL9.6 não foi encontrado no computador '.'.")
                {
                    Process.Start(mainPath + "\\Config_BD.exe");
                    Process.GetCurrentProcess().Kill();
                }

                throw new Exception("Puxa me desculpe, o Serviço de Banco de Dados está parado ou ainda está iniciando.\n" +
                                "Aguarde mais um pouco. Caso o problema persista reinicie o computador. " +
                                "\n\nErro: " + erro.Message);
            }
        }

        static void Restartxlog()
        {
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
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                Process.GetCurrentProcess().Kill();
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

            if (!Directory.Exists(mainPath + "\\Update"))
                Directory.CreateDirectory(mainPath + "\\Update");
        }

        private static void ExtrairArquivoZip(string localizacaoArquivoZip, string destino)
        {
            if (File.Exists(localizacaoArquivoZip))
            {
                //recebe a localização do arquivo zip
                using (ZipFile zip = new ZipFile(localizacaoArquivoZip))
                {
                    //verifica se o destino existe
                    if (Directory.Exists(destino))
                    {
                        try
                        {
                            //extrai o arquivo zip para o destino
                            zip.ExtractAll(destino);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    else
                    {
                        //lança uma exceção se o destino não existe
                        throw new DirectoryNotFoundException("O arquivo destino não foi localizado");
                    }
                }
            }
            else
            {
                //lança uma exceção se a origem não existe
                throw new FileNotFoundException("O Arquivo Zip não foi localizado");
            }
        }
        #endregion

        public frLogin()
        {
            InitializeComponent();
            txtLogin.Focus();
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            // Verificação de configurações iniciais
            try
            {
                ValidaPrimeiroAcesso();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Não foi possível realizar as configurações iniciais\n\n ERRO: {erro.Message}", "Erro ao iniciar Serviço PostgreSQL9.6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }


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

            // Verificação de Atualização de Versão
            try
            {
                using (new Carregando("Verificando\nAtualizações..."))
                {
                    ValidaVersao();
                }
            }
            catch
            {
            }
        }

        #region Eventos
        private void panEntrar_MouseEnter(object sender, EventArgs e)
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
                Login = ValidaLicenca(txtLogin.Text.Trim(), txtSenha.Text.Trim());
                if (Login)
                    this.Close();
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
    }
}

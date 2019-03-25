using Config_BD.Classes;
using Config_BD.Windows;
using Ionic.Zip;
using Npgsql;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Config_BD
{
    public partial class frConfigBD : Form
    {
        telaConfigBD telaConfigBD = new telaConfigBD();
        
        #region Variáveis
        private static string client_id = Path.GetDirectoryName(Application.ExecutablePath) + "\\client_id.json";
        private static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        private int cont = 0;
        #endregion

        #region Métodos
        void ExtrairBD()
        {
            try
            {
                //using (telaConfigBD telaConfigBD = new telaConfigBD())
                //{
                if (File.Exists(mainPath + "\\pgsql.zip") && Directory.Exists(mainPath + "\\pgsql"))
                    File.Delete(mainPath + "\\pgsql.zip");
                else if (!File.Exists(mainPath + "\\pgsql.zip") && !Directory.Exists(mainPath + "\\pgsql"))
                    throw new Exception("pgsql.zip não foi encontrado");
                else if (File.Exists(mainPath + "\\pgsql.zip") && !Directory.Exists(mainPath + "\\pgsql"))
                {
                    Directory.CreateDirectory(mainPath + "\\pgsql");

                    telaConfigBD.ProgressBar.Value = 25;
                    telaConfigBD.TxtInfo.Text = "Extraindo arquivos...";

                    ExtrairArquivoZip(mainPath + "\\pgsql.zip", mainPath + "\\pgsql");

                    telaConfigBD.ProgressBar.Value = 50;

                    File.Delete(mainPath + "\\pgsql.zip");

                    telaConfigBD.ProgressBar.Value = 75;
                }

                telaConfigBD.TxtInfo.Text = "Registrando serviço PostgreSQL9.6...";
                try
                {
                    string bat = $"cd \"{mainPath}\\pgsql\\bin\"" + Environment.NewLine +
                                 $"pg_ctl register -N \"PostgreSQL9.6\" -U \"NT AUTHORITY\\NetworkService\" -D \"../data\" -w";
                    File.WriteAllText("register_service.cmd", bat);
                    Process.Start("register_service.cmd");
                    //telaConfigBD.ProgressBar.Value = 100;
                }
                catch
                {
                    throw;
                }

                ValidaServicoPostgreSQL();
                //}
            }
            catch
            {
                throw;
            }
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

        #region Valida Comunicação com PostgreSQL
        void ValidaServicoPostgreSQL()
        {
            //using (telaConfigBD telaConfigBD = new telaConfigBD())
            //{
            string servicoPostgreSQL = "PostgreSQL9.6";
            try
            {
                if (ServicosWindows.StatusServico(servicoPostgreSQL) == false)
                {
                    try
                    {
                        telaConfigBD.TxtInfo.Text = "Iniciando Serviço...";
                        telaConfigBD.ProgressBar.Value = 97;

                        ServicosWindows.IniciarServico(servicoPostgreSQL);

                        telaConfigBD.ProgressBar.Value = 100;
                        telaConfigBD.TxtInfo.Text = "Tudo ok!";
                    }
                    catch
                    {
                        telaConfigBD.TxtInfo.Text = "Falha em iniciar serviço\nExecutando pg_restartxlog...";

                        Restartxlog();

                        telaConfigBD.TxtInfo.Text = "Tentando iniciar\nserviço novamente...";

                        ServicosWindows.IniciarServico(servicoPostgreSQL);
                    }
                }
            }
            catch (Exception erro)
            {
                if (erro.Message == "Serviço PostgreSQL9.6 não foi encontrado no computador '.'." && cont < 5)
                {
                    cont++;
                    ValidaServicoPostgreSQL();
                }
                else
                    throw new Exception("Puxa me desculpe, não copnsegui iniciar o serviço do banco de bados,\n" +
                                        "ou talvez esetja demorando para iniciar.\n" +
                                        "Aguarde mais um pouco. Caso o problema persista reinicie o computador. " +
                                        "\n\nErro: " + erro.Message);
            }
            //}
        }

        static void Restartxlog()
        {
            if (File.Exists($"{mainPath}\\pgsql\\data\\postmaster.pid"))
            {
                File.Delete($"{mainPath}\\pgsql\\data\\postmaster.pid");
                CMD cmd = new CMD();
                string comand = $"\"{mainPath}\\pgsql\\bin\\pg_resetxlog\" -f ../data";
                string result = cmd.ExecutarCMD(comand);
            }
        }
        #endregion

        #endregion

        public frConfigBD()
        {
            InitializeComponent();
        }

        private void frConfigBD_Load(object sender, EventArgs e)
        {
            try
            {
                ExtrairBD();
                Process.Start(mainPath + "\\AgendaMais.exe");
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO: {erro.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }
    }

    public class telaConfigBD : Form, IDisposable
    {
        Form tela = new Form();
        private TextBox txtInfo = new TextBox();
        private TextBox txtConfigInicial = new TextBox();
        private Bitmap animacao_gif = Properties.Resources.Agenda;
        private Button btnMinimizar = new Button();
        private PictureBox ptbBackground = new PictureBox();
        private PictureBox ptbLogo = new PictureBox();
        private ProgressBar progressBar = new ProgressBar();

        public TextBox TxtInfo { get => txtInfo; set => txtInfo = value; }
        public ProgressBar ProgressBar { get => progressBar; set => progressBar = value; }

        public telaConfigBD()
        {
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public new void Dispose()
        {
            bool teste = true;
            while (teste)
            {
                try
                {
                    tela.Invoke(new MethodInvoker(stopThread));
                    teste = false;
                }
                catch { }
            }
        }

        private void stopThread()
        {
            tela.Close();
        }


        private void workerThread()
        {
            //
            // txtConfigInicial
            //
            txtConfigInicial.BackColor = Color.SteelBlue;
            txtConfigInicial.BorderStyle = BorderStyle.None;
            txtConfigInicial.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfigInicial.ForeColor = Color.White;
            txtConfigInicial.Location = new Point(0, 343);
            txtConfigInicial.Multiline = true;
            txtConfigInicial.Size = new Size(592, 39);
            txtConfigInicial.Text = "Estou fazendo apenas algumas configurações de primeiro acesso \r\n" +
                                    "Dentro de mais alguns instantes já iremos iniciar... :)";
            txtConfigInicial.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInfo
            // 
            txtInfo.Anchor = AnchorStyles.Top;
            txtInfo.BackColor = Color.SteelBlue;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfo.ForeColor = Color.White;
            txtInfo.Location = new Point(0, 382);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(592, 38);
            txtInfo.TabIndex = 5;
            txtInfo.TabStop = false;
            txtInfo.Text = "Configurando Servidor...";
            txtInfo.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            ProgressBar.Dock = DockStyle.Bottom;
            ProgressBar.Location = new Point(0, 420);
            ProgressBar.Size = new Size(592, 25);
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.TabIndex = 9;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(563, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.Text = "__";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += new EventHandler(btnMinimizar_Click);
            // 
            // ptbLogo
            // 
            ptbLogo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ptbLogo.BackColor = Color.SteelBlue;
            ptbLogo.Image = Properties.Resources._1498590839_Streamline_52;
            ptbLogo.Location = new Point(0, 29);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(602, 75);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // ptbBackground
            // 
            ptbBackground.Dock = DockStyle.Fill;
            ptbBackground.Image = animacao_gif;
            ptbBackground.Location = new Point(0, 0);
            ptbBackground.Name = "ptbBackground";
            ptbBackground.Size = new Size(592, 445);
            ptbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // frConfigBD
            // 
            tela.AutoScaleDimensions = new SizeF(6F, 13F);
            tela.AutoScaleMode = AutoScaleMode.Font;
            tela.BackColor = Color.White;
            tela.ClientSize = new Size(592, 445);
            tela.Controls.Add(txtInfo);
            tela.Controls.Add(txtConfigInicial);
            tela.Controls.Add(progressBar);
            tela.Controls.Add(btnMinimizar);
            tela.Controls.Add(ptbLogo);
            tela.Controls.Add(ptbBackground);
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Name = "frConfigBD";
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Text = "Configuração de Banco de Dados";
            tela.ResumeLayout(false);
            tela.PerformLayout();
            Application.Run(tela);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            tela.WindowState = FormWindowState.Minimized;
        }
    }
}

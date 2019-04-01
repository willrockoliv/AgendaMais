using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Update
{
    public partial class frUpdate : Form
    {
        #region Variáveis
        private static string client_id = Path.GetDirectoryName(Application.ExecutablePath) + "\\client_id.json";
        private static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);
        #endregion

        #region Métodos
        void Atualizar()
        {
            try
            {
                using (telaUpdate telaUpdate = new telaUpdate())
                {
                    Download(telaUpdate);

                    if (File.Exists(mainPath + "\\AgendaMais\\AgendaMais.zip"))
                    {
                        Extrair(telaUpdate);

                        if (File.Exists(mainPath + "\\alterBD.sql"))
                            AlterBD(telaUpdate);

                        telaUpdate.TxtInfo.Text = "Tudo ok!";
                        telaUpdate.ProgressBar.Value = 100;

                        Process.Start(mainPath.Replace("\\Update", "") + "\\AgendaMais.exe");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        void Download(telaUpdate telaUpdate)
        {
            try
            {
                telaUpdate.TxtInfo.Text = "Autenticando...";
                var credenciais = Autenticar();
                telaUpdate.TxtInfo.Text = "Autenticação ok!";
                telaUpdate.ProgressBar.Value = 14;

                telaUpdate.TxtInfo.Text = "Abrindo Serviço...";
                using (var servico = AbrirServico(credenciais))
                {
                    telaUpdate.TxtInfo.Text = "Serviço ok!";
                    telaUpdate.ProgressBar.Value += 14;

                    telaUpdate.TxtInfo.Text = "Procurando Atualizações...";
                    var ids = ProcurarArquivoId(servico, "AgendaMais.zip");
                    telaUpdate.ProgressBar.Value += 14;

                    if (ids != null && ids.Any())
                    {
                        var request = servico.Files.Get(ids.First());

                        Directory.CreateDirectory(mainPath + "\\AgendaMais");

                        telaUpdate.TxtInfo.Text = "Baixando Atualização...";
                        using (var stream = new FileStream(mainPath + "\\AgendaMais\\AgendaMais.zip", FileMode.Create, FileAccess.Write))
                        {
                            request.Download(stream);
                        }
                        telaUpdate.TxtInfo.Text = "Atuzalização Baixada";
                        telaUpdate.ProgressBar.Value += 14;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        void Extrair(telaUpdate telaUpdate)
        {
            try
            {
                telaUpdate.TxtInfo.Text = "Extraindo arquivos...";

                ExtrairArquivoZip(mainPath + "\\AgendaMais\\AgendaMais.zip", mainPath + "\\AgendaMais");

                File.Delete(mainPath + "\\AgendaMais\\AgendaMais.zip");

                foreach (var arquivos in Directory.GetFiles(mainPath + "\\AgendaMais", "*.*", SearchOption.AllDirectories))
                    File.Copy(arquivos, arquivos.Replace(mainPath + "\\AgendaMais", mainPath.Replace("\\Update", "")), true);

                Directory.Delete(mainPath + "\\AgendaMais", true);
            }
            catch
            {
                throw;
            }
        }

        void AlterBD(telaUpdate telaUpdate)
        {
            try
            {
                telaUpdate.TxtInfo.Text = "Atualizando Banco de Dados...";

                string[] arquivo = File.ReadAllLines($"{mainPath}\\alterBD.sql");
                List<string> sql = new List<string>();
                foreach (string linha in arquivo)
                    sql.Add(linha);
                DB.ExecutaSQL(sql);
            }
            catch
            {
                throw;
            }
        }

        private static UserCredential Autenticar()
        {
            UserCredential credenciais;

            using (var stream = new FileStream(client_id, FileMode.Open, FileAccess.Read))
            {
                var diretorioAtual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var diretorioCredenciais = Path.Combine(diretorioAtual, "credential");

                credenciais = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.DriveReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(diretorioCredenciais, true)).Result;
            }

            return credenciais;
        }

        private static DriveService AbrirServico(UserCredential credenciais)
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credenciais
            });
        }

        private static string[] ProcurarArquivoId(DriveService servico, string nome, bool procurarNaLixeira = false)
        {
            var retorno = new List<string>();

            var request = servico.Files.List();
            request.Q = string.Format("name = '{0}'", nome);
            if (!procurarNaLixeira)
            {
                request.Q += " and trashed = false";
            }
            request.Fields = "files(id)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    retorno.Add(arquivo.Id);
                }
            }

            return retorno.ToArray();
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

        public frUpdate()
        {
            InitializeComponent();
        }

        private void frUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                Atualizar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                Process.GetCurrentProcess().Kill();
            }
        }
    }

    public class telaUpdate : Form, IDisposable
    {
        Form tela = new Form();
        TextBox txtInfo = new TextBox();
        Button btnMinimizar = new Button();
        PictureBox ptbUpdate = new PictureBox();
        ProgressBar progressBar = new ProgressBar();
        private Bitmap animacao_gif = Properties.Resources.update;

        public ProgressBar ProgressBar { get => progressBar; set => progressBar = value; }
        public TextBox TxtInfo { get => txtInfo; set => txtInfo = value; }

        public telaUpdate()
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
            // txtInfo
            //
            TxtInfo.Anchor = AnchorStyles.Top;
            TxtInfo.BackColor = Color.SteelBlue;
            TxtInfo.BorderStyle = BorderStyle.None;
            TxtInfo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfo.ForeColor = Color.White;
            TxtInfo.Location = new Point(183, 126);
            TxtInfo.Multiline = true;
            TxtInfo.Name = "txtInfo";
            TxtInfo.ReadOnly = true;
            TxtInfo.Size = new Size(382, 56);
            TxtInfo.TabStop = false;
            TxtInfo.Text = "Atualizando...";
            TxtInfo.TextAlign = HorizontalAlignment.Center;
            //
            // progressBar
            //
            ProgressBar.Dock = DockStyle.Bottom;
            ProgressBar.Location = new Point(0, 327);
            ProgressBar.Name = "progressBar";
            ProgressBar.Size = new Size(605, 23);
            //
            // btnMinimizar
            //
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Location = new System.Drawing.Point(579, 3);
            btnMinimizar.Name = "button1";
            btnMinimizar.Size = new System.Drawing.Size(23, 23);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.Text = "__";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += new System.EventHandler(this.button1_Click);
            //
            // ptbUpdate
            //
            ptbUpdate.Dock = DockStyle.Fill;
            ptbUpdate.Image = Properties.Resources.update;
            ptbUpdate.Location = new Point(0, 0);
            ptbUpdate.Name = "ptbUpdate";
            ptbUpdate.Size = new Size(605, 350);
            ptbUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            //
            // tela
            //
            tela.AutoScaleDimensions = new SizeF(6F, 13F);
            tela.AutoScaleMode = AutoScaleMode.Font;
            tela.BackColor = Color.White;
            tela.ClientSize = new Size(605, 350);
            tela.Controls.Add(TxtInfo);
            tela.Controls.Add(ProgressBar);
            tela.Controls.Add(btnMinimizar);
            tela.Controls.Add(ptbUpdate);
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Name = "frUpdate";
            tela.StartPosition = FormStartPosition.CenterScreen;
            tela.Text = "Update";
            Application.Run(tela);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

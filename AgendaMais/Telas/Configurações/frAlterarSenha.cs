using AgendaMais.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMais.Telas.Configurações
{
    public partial class frAlterarSenha : Form
    {
        public static string mainPath = Path.GetDirectoryName(Application.ExecutablePath);

        void DownloadArquivoLicenca()
        {
            string login = frLogin.Login + ".txt";

            try
            {
                using (new Carregando("Consultando..."))
                {
                    GoogleDrive.Download(login, $"{mainPath}\\BD\\{login}");
                }

                ValidaSenhaAtual(login, txtSenhaAtual.Text);

                File.Delete($"{mainPath}\\BD\\{login}");
            }
            catch (Exception erro)
            {
                File.Delete($"{mainPath}\\BD\\{login}");
                throw new Exception("Erro ao consultar Usuário e Senha\n\n" + erro.Message);
            }
        }

        void ValidaSenhaAtual(string login, string senha)
        {
            if (File.Exists($"{mainPath}\\BD\\{login}"))
            {
                string[] arquivo = File.ReadAllLines($"{mainPath}\\BD\\{login}");

                if (arquivo[1] != "senha=" + senha)
                {
                    File.Delete($"{mainPath}\\BD\\{login}");
                    errorProvider.SetError(txtSenhaAtual, "Ops! Senha Atual incorreta!");
                }
                else
                {
                    ValidaConfirmacaoNovaSenha(login);
                }
            }
            else
                throw new Exception("Erro ao consultar Usuário e Senha\n\nERRO: Arquivo de licença não encontrado.");
        }

        void ValidaConfirmacaoNovaSenha(string login)
        {
            if (txtNovaSenha.Text == txtConfirmacao.Text)
                AlterarSenha(login);
            else
            {
                errorProvider.SetError(txtNovaSenha, "Senhas não conferem!");
                errorProvider.SetError(txtConfirmacao, "Senhas não conferem!");
            }
        }

        void AlterarSenha(string login)
        {
            try
            {
                using (new Carregando("Alterando Senha..."))
                {
                    string[] arquivo = File.ReadAllLines($"{mainPath}\\BD\\{login}");

                    arquivo[1] = "senha=" + txtNovaSenha.Text;

                    File.WriteAllLines($"{mainPath}\\BD\\{login}", arquivo);

                    GoogleDrive.DeletarItem(login);

                    GoogleDrive.Upload($"{mainPath}\\BD\\{login}");
                }

                MessageBox.Show("Senha alterada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public frAlterarSenha()
        {
            InitializeComponent();
        }

        private void txtConfirmacao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panAlterar_Click(panAlterar, e);
            }
        }

        private void panAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadArquivoLicenca();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

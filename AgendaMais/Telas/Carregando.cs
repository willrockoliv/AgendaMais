using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace AgendaMais.Classes
{
    public class Carregando : Form, IDisposable
    {
        private Form frCarregando;
        public Label lblMensagem = new Label();
        public PictureBox ptbCarregando = new PictureBox();
        public string mensagem;
        private Bitmap animacao_gif = Properties.Resources.carregando;
    
        public Carregando()
        {
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public Carregando(string p_mensagem)
        {
            mensagem = p_mensagem;
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public Carregando(string p_mensagem, Bitmap p_animacao_gif)
        {
            animacao_gif = p_animacao_gif;
            mensagem = p_mensagem;
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
                    frCarregando.Invoke(new MethodInvoker(stopThread));
                    teste = false;
                }
                catch { }
            }
        }

        private void stopThread()
        {
            frCarregando.Close();
        }

        private void workerThread()
        {
            //
            // lblMensagem
            //
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(12, 148);
            lblMensagem.Text = mensagem;
            //
            // ptbCarregando
            //
            ptbCarregando.Anchor = AnchorStyles.Top;
            ptbCarregando.BackColor = Color.Transparent;
            ptbCarregando.Cursor = Cursors.WaitCursor;
            ptbCarregando.Image = animacao_gif;
            ptbCarregando.Location = new Point(1, 3);
            ptbCarregando.Name = "ptbCarregando";
            ptbCarregando.Size = new Size(284, 142);
            ptbCarregando.SizeMode = PictureBoxSizeMode.Zoom;

            frCarregando = new Form();   // Substitute this with your own
            frCarregando.StartPosition = FormStartPosition.CenterScreen;
            frCarregando.FormBorderStyle = FormBorderStyle.None;
            frCarregando.BackColor = Color.White;
            frCarregando.Controls.Add(ptbCarregando);
            frCarregando.Controls.Add(lblMensagem);
            frCarregando.Size = new Size(324, 200);
            Application.Run(frCarregando);
        }
    }
}
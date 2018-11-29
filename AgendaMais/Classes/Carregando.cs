using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AgendaMais.Classes
{
    public class Carregando : IDisposable
    {
        private Form frCarregando;
        private string mensagem;

        public Carregando()
        {
            //fr_location = p_fr_location;
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public Carregando(string p_mensagem)
        {
            //fr_location = p_fr_location;
            mensagem = p_mensagem;
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        public void Dispose()
        {
            frCarregando.Invoke(new MethodInvoker(stopThread));
        }
        private void stopThread()
        {
            frCarregando.Close();
        }
        private void workerThread()
        {
            frCarregando = new Form();   // Substitute this with your own
            frCarregando.StartPosition = FormStartPosition.CenterScreen;
            frCarregando.FormBorderStyle = FormBorderStyle.None;
            frCarregando.Controls.Add(ptbCarregando());
            frCarregando.Controls.Add(lblMensagem());
            frCarregando.Size = new Size(100, 150);
            //frCarregando.BackColor = Color.FromArgb(173, 177, 195);
            Application.Run(frCarregando);
        }

        PictureBox ptbCarregando()
        {
            PictureBox ptbCarregando = new PictureBox();
            ptbCarregando.Anchor = AnchorStyles.Top;
            ptbCarregando.BackColor = Color.Transparent;
            ptbCarregando.BackgroundImageLayout = ImageLayout.Stretch;
            ptbCarregando.Cursor = Cursors.WaitCursor;
            ptbCarregando.Image = Properties.Resources.carregando;
            ptbCarregando.Location = new Point(90, 0);
            ptbCarregando.Name = "ptbCarregando";
            ptbCarregando.Size = new Size(100, 100);
            ptbCarregando.SizeMode = PictureBoxSizeMode.StretchImage;

            return ptbCarregando;
        }

        Label lblMensagem()
        {
            Label lblMensagem = new Label();
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(5, 110);
            lblMensagem.Text = mensagem;
            return lblMensagem;
        }
    }
}
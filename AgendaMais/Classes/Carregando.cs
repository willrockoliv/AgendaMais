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
            frCarregando = new Form();   // Substitute this with your own
            frCarregando.StartPosition = FormStartPosition.CenterScreen;
            frCarregando.FormBorderStyle = FormBorderStyle.None;
            frCarregando.Controls.Add(ptbCarregando());
            frCarregando.Controls.Add(lblMensagem());
            frCarregando.Size = new Size(100, 150);
            ArredondaCantosDoForm();
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

        public void ArredondaCantosDoForm()
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
    }
}
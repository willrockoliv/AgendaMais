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
            frCarregando = new Form();   // Substitute this with your own
            frCarregando.StartPosition = FormStartPosition.CenterScreen;
            frCarregando.FormBorderStyle = FormBorderStyle.None;
            frCarregando.BackColor = Color.White;
            frCarregando.Controls.Add(ptbCarregando());
            frCarregando.Controls.Add(lblMensagem());
            frCarregando.Size = new Size(324, 200);
            Application.Run(frCarregando);
        }

        PictureBox ptbCarregando()
        {
            PictureBox ptbCarregando = new PictureBox();
            ptbCarregando.Anchor = AnchorStyles.Top;
            ptbCarregando.BackColor = Color.Transparent;
            ptbCarregando.Cursor = Cursors.WaitCursor;
            ptbCarregando.Image = animacao_gif;
            ptbCarregando.Location = new Point(1, 3);
            ptbCarregando.Name = "ptbCarregando";
            ptbCarregando.Size = new Size(284, 142);
            ptbCarregando.SizeMode = PictureBoxSizeMode.Zoom;

            return ptbCarregando;
        }

        Label lblMensagem()
        {
            Label lblMensagem = new Label();
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(12, 148);
            lblMensagem.Text = mensagem;
            return lblMensagem;
        }

        //private void InitializeComponent()
        //{
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Location = new System.Drawing.Point(12, 148);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(35, 13);
        //    this.label1.TabIndex = 1;
        //    this.label1.Text = "label1";
        //    // 
        //    // pictureBox1
        //    // 
        //    this.pictureBox1.Image = global::AgendaMais.Properties.Resources.carregando_relatorio;
        //    this.pictureBox1.Location = new System.Drawing.Point(12, 3);
        //    this.pictureBox1.Name = "pictureBox1";
        //    this.pictureBox1.Size = new System.Drawing.Size(284, 142);
        //    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        //    this.pictureBox1.TabIndex = 0;
        //    this.pictureBox1.TabStop = false;
        //    // 
        //    // Carregando
        //    // 
        //    this.ClientSize = new System.Drawing.Size(324, 200);
        //    this.Controls.Add(this.label1);
        //    this.Controls.Add(this.pictureBox1);
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Name = "Carregando";
        //    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
    }
}
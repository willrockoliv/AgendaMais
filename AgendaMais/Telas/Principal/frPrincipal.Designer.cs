namespace AgendaMais
{
    partial class frPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.panConfiguracoes = new System.Windows.Forms.Panel();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.panCadastros = new System.Windows.Forms.Panel();
            this.lblCadastros = new System.Windows.Forms.Label();
            this.panAgenda = new System.Windows.Forms.Panel();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.panFinanceiro = new System.Windows.Forms.Panel();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.ptbFinanceiro = new System.Windows.Forms.PictureBox();
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.ptbAgendamento = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flpAgendamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panConfiguracoes.SuspendLayout();
            this.panCadastros.SuspendLayout();
            this.panAgenda.SuspendLayout();
            this.panFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panConfiguracoes
            // 
            this.panConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.panConfiguracoes.Controls.Add(this.lblConfiguracoes);
            this.panConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panConfiguracoes.Location = new System.Drawing.Point(954, 3);
            this.panConfiguracoes.Name = "panConfiguracoes";
            this.panConfiguracoes.Size = new System.Drawing.Size(311, 28);
            this.panConfiguracoes.TabIndex = 7;
            this.panConfiguracoes.MouseLeave += new System.EventHandler(this.panConfiguracoes_MouseLeave);
            this.panConfiguracoes.MouseHover += new System.EventHandler(this.panConfiguracoes_MouseHover);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.lblConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracoes.Location = new System.Drawing.Point(67, 3);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(177, 22);
            this.lblConfiguracoes.TabIndex = 3;
            this.lblConfiguracoes.Text = "CONFIGURAÇÕES";
            this.lblConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfiguracoes.MouseLeave += new System.EventHandler(this.panConfiguracoes_MouseLeave);
            this.lblConfiguracoes.MouseHover += new System.EventHandler(this.panConfiguracoes_MouseHover);
            // 
            // panCadastros
            // 
            this.panCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastros.BackColor = System.Drawing.Color.Transparent;
            this.panCadastros.Controls.Add(this.lblCadastros);
            this.panCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadastros.Location = new System.Drawing.Point(637, 3);
            this.panCadastros.Name = "panCadastros";
            this.panCadastros.Size = new System.Drawing.Size(311, 28);
            this.panCadastros.TabIndex = 6;
            this.panCadastros.Click += new System.EventHandler(this.Cadastros_Click);
            this.panCadastros.MouseLeave += new System.EventHandler(this.panCadastros_MouseLeave);
            this.panCadastros.MouseHover += new System.EventHandler(this.panCadastros_MouseHover);
            // 
            // lblCadastros
            // 
            this.lblCadastros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastros.AutoSize = true;
            this.lblCadastros.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastros.ForeColor = System.Drawing.Color.White;
            this.lblCadastros.Location = new System.Drawing.Point(94, 3);
            this.lblCadastros.Name = "lblCadastros";
            this.lblCadastros.Size = new System.Drawing.Size(124, 22);
            this.lblCadastros.TabIndex = 2;
            this.lblCadastros.Text = "CADASTROS";
            this.lblCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastros.Click += new System.EventHandler(this.Cadastros_Click);
            this.lblCadastros.MouseLeave += new System.EventHandler(this.panCadastros_MouseLeave);
            this.lblCadastros.MouseHover += new System.EventHandler(this.panCadastros_MouseHover);
            // 
            // panAgenda
            // 
            this.panAgenda.BackColor = System.Drawing.Color.Transparent;
            this.panAgenda.Controls.Add(this.lblAgenda);
            this.panAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panAgenda.Location = new System.Drawing.Point(320, 3);
            this.panAgenda.Name = "panAgenda";
            this.panAgenda.Size = new System.Drawing.Size(311, 28);
            this.panAgenda.TabIndex = 5;
            this.panAgenda.Click += new System.EventHandler(this.panAgenda_Click);
            this.panAgenda.MouseLeave += new System.EventHandler(this.panAgenda_MouseLeave);
            this.panAgenda.MouseHover += new System.EventHandler(this.panAgenda_MouseHover);
            // 
            // lblAgenda
            // 
            this.lblAgenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgenda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.White;
            this.lblAgenda.Location = new System.Drawing.Point(108, 3);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(95, 22);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "AGENDA";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgenda.Click += new System.EventHandler(this.panAgenda_Click);
            this.lblAgenda.MouseLeave += new System.EventHandler(this.panAgenda_MouseLeave);
            this.lblAgenda.MouseHover += new System.EventHandler(this.panAgenda_MouseHover);
            // 
            // panFinanceiro
            // 
            this.panFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panFinanceiro.Controls.Add(this.lblFinanceiro);
            this.panFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panFinanceiro.Location = new System.Drawing.Point(3, 3);
            this.panFinanceiro.Name = "panFinanceiro";
            this.panFinanceiro.Size = new System.Drawing.Size(311, 28);
            this.panFinanceiro.TabIndex = 4;
            this.panFinanceiro.MouseLeave += new System.EventHandler(this.panFinanceiro_MouseLeave);
            this.panFinanceiro.MouseHover += new System.EventHandler(this.panFinanceiro_MouseHover);
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinanceiro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceiro.ForeColor = System.Drawing.Color.White;
            this.lblFinanceiro.Location = new System.Drawing.Point(93, 3);
            this.lblFinanceiro.Name = "lblFinanceiro";
            this.lblFinanceiro.Size = new System.Drawing.Size(126, 22);
            this.lblFinanceiro.TabIndex = 0;
            this.lblFinanceiro.Text = "FINANCEIRO";
            this.lblFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinanceiro.MouseLeave += new System.EventHandler(this.panFinanceiro_MouseLeave);
            this.lblFinanceiro.MouseHover += new System.EventHandler(this.panFinanceiro_MouseHover);
            // 
            // ptbFinanceiro
            // 
            this.ptbFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.ptbFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbFinanceiro.Image = global::AgendaMais.Properties.Resources.money__4__tranparency;
            this.ptbFinanceiro.Location = new System.Drawing.Point(202, 86);
            this.ptbFinanceiro.Name = "ptbFinanceiro";
            this.ptbFinanceiro.Size = new System.Drawing.Size(230, 230);
            this.ptbFinanceiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFinanceiro.TabIndex = 3;
            this.ptbFinanceiro.TabStop = false;
            this.ptbFinanceiro.Click += new System.EventHandler(this.ptbFinanceiro_Click);
            this.ptbFinanceiro.MouseLeave += new System.EventHandler(this.ptbFinanceiro_MouseLeave);
            this.ptbFinanceiro.MouseHover += new System.EventHandler(this.ptbFinanceiro_MouseHover);
            // 
            // ptbClientes
            // 
            this.ptbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbClientes.BackColor = System.Drawing.Color.Transparent;
            this.ptbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClientes.Image = global::AgendaMais.Properties.Resources.peaple__4__transparency;
            this.ptbClientes.Location = new System.Drawing.Point(834, 86);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(230, 230);
            this.ptbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClientes.TabIndex = 2;
            this.ptbClientes.TabStop = false;
            this.ptbClientes.Click += new System.EventHandler(this.ptbClientes_Click);
            this.ptbClientes.MouseLeave += new System.EventHandler(this.ptbClientes_MouseLeave);
            this.ptbClientes.MouseHover += new System.EventHandler(this.ptbClientes_MouseHover);
            // 
            // ptbAgendamento
            // 
            this.ptbAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.ptbAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAgendamento.Image = global::AgendaMais.Properties.Resources.calendary_transparency;
            this.ptbAgendamento.Location = new System.Drawing.Point(518, 86);
            this.ptbAgendamento.Name = "ptbAgendamento";
            this.ptbAgendamento.Size = new System.Drawing.Size(230, 230);
            this.ptbAgendamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgendamento.TabIndex = 1;
            this.ptbAgendamento.TabStop = false;
            this.ptbAgendamento.Click += new System.EventHandler(this.ptbAgendamento_Click);
            this.ptbAgendamento.MouseLeave += new System.EventHandler(this.ptbAgendamento_MouseLeave);
            this.ptbAgendamento.MouseHover += new System.EventHandler(this.ptbAgendamento_MouseHover);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(584, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "HOJE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(10, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 40);
            this.panel2.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(664, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "TEL./CEL.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(862, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "SERV./PROD.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(477, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "CLIENTE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(218, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ATENDENTE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "HORÁRIO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpAgendamentos
            // 
            this.flpAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpAgendamentos.AutoScroll = true;
            this.flpAgendamentos.BackColor = System.Drawing.Color.Transparent;
            this.flpAgendamentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAgendamentos.Location = new System.Drawing.Point(7, 457);
            this.flpAgendamentos.Name = "flpAgendamentos";
            this.flpAgendamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpAgendamentos.Size = new System.Drawing.Size(1248, 247);
            this.flpAgendamentos.TabIndex = 6;
            this.flpAgendamentos.WrapContents = false;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.AutoSize = true;
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.flpMenu.Controls.Add(this.panFinanceiro);
            this.flpMenu.Controls.Add(this.panAgenda);
            this.flpMenu.Controls.Add(this.panCadastros);
            this.flpMenu.Controls.Add(this.panConfiguracoes);
            this.flpMenu.Location = new System.Drawing.Point(-1, 6);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(1268, 34);
            this.flpMenu.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AgendaMais.Properties.Resources.Imagem2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 716);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptbFinanceiro);
            this.Controls.Add(this.ptbClientes);
            this.Controls.Add(this.ptbAgendamento);
            this.Controls.Add(this.flpAgendamentos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPrincipal";
            this.Text = "Agenda+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panConfiguracoes.ResumeLayout(false);
            this.panConfiguracoes.PerformLayout();
            this.panCadastros.ResumeLayout(false);
            this.panCadastros.PerformLayout();
            this.panAgenda.ResumeLayout(false);
            this.panAgenda.PerformLayout();
            this.panFinanceiro.ResumeLayout(false);
            this.panFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Label lblCadastros;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.PictureBox ptbAgendamento;
        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.PictureBox ptbFinanceiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panConfiguracoes;
        private System.Windows.Forms.Panel panCadastros;
        private System.Windows.Forms.Panel panAgenda;
        private System.Windows.Forms.Panel panFinanceiro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpAgendamentos;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Timer timer1;
    }
}


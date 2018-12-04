namespace AgendaMais
{
    partial class frPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPesquisa));
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.flpAgendamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panCancelar = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.panAbrir = new System.Windows.Forms.Panel();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.ptbExcluiCadastro = new System.Windows.Forms.PictureBox();
            this.flpAgendamentos.SuspendLayout();
            this.panCancelar.SuspendLayout();
            this.panAbrir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluiCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.Location = new System.Drawing.Point(54, 77);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(89, 24);
            this.lblGrupo.TabIndex = 66;
            this.lblGrupo.Text = "GRUPO:";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGrupo.Visible = false;
            // 
            // cbGrupo
            // 
            this.cbGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(149, 74);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(326, 32);
            this.cbGrupo.TabIndex = 65;
            this.cbGrupo.Visible = false;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // flpAgendamentos
            // 
            this.flpAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpAgendamentos.AutoScroll = true;
            this.flpAgendamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.flpAgendamentos.Controls.Add(this.textBox1);
            this.flpAgendamentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAgendamentos.Location = new System.Drawing.Point(57, 109);
            this.flpAgendamentos.Name = "flpAgendamentos";
            this.flpAgendamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpAgendamentos.Size = new System.Drawing.Size(724, 340);
            this.flpAgendamentos.TabIndex = 68;
            this.flpAgendamentos.WrapContents = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(681, 26);
            this.textBox1.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 39);
            this.label5.TabIndex = 67;
            this.label5.Text = "CADASTROS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCancelar
            // 
            this.panCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.panCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panCancelar.Controls.Add(this.lblCancelar);
            this.panCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCancelar.Location = new System.Drawing.Point(491, 455);
            this.panCancelar.Name = "panCancelar";
            this.panCancelar.Size = new System.Drawing.Size(142, 52);
            this.panCancelar.TabIndex = 64;
            this.panCancelar.Click += new System.EventHandler(this.panCancelar_Click);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(10, 13);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(124, 24);
            this.lblCancelar.TabIndex = 10;
            this.lblCancelar.Text = "CANCELAR";
            this.lblCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancelar.Click += new System.EventHandler(this.panCancelar_Click);
            // 
            // panAbrir
            // 
            this.panAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panAbrir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panAbrir.Controls.Add(this.lblAbrir);
            this.panAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panAbrir.Location = new System.Drawing.Point(639, 455);
            this.panAbrir.Name = "panAbrir";
            this.panAbrir.Size = new System.Drawing.Size(142, 52);
            this.panAbrir.TabIndex = 63;
            this.panAbrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // lblAbrir
            // 
            this.lblAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbrir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrir.ForeColor = System.Drawing.Color.White;
            this.lblAbrir.Location = new System.Drawing.Point(37, 14);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(68, 24);
            this.lblAbrir.TabIndex = 10;
            this.lblAbrir.Text = "ABRIR";
            this.lblAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // ptbExcluiCadastro
            // 
            this.ptbExcluiCadastro.BackColor = System.Drawing.Color.White;
            this.ptbExcluiCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcluiCadastro.Image = global::AgendaMais.Properties.Resources.remove;
            this.ptbExcluiCadastro.Location = new System.Drawing.Point(787, 109);
            this.ptbExcluiCadastro.Name = "ptbExcluiCadastro";
            this.ptbExcluiCadastro.Size = new System.Drawing.Size(32, 32);
            this.ptbExcluiCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcluiCadastro.TabIndex = 84;
            this.ptbExcluiCadastro.TabStop = false;
            this.ptbExcluiCadastro.Click += new System.EventHandler(this.ptbExcluiCadastro_Click);
            // 
            // frPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::AgendaMais.Properties.Resources.Cadastros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 529);
            this.Controls.Add(this.ptbExcluiCadastro);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.flpAgendamentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panCancelar);
            this.Controls.Add(this.panAbrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.flpAgendamentos.ResumeLayout(false);
            this.flpAgendamentos.PerformLayout();
            this.panCancelar.ResumeLayout(false);
            this.panCancelar.PerformLayout();
            this.panAbrir.ResumeLayout(false);
            this.panAbrir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluiCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.FlowLayoutPanel flpAgendamentos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panCancelar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Panel panAbrir;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.PictureBox ptbExcluiCadastro;
    }
}
namespace AgendaMais.Telas.Configurações
{
    partial class frAlterarSenha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAlterarSenha));
            this.panAlterar = new System.Windows.Forms.Panel();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panAlterar
            // 
            this.panAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.panAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panAlterar.Controls.Add(this.lblAlterar);
            this.panAlterar.Location = new System.Drawing.Point(216, 267);
            this.panAlterar.Name = "panAlterar";
            this.panAlterar.Size = new System.Drawing.Size(360, 52);
            this.panAlterar.TabIndex = 16;
            this.panAlterar.Click += new System.EventHandler(this.panAlterar_Click);
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.BackColor = System.Drawing.Color.Transparent;
            this.lblAlterar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.ForeColor = System.Drawing.Color.White;
            this.lblAlterar.Location = new System.Drawing.Point(140, 12);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(95, 24);
            this.lblAlterar.TabIndex = 10;
            this.lblAlterar.Text = "ALTERAR";
            this.lblAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlterar.Click += new System.EventHandler(this.panAlterar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Confirmação:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nova senha:";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmacao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacao.Location = new System.Drawing.Point(216, 230);
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.PasswordChar = '•';
            this.txtConfirmacao.Size = new System.Drawing.Size(360, 31);
            this.txtConfirmacao.TabIndex = 13;
            this.txtConfirmacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmacao_KeyUp);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNovaSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(216, 171);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '•';
            this.txtNovaSenha.Size = new System.Drawing.Size(360, 31);
            this.txtNovaSenha.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Senha atual:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(216, 112);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '•';
            this.txtSenhaAtual.Size = new System.Drawing.Size(360, 31);
            this.txtSenhaAtual.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.panAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmacao);
            this.Controls.Add(this.txtNovaSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.panAlterar.ResumeLayout(false);
            this.panAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panAlterar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmacao;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
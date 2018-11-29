namespace AgendaMais
{
    partial class frCadFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadFuncionarios));
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.ptbAgenda = new System.Windows.Forms.PictureBox();
            this.ptbFinanceiro = new System.Windows.Forms.PictureBox();
            this.panDados = new System.Windows.Forms.Panel();
            this.ptbProximo = new System.Windows.Forms.PictureBox();
            this.ptbAnterior = new System.Windows.Forms.PictureBox();
            this.panCancelar = new System.Windows.Forms.Panel();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.panSalvar = new System.Windows.Forms.Panel();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.ptbImagemFuncionario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mkbTelCel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).BeginInit();
            this.panDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnterior)).BeginInit();
            this.panCancelar.SuspendLayout();
            this.panSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbClientes
            // 
            this.ptbClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbClientes.BackColor = System.Drawing.Color.Transparent;
            this.ptbClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbClientes.Image = global::AgendaMais.Properties.Resources.peaple__4__transparency;
            this.ptbClientes.Location = new System.Drawing.Point(730, 611);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(84, 84);
            this.ptbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClientes.TabIndex = 23;
            this.ptbClientes.TabStop = false;
            // 
            // ptbAgenda
            // 
            this.ptbAgenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbAgenda.BackColor = System.Drawing.Color.Transparent;
            this.ptbAgenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbAgenda.Image = global::AgendaMais.Properties.Resources.calendary_transparency;
            this.ptbAgenda.Location = new System.Drawing.Point(591, 611);
            this.ptbAgenda.Name = "ptbAgenda";
            this.ptbAgenda.Size = new System.Drawing.Size(84, 84);
            this.ptbAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgenda.TabIndex = 22;
            this.ptbAgenda.TabStop = false;
            // 
            // ptbFinanceiro
            // 
            this.ptbFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.ptbFinanceiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbFinanceiro.Image = global::AgendaMais.Properties.Resources.money__4__tranparency;
            this.ptbFinanceiro.Location = new System.Drawing.Point(452, 611);
            this.ptbFinanceiro.Name = "ptbFinanceiro";
            this.ptbFinanceiro.Size = new System.Drawing.Size(84, 84);
            this.ptbFinanceiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFinanceiro.TabIndex = 21;
            this.ptbFinanceiro.TabStop = false;
            // 
            // panDados
            // 
            this.panDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panDados.Controls.Add(this.ptbProximo);
            this.panDados.Controls.Add(this.ptbAnterior);
            this.panDados.Controls.Add(this.panCancelar);
            this.panDados.Controls.Add(this.panSalvar);
            this.panDados.Controls.Add(this.ptbImagemFuncionario);
            this.panDados.Controls.Add(this.panel1);
            this.panDados.Controls.Add(this.txtComplemento);
            this.panDados.Controls.Add(this.label12);
            this.panDados.Controls.Add(this.txtCidade);
            this.panDados.Controls.Add(this.label11);
            this.panDados.Controls.Add(this.txtNr);
            this.panDados.Controls.Add(this.label10);
            this.panDados.Controls.Add(this.txtBairro);
            this.panDados.Controls.Add(this.label9);
            this.panDados.Controls.Add(this.label8);
            this.panDados.Controls.Add(this.txtRG);
            this.panDados.Controls.Add(this.mkbCPF);
            this.panDados.Controls.Add(this.txtEndereco);
            this.panDados.Controls.Add(this.label7);
            this.panDados.Controls.Add(this.label6);
            this.panDados.Controls.Add(this.txtEmail);
            this.panDados.Controls.Add(this.label13);
            this.panDados.Controls.Add(this.label14);
            this.panDados.Controls.Add(this.label5);
            this.panDados.Controls.Add(this.mkbTelCel);
            this.panDados.Controls.Add(this.label3);
            this.panDados.Controls.Add(this.txtNome);
            this.panDados.Controls.Add(this.label2);
            this.panDados.Controls.Add(this.label4);
            this.panDados.Location = new System.Drawing.Point(63, 119);
            this.panDados.Name = "panDados";
            this.panDados.Size = new System.Drawing.Size(1138, 486);
            this.panDados.TabIndex = 20;
            // 
            // ptbProximo
            // 
            this.ptbProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbProximo.BackColor = System.Drawing.Color.Transparent;
            this.ptbProximo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbProximo.Image = global::AgendaMais.Properties.Resources.proximo;
            this.ptbProximo.Location = new System.Drawing.Point(380, 84);
            this.ptbProximo.Name = "ptbProximo";
            this.ptbProximo.Size = new System.Drawing.Size(53, 120);
            this.ptbProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProximo.TabIndex = 20;
            this.ptbProximo.TabStop = false;
            this.ptbProximo.Click += new System.EventHandler(this.ptbProximo_Click);
            this.ptbProximo.MouseLeave += new System.EventHandler(this.ptbProximo_MouseLeave);
            this.ptbProximo.MouseHover += new System.EventHandler(this.ptbProximo_MouseHover);
            // 
            // ptbAnterior
            // 
            this.ptbAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbAnterior.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnterior.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbAnterior.Image = global::AgendaMais.Properties.Resources.anterior;
            this.ptbAnterior.Location = new System.Drawing.Point(152, 84);
            this.ptbAnterior.Name = "ptbAnterior";
            this.ptbAnterior.Size = new System.Drawing.Size(53, 120);
            this.ptbAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnterior.TabIndex = 19;
            this.ptbAnterior.TabStop = false;
            this.ptbAnterior.Click += new System.EventHandler(this.ptbAnterior_Click);
            this.ptbAnterior.MouseLeave += new System.EventHandler(this.ptbAnterior_MouseLeave);
            this.ptbAnterior.MouseHover += new System.EventHandler(this.ptbAnterior_MouseHover);
            // 
            // panCancelar
            // 
            this.panCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.panCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panCancelar.Controls.Add(this.lblCancelar);
            this.panCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCancelar.Location = new System.Drawing.Point(835, 425);
            this.panCancelar.Name = "panCancelar";
            this.panCancelar.Size = new System.Drawing.Size(142, 52);
            this.panCancelar.TabIndex = 54;
            this.panCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
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
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // panSalvar
            // 
            this.panSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panSalvar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panSalvar.Controls.Add(this.lblSalvar);
            this.panSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panSalvar.Location = new System.Drawing.Point(983, 425);
            this.panSalvar.Name = "panSalvar";
            this.panSalvar.Size = new System.Drawing.Size(142, 52);
            this.panSalvar.TabIndex = 53;
            this.panSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // lblSalvar
            // 
            this.lblSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.BackColor = System.Drawing.Color.Transparent;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvar.ForeColor = System.Drawing.Color.White;
            this.lblSalvar.Location = new System.Drawing.Point(29, 14);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(88, 24);
            this.lblSalvar.TabIndex = 10;
            this.lblSalvar.Text = "SALVAR";
            this.lblSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // ptbImagemFuncionario
            // 
            this.ptbImagemFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.ptbImagemFuncionario.BackgroundImage = global::AgendaMais.Properties.Resources.perfil;
            this.ptbImagemFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagemFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImagemFuncionario.InitialImage = null;
            this.ptbImagemFuncionario.Location = new System.Drawing.Point(211, 59);
            this.ptbImagemFuncionario.Name = "ptbImagemFuncionario";
            this.ptbImagemFuncionario.Size = new System.Drawing.Size(163, 169);
            this.ptbImagemFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagemFuncionario.TabIndex = 52;
            this.ptbImagemFuncionario.TabStop = false;
            this.ptbImagemFuncionario.Click += new System.EventHandler(this.ptbImagemFuncionario_Click);
            this.ptbImagemFuncionario.MouseLeave += new System.EventHandler(this.ptbImagemFuncionario_MouseLeave);
            this.ptbImagemFuncionario.MouseHover += new System.EventHandler(this.ptbImagemFuncionario_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(567, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 467);
            this.panel1.TabIndex = 51;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(678, 322);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(441, 26);
            this.txtComplemento.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(582, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "COMP.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(678, 282);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(441, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(582, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "CIDADE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNr
            // 
            this.txtNr.BackColor = System.Drawing.Color.White;
            this.txtNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNr.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNr.ForeColor = System.Drawing.Color.Black;
            this.txtNr.Location = new System.Drawing.Point(1010, 242);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(109, 26);
            this.txtNr.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(970, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "N°";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(678, 242);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(286, 26);
            this.txtBairro.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(582, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "BAIRRO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(827, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "RG";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(874, 162);
            this.txtRG.Mask = "00,000,000-aa";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(126, 31);
            this.txtRG.TabIndex = 4;
            this.txtRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkbCPF
            // 
            this.mkbCPF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCPF.Location = new System.Drawing.Point(678, 161);
            this.mkbCPF.Mask = "000,000,000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(133, 31);
            this.mkbCPF.TabIndex = 3;
            this.mkbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(678, 202);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(441, 26);
            this.txtEndereco.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(582, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "END.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(582, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "CPF";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(678, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(441, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(582, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 24);
            this.label13.TabIndex = 43;
            this.label13.Text = "E-MAIL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(582, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 24);
            this.label14.TabIndex = 42;
            this.label14.Text = "DADOS GERAIS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "FUNCIONÁRIOS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mkbTelCel
            // 
            this.mkbTelCel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelCel.Location = new System.Drawing.Point(127, 317);
            this.mkbTelCel.Mask = "(00) 00000-0000";
            this.mkbTelCel.Name = "mkbTelCel";
            this.mkbTelCel.Size = new System.Drawing.Size(152, 31);
            this.mkbTelCel.TabIndex = 1;
            this.mkbTelCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "TEL / CEL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(127, 282);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(415, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "DADOS OBRIGATÓRIOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 77);
            this.label1.TabIndex = 19;
            this.label1.Text = "CADASTROS";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            this.openFileDialog.Title = "Importar Imagem";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frCadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::AgendaMais.Properties.Resources.Cadastros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 716);
            this.Controls.Add(this.ptbClientes);
            this.Controls.Add(this.ptbAgenda);
            this.Controls.Add(this.ptbFinanceiro);
            this.Controls.Add(this.panDados);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).EndInit();
            this.panDados.ResumeLayout(false);
            this.panDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnterior)).EndInit();
            this.panCancelar.ResumeLayout(false);
            this.panCancelar.PerformLayout();
            this.panSalvar.ResumeLayout(false);
            this.panSalvar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.PictureBox ptbAgenda;
        private System.Windows.Forms.PictureBox ptbFinanceiro;
        private System.Windows.Forms.Panel panDados;
        private System.Windows.Forms.PictureBox ptbProximo;
        private System.Windows.Forms.PictureBox ptbAnterior;
        private System.Windows.Forms.Panel panCancelar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Panel panSalvar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.PictureBox ptbImagemFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mkbTelCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
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
            this.ptbRelatorios = new System.Windows.Forms.PictureBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbConfirmar = new System.Windows.Forms.PictureBox();
            this.cbSerProd = new System.Windows.Forms.ComboBox();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtAtendente = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panConfiguracoes = new System.Windows.Forms.Panel();
            this.lblConfiguracoes = new System.Windows.Forms.Label();
            this.panRelatorios = new System.Windows.Forms.Panel();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.panCadastros = new System.Windows.Forms.Panel();
            this.lblCadastros = new System.Windows.Forms.Label();
            this.panAgenda = new System.Windows.Forms.Panel();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panNotificacao = new System.Windows.Forms.Panel();
            this.panDRE = new System.Windows.Forms.Panel();
            this.lblDRE = new System.Windows.Forms.Label();
            this.panFreqAgendamento = new System.Windows.Forms.Panel();
            this.lblFreqAgendamento = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panMenuRelatorios = new System.Windows.Forms.Panel();
            this.panMenuCadastros = new System.Windows.Forms.Panel();
            this.panCadProdServ = new System.Windows.Forms.Panel();
            this.lblCadProdServ = new System.Windows.Forms.Label();
            this.panCadFuncionarios = new System.Windows.Forms.Panel();
            this.lblCadFuncionarios = new System.Windows.Forms.Label();
            this.panCadClientes = new System.Windows.Forms.Panel();
            this.lblCadClientes = new System.Windows.Forms.Label();
            this.panMenuConfiguracoes = new System.Windows.Forms.Panel();
            this.panAlterarSenha = new System.Windows.Forms.Panel();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.flpMenuNotificacao = new System.Windows.Forms.FlowLayoutPanel();
            this.panNotificacaoMsg = new System.Windows.Forms.Panel();
            this.lblNotificacaoMsg = new System.Windows.Forms.Label();
            this.lblNaoHaNotificacoes = new System.Windows.Forms.Label();
            this.panNaoHaNotificacoes = new System.Windows.Forms.Panel();
            this.lblFecharNotificacaoMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpAgendamentos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).BeginInit();
            this.panConfiguracoes.SuspendLayout();
            this.panRelatorios.SuspendLayout();
            this.panCadastros.SuspendLayout();
            this.panAgenda.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panDRE.SuspendLayout();
            this.panFreqAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panMenuRelatorios.SuspendLayout();
            this.panMenuCadastros.SuspendLayout();
            this.panCadProdServ.SuspendLayout();
            this.panCadFuncionarios.SuspendLayout();
            this.panCadClientes.SuspendLayout();
            this.panMenuConfiguracoes.SuspendLayout();
            this.panAlterarSenha.SuspendLayout();
            this.flpMenuNotificacao.SuspendLayout();
            this.panNotificacaoMsg.SuspendLayout();
            this.panNaoHaNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbRelatorios
            // 
            this.ptbRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.ptbRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbRelatorios.Image = global::AgendaMais.Properties.Resources.Relatorios_transparency;
            this.ptbRelatorios.Location = new System.Drawing.Point(202, 86);
            this.ptbRelatorios.Name = "ptbRelatorios";
            this.ptbRelatorios.Size = new System.Drawing.Size(230, 230);
            this.ptbRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRelatorios.TabIndex = 3;
            this.ptbRelatorios.TabStop = false;
            this.ptbRelatorios.Click += new System.EventHandler(this.ptbRelatorios_Click);
            this.ptbRelatorios.MouseEnter += new System.EventHandler(this.ptbRelatorios_MouseEnter);
            this.ptbRelatorios.MouseLeave += new System.EventHandler(this.ptbRelatorios_MouseLeave);
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
            this.ptbClientes.MouseEnter += new System.EventHandler(this.ptbClientes_MouseEnter);
            this.ptbClientes.MouseLeave += new System.EventHandler(this.ptbClientes_MouseLeave);
            // 
            // ptbAgendamento
            // 
            this.ptbAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.ptbAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("ptbAgendamento.Image")));
            this.ptbAgendamento.Location = new System.Drawing.Point(518, 86);
            this.ptbAgendamento.Name = "ptbAgendamento";
            this.ptbAgendamento.Size = new System.Drawing.Size(230, 230);
            this.ptbAgendamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgendamento.TabIndex = 1;
            this.ptbAgendamento.TabStop = false;
            this.ptbAgendamento.Click += new System.EventHandler(this.ptbAgendamento_Click);
            this.ptbAgendamento.MouseEnter += new System.EventHandler(this.ptbAgendamento_MouseEnter);
            this.ptbAgendamento.MouseLeave += new System.EventHandler(this.ptbAgendamento_MouseLeave);
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
            this.flpAgendamentos.Controls.Add(this.panel1);
            this.flpAgendamentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAgendamentos.Location = new System.Drawing.Point(7, 457);
            this.flpAgendamentos.Name = "flpAgendamentos";
            this.flpAgendamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpAgendamentos.Size = new System.Drawing.Size(1248, 247);
            this.flpAgendamentos.TabIndex = 6;
            this.flpAgendamentos.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptbCancelar);
            this.panel1.Controls.Add(this.ptbConfirmar);
            this.panel1.Controls.Add(this.cbSerProd);
            this.panel1.Controls.Add(this.txtTelCel);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.txtAtendente);
            this.panel1.Controls.Add(this.txtHorario);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 40);
            this.panel1.TabIndex = 0;
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(1180, 3);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(34, 34);
            this.ptbCancelar.TabIndex = 6;
            this.ptbCancelar.TabStop = false;
            // 
            // ptbConfirmar
            // 
            this.ptbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ptbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbConfirmar.Location = new System.Drawing.Point(1142, 3);
            this.ptbConfirmar.Name = "ptbConfirmar";
            this.ptbConfirmar.Size = new System.Drawing.Size(34, 34);
            this.ptbConfirmar.TabIndex = 5;
            this.ptbConfirmar.TabStop = false;
            // 
            // cbSerProd
            // 
            this.cbSerProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSerProd.BackColor = System.Drawing.Color.White;
            this.cbSerProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSerProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerProd.FormattingEnabled = true;
            this.cbSerProd.Items.AddRange(new object[] {
            "CORTE",
            "BARBA"});
            this.cbSerProd.Location = new System.Drawing.Point(813, 5);
            this.cbSerProd.Name = "cbSerProd";
            this.cbSerProd.Size = new System.Drawing.Size(313, 30);
            this.cbSerProd.TabIndex = 4;
            // 
            // txtTelCel
            // 
            this.txtTelCel.BackColor = System.Drawing.Color.White;
            this.txtTelCel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelCel.Enabled = false;
            this.txtTelCel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCel.ForeColor = System.Drawing.Color.Black;
            this.txtTelCel.Location = new System.Drawing.Point(628, 8);
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.ReadOnly = true;
            this.txtTelCel.Size = new System.Drawing.Size(165, 24);
            this.txtTelCel.TabIndex = 3;
            this.txtTelCel.Text = "(11) 97361-3079";
            this.txtTelCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(410, 8);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(212, 24);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.Text = "DOUGLAS";
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtendente
            // 
            this.txtAtendente.BackColor = System.Drawing.Color.White;
            this.txtAtendente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtendente.Enabled = false;
            this.txtAtendente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtendente.ForeColor = System.Drawing.Color.Black;
            this.txtAtendente.Location = new System.Drawing.Point(129, 8);
            this.txtAtendente.Name = "txtAtendente";
            this.txtAtendente.ReadOnly = true;
            this.txtAtendente.Size = new System.Drawing.Size(275, 24);
            this.txtAtendente.TabIndex = 1;
            this.txtAtendente.Text = "WILLIAM";
            this.txtAtendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.Color.White;
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorario.Enabled = false;
            this.txtHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.ForeColor = System.Drawing.Color.Black;
            this.txtHorario.Location = new System.Drawing.Point(31, 8);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(92, 24);
            this.txtHorario.TabIndex = 0;
            this.txtHorario.Text = "10:30";
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panConfiguracoes
            // 
            this.panConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.panConfiguracoes.Controls.Add(this.lblConfiguracoes);
            this.panConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panConfiguracoes.Location = new System.Drawing.Point(940, 3);
            this.panConfiguracoes.Name = "panConfiguracoes";
            this.panConfiguracoes.Size = new System.Drawing.Size(295, 28);
            this.panConfiguracoes.TabIndex = 7;
            this.panConfiguracoes.Click += new System.EventHandler(this.lblConfiguracoes_Click);
            this.panConfiguracoes.MouseEnter += new System.EventHandler(this.panConfiguracoes_MouseEnter);
            this.panConfiguracoes.MouseLeave += new System.EventHandler(this.panConfiguracoes_MouseLeave);
            // 
            // lblConfiguracoes
            // 
            this.lblConfiguracoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfiguracoes.AutoSize = true;
            this.lblConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.lblConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracoes.Location = new System.Drawing.Point(59, 3);
            this.lblConfiguracoes.Name = "lblConfiguracoes";
            this.lblConfiguracoes.Size = new System.Drawing.Size(177, 22);
            this.lblConfiguracoes.TabIndex = 3;
            this.lblConfiguracoes.Text = "CONFIGURAÇÕES";
            this.lblConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfiguracoes.Click += new System.EventHandler(this.lblConfiguracoes_Click);
            this.lblConfiguracoes.MouseEnter += new System.EventHandler(this.panConfiguracoes_MouseEnter);
            this.lblConfiguracoes.MouseLeave += new System.EventHandler(this.panConfiguracoes_MouseLeave);
            // 
            // panRelatorios
            // 
            this.panRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panRelatorios.Controls.Add(this.lblRelatorios);
            this.panRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panRelatorios.Location = new System.Drawing.Point(639, 3);
            this.panRelatorios.Name = "panRelatorios";
            this.panRelatorios.Size = new System.Drawing.Size(295, 28);
            this.panRelatorios.TabIndex = 4;
            this.panRelatorios.Click += new System.EventHandler(this.panRelatorios_Click);
            this.panRelatorios.MouseEnter += new System.EventHandler(this.panRelatorios_MouseEnter);
            this.panRelatorios.MouseLeave += new System.EventHandler(this.panRelatorios_MouseLeave);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.lblRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRelatorios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.ForeColor = System.Drawing.Color.White;
            this.lblRelatorios.Location = new System.Drawing.Point(85, 3);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(124, 22);
            this.lblRelatorios.TabIndex = 0;
            this.lblRelatorios.Text = "RELATÓRIOS";
            this.lblRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRelatorios.Click += new System.EventHandler(this.panRelatorios_Click);
            this.lblRelatorios.MouseEnter += new System.EventHandler(this.panRelatorios_MouseEnter);
            this.lblRelatorios.MouseLeave += new System.EventHandler(this.panRelatorios_MouseLeave);
            // 
            // panCadastros
            // 
            this.panCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastros.BackColor = System.Drawing.Color.Transparent;
            this.panCadastros.Controls.Add(this.lblCadastros);
            this.panCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadastros.Location = new System.Drawing.Point(338, 3);
            this.panCadastros.Name = "panCadastros";
            this.panCadastros.Size = new System.Drawing.Size(295, 28);
            this.panCadastros.TabIndex = 6;
            this.panCadastros.Click += new System.EventHandler(this.Cadastros_Click);
            this.panCadastros.MouseEnter += new System.EventHandler(this.panCadastros_MouseEnter);
            this.panCadastros.MouseLeave += new System.EventHandler(this.panCadastros_MouseLeave);
            // 
            // lblCadastros
            // 
            this.lblCadastros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastros.AutoSize = true;
            this.lblCadastros.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastros.ForeColor = System.Drawing.Color.White;
            this.lblCadastros.Location = new System.Drawing.Point(86, 3);
            this.lblCadastros.Name = "lblCadastros";
            this.lblCadastros.Size = new System.Drawing.Size(124, 22);
            this.lblCadastros.TabIndex = 2;
            this.lblCadastros.Text = "CADASTROS";
            this.lblCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastros.Click += new System.EventHandler(this.Cadastros_Click);
            this.lblCadastros.MouseEnter += new System.EventHandler(this.panCadastros_MouseEnter);
            this.lblCadastros.MouseLeave += new System.EventHandler(this.panCadastros_MouseLeave);
            // 
            // panAgenda
            // 
            this.panAgenda.BackColor = System.Drawing.Color.Transparent;
            this.panAgenda.Controls.Add(this.lblAgenda);
            this.panAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panAgenda.Location = new System.Drawing.Point(37, 3);
            this.panAgenda.Name = "panAgenda";
            this.panAgenda.Size = new System.Drawing.Size(295, 28);
            this.panAgenda.TabIndex = 5;
            this.panAgenda.Click += new System.EventHandler(this.panAgenda_Click);
            this.panAgenda.MouseEnter += new System.EventHandler(this.panAgenda_MouseEnter);
            this.panAgenda.MouseLeave += new System.EventHandler(this.panAgenda_MouseLeave);
            // 
            // lblAgenda
            // 
            this.lblAgenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgenda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.White;
            this.lblAgenda.Location = new System.Drawing.Point(100, 3);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(95, 22);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "AGENDA";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgenda.Click += new System.EventHandler(this.panAgenda_Click);
            this.lblAgenda.MouseEnter += new System.EventHandler(this.panAgenda_MouseEnter);
            this.lblAgenda.MouseLeave += new System.EventHandler(this.panAgenda_MouseLeave);
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.AutoSize = true;
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.flpMenu.Controls.Add(this.panNotificacao);
            this.flpMenu.Controls.Add(this.panAgenda);
            this.flpMenu.Controls.Add(this.panCadastros);
            this.flpMenu.Controls.Add(this.panRelatorios);
            this.flpMenu.Controls.Add(this.panConfiguracoes);
            this.flpMenu.Location = new System.Drawing.Point(0, 6);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(1268, 34);
            this.flpMenu.TabIndex = 7;
            // 
            // panNotificacao
            // 
            this.panNotificacao.BackColor = System.Drawing.Color.Transparent;
            this.panNotificacao.BackgroundImage = global::AgendaMais.Properties.Resources.notificacao1;
            this.panNotificacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panNotificacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panNotificacao.Location = new System.Drawing.Point(3, 3);
            this.panNotificacao.Name = "panNotificacao";
            this.panNotificacao.Size = new System.Drawing.Size(28, 28);
            this.panNotificacao.TabIndex = 14;
            this.panNotificacao.Click += new System.EventHandler(this.panNotificacao_Click);
            this.panNotificacao.MouseEnter += new System.EventHandler(this.panNotificacao_MouseEnter);
            this.panNotificacao.MouseLeave += new System.EventHandler(this.panNotificacao_MouseLeave);
            // 
            // panDRE
            // 
            this.panDRE.BackColor = System.Drawing.Color.Transparent;
            this.panDRE.Controls.Add(this.lblDRE);
            this.panDRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panDRE.Location = new System.Drawing.Point(0, 29);
            this.panDRE.Name = "panDRE";
            this.panDRE.Size = new System.Drawing.Size(292, 28);
            this.panDRE.TabIndex = 9;
            this.panDRE.Click += new System.EventHandler(this.panDRE_Click);
            this.panDRE.MouseEnter += new System.EventHandler(this.panDRE_MouseEnter);
            this.panDRE.MouseLeave += new System.EventHandler(this.panDRE_MouseLeave);
            // 
            // lblDRE
            // 
            this.lblDRE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDRE.AutoSize = true;
            this.lblDRE.BackColor = System.Drawing.Color.Transparent;
            this.lblDRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDRE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRE.ForeColor = System.Drawing.Color.White;
            this.lblDRE.Location = new System.Drawing.Point(3, 4);
            this.lblDRE.Name = "lblDRE";
            this.lblDRE.Size = new System.Drawing.Size(216, 20);
            this.lblDRE.TabIndex = 1;
            this.lblDRE.Text = "Demonstrativo de Resultado";
            this.lblDRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDRE.Click += new System.EventHandler(this.panDRE_Click);
            this.lblDRE.MouseEnter += new System.EventHandler(this.panDRE_MouseEnter);
            this.lblDRE.MouseLeave += new System.EventHandler(this.panDRE_MouseLeave);
            // 
            // panFreqAgendamento
            // 
            this.panFreqAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.panFreqAgendamento.Controls.Add(this.lblFreqAgendamento);
            this.panFreqAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panFreqAgendamento.Location = new System.Drawing.Point(0, 1);
            this.panFreqAgendamento.Name = "panFreqAgendamento";
            this.panFreqAgendamento.Size = new System.Drawing.Size(292, 28);
            this.panFreqAgendamento.TabIndex = 8;
            this.panFreqAgendamento.Click += new System.EventHandler(this.panFreqAgendamento_Click);
            this.panFreqAgendamento.MouseEnter += new System.EventHandler(this.panFreqAgendamento_MouseEnter);
            this.panFreqAgendamento.MouseLeave += new System.EventHandler(this.panFreqAgendamento_MouseLeave);
            // 
            // lblFreqAgendamento
            // 
            this.lblFreqAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFreqAgendamento.AutoSize = true;
            this.lblFreqAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFreqAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFreqAgendamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreqAgendamento.ForeColor = System.Drawing.Color.White;
            this.lblFreqAgendamento.Location = new System.Drawing.Point(3, 3);
            this.lblFreqAgendamento.Name = "lblFreqAgendamento";
            this.lblFreqAgendamento.Size = new System.Drawing.Size(227, 20);
            this.lblFreqAgendamento.TabIndex = 0;
            this.lblFreqAgendamento.Text = "Frequência de Agendamento";
            this.lblFreqAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFreqAgendamento.Click += new System.EventHandler(this.panFreqAgendamento_Click);
            this.lblFreqAgendamento.MouseEnter += new System.EventHandler(this.panFreqAgendamento_MouseEnter);
            this.lblFreqAgendamento.MouseLeave += new System.EventHandler(this.panFreqAgendamento_MouseLeave);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panMenuRelatorios
            // 
            this.panMenuRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panMenuRelatorios.Controls.Add(this.panDRE);
            this.panMenuRelatorios.Controls.Add(this.panFreqAgendamento);
            this.panMenuRelatorios.Location = new System.Drawing.Point(639, 40);
            this.panMenuRelatorios.Name = "panMenuRelatorios";
            this.panMenuRelatorios.Size = new System.Drawing.Size(295, 58);
            this.panMenuRelatorios.TabIndex = 11;
            this.panMenuRelatorios.Visible = false;
            // 
            // panMenuCadastros
            // 
            this.panMenuCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panMenuCadastros.Controls.Add(this.panCadProdServ);
            this.panMenuCadastros.Controls.Add(this.panCadFuncionarios);
            this.panMenuCadastros.Controls.Add(this.panCadClientes);
            this.panMenuCadastros.Location = new System.Drawing.Point(338, 40);
            this.panMenuCadastros.Name = "panMenuCadastros";
            this.panMenuCadastros.Size = new System.Drawing.Size(295, 87);
            this.panMenuCadastros.TabIndex = 12;
            this.panMenuCadastros.Visible = false;
            // 
            // panCadProdServ
            // 
            this.panCadProdServ.BackColor = System.Drawing.Color.Transparent;
            this.panCadProdServ.Controls.Add(this.lblCadProdServ);
            this.panCadProdServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadProdServ.Location = new System.Drawing.Point(0, 59);
            this.panCadProdServ.Name = "panCadProdServ";
            this.panCadProdServ.Size = new System.Drawing.Size(295, 28);
            this.panCadProdServ.TabIndex = 10;
            this.panCadProdServ.Click += new System.EventHandler(this.panCadProdServ_Click);
            this.panCadProdServ.MouseEnter += new System.EventHandler(this.panCadProdServ_MouseEnter);
            this.panCadProdServ.MouseLeave += new System.EventHandler(this.panCadProdServ_MouseLeave);
            // 
            // lblCadProdServ
            // 
            this.lblCadProdServ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadProdServ.AutoSize = true;
            this.lblCadProdServ.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProdServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadProdServ.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProdServ.ForeColor = System.Drawing.Color.White;
            this.lblCadProdServ.Location = new System.Drawing.Point(3, 4);
            this.lblCadProdServ.Name = "lblCadProdServ";
            this.lblCadProdServ.Size = new System.Drawing.Size(152, 20);
            this.lblCadProdServ.TabIndex = 1;
            this.lblCadProdServ.Text = "Produtos e Serviços";
            this.lblCadProdServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadProdServ.Click += new System.EventHandler(this.panCadProdServ_Click);
            this.lblCadProdServ.MouseEnter += new System.EventHandler(this.panCadProdServ_MouseEnter);
            this.lblCadProdServ.MouseLeave += new System.EventHandler(this.panCadProdServ_MouseLeave);
            // 
            // panCadFuncionarios
            // 
            this.panCadFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.panCadFuncionarios.Controls.Add(this.lblCadFuncionarios);
            this.panCadFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadFuncionarios.Location = new System.Drawing.Point(0, 29);
            this.panCadFuncionarios.Name = "panCadFuncionarios";
            this.panCadFuncionarios.Size = new System.Drawing.Size(295, 28);
            this.panCadFuncionarios.TabIndex = 9;
            this.panCadFuncionarios.Click += new System.EventHandler(this.panCadFuncionarios_Click);
            this.panCadFuncionarios.MouseEnter += new System.EventHandler(this.panCadFuncionarios_MouseEnter);
            this.panCadFuncionarios.MouseLeave += new System.EventHandler(this.panCadFuncionarios_MouseLeave);
            // 
            // lblCadFuncionarios
            // 
            this.lblCadFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadFuncionarios.AutoSize = true;
            this.lblCadFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadFuncionarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFuncionarios.ForeColor = System.Drawing.Color.White;
            this.lblCadFuncionarios.Location = new System.Drawing.Point(3, 4);
            this.lblCadFuncionarios.Name = "lblCadFuncionarios";
            this.lblCadFuncionarios.Size = new System.Drawing.Size(100, 20);
            this.lblCadFuncionarios.TabIndex = 1;
            this.lblCadFuncionarios.Text = "Funcionários";
            this.lblCadFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadFuncionarios.Click += new System.EventHandler(this.panCadFuncionarios_Click);
            this.lblCadFuncionarios.MouseEnter += new System.EventHandler(this.panCadFuncionarios_MouseEnter);
            this.lblCadFuncionarios.MouseLeave += new System.EventHandler(this.panCadFuncionarios_MouseLeave);
            // 
            // panCadClientes
            // 
            this.panCadClientes.BackColor = System.Drawing.Color.Transparent;
            this.panCadClientes.Controls.Add(this.lblCadClientes);
            this.panCadClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadClientes.Location = new System.Drawing.Point(0, 1);
            this.panCadClientes.Name = "panCadClientes";
            this.panCadClientes.Size = new System.Drawing.Size(295, 28);
            this.panCadClientes.TabIndex = 8;
            this.panCadClientes.Click += new System.EventHandler(this.panCadClientes_Click);
            this.panCadClientes.MouseEnter += new System.EventHandler(this.panCadClientes_MouseEnter);
            this.panCadClientes.MouseLeave += new System.EventHandler(this.panCadClientes_MouseLeave);
            // 
            // lblCadClientes
            // 
            this.lblCadClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadClientes.AutoSize = true;
            this.lblCadClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblCadClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadClientes.ForeColor = System.Drawing.Color.White;
            this.lblCadClientes.Location = new System.Drawing.Point(3, 3);
            this.lblCadClientes.Name = "lblCadClientes";
            this.lblCadClientes.Size = new System.Drawing.Size(67, 20);
            this.lblCadClientes.TabIndex = 0;
            this.lblCadClientes.Text = "Clientes";
            this.lblCadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadClientes.Click += new System.EventHandler(this.panCadClientes_Click);
            this.lblCadClientes.MouseEnter += new System.EventHandler(this.panCadClientes_MouseEnter);
            this.lblCadClientes.MouseLeave += new System.EventHandler(this.panCadClientes_MouseLeave);
            // 
            // panMenuConfiguracoes
            // 
            this.panMenuConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panMenuConfiguracoes.Controls.Add(this.panAlterarSenha);
            this.panMenuConfiguracoes.Location = new System.Drawing.Point(940, 40);
            this.panMenuConfiguracoes.Name = "panMenuConfiguracoes";
            this.panMenuConfiguracoes.Size = new System.Drawing.Size(295, 29);
            this.panMenuConfiguracoes.TabIndex = 13;
            this.panMenuConfiguracoes.Visible = false;
            // 
            // panAlterarSenha
            // 
            this.panAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.panAlterarSenha.Controls.Add(this.lblAlterarSenha);
            this.panAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panAlterarSenha.Location = new System.Drawing.Point(3, 1);
            this.panAlterarSenha.Name = "panAlterarSenha";
            this.panAlterarSenha.Size = new System.Drawing.Size(292, 28);
            this.panAlterarSenha.TabIndex = 8;
            this.panAlterarSenha.Click += new System.EventHandler(this.panAlterarSenha_Click);
            this.panAlterarSenha.MouseEnter += new System.EventHandler(this.panAlterarSenha_MouseEnter);
            this.panAlterarSenha.MouseLeave += new System.EventHandler(this.panAlterarSenha_MouseLeave);
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.lblAlterarSenha.Location = new System.Drawing.Point(-4, 3);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(106, 20);
            this.lblAlterarSenha.TabIndex = 0;
            this.lblAlterarSenha.Text = "Alterar senha";
            this.lblAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlterarSenha.Click += new System.EventHandler(this.panAlterarSenha_Click);
            this.lblAlterarSenha.MouseEnter += new System.EventHandler(this.panAlterarSenha_MouseEnter);
            this.lblAlterarSenha.MouseLeave += new System.EventHandler(this.panAlterarSenha_MouseLeave);
            // 
            // flpMenuNotificacao
            // 
            this.flpMenuNotificacao.AutoScroll = true;
            this.flpMenuNotificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.flpMenuNotificacao.Controls.Add(this.panNaoHaNotificacoes);
            this.flpMenuNotificacao.Controls.Add(this.panNotificacaoMsg);
            this.flpMenuNotificacao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenuNotificacao.Location = new System.Drawing.Point(0, 40);
            this.flpMenuNotificacao.Name = "flpMenuNotificacao";
            this.flpMenuNotificacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpMenuNotificacao.Size = new System.Drawing.Size(315, 153);
            this.flpMenuNotificacao.TabIndex = 14;
            this.flpMenuNotificacao.Visible = false;
            this.flpMenuNotificacao.WrapContents = false;
            // 
            // panNotificacaoMsg
            // 
            this.panNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            this.panNotificacaoMsg.Controls.Add(this.lblFecharNotificacaoMsg);
            this.panNotificacaoMsg.Controls.Add(this.lblNotificacaoMsg);
            this.panNotificacaoMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.panNotificacaoMsg.Location = new System.Drawing.Point(3, 58);
            this.panNotificacaoMsg.Name = "panNotificacaoMsg";
            this.panNotificacaoMsg.Size = new System.Drawing.Size(289, 62);
            this.panNotificacaoMsg.TabIndex = 15;
            // 
            // lblNotificacaoMsg
            // 
            this.lblNotificacaoMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotificacaoMsg.AutoSize = true;
            this.lblNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificacaoMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNotificacaoMsg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacaoMsg.ForeColor = System.Drawing.Color.White;
            this.lblNotificacaoMsg.Location = new System.Drawing.Point(3, 5);
            this.lblNotificacaoMsg.Name = "lblNotificacaoMsg";
            this.lblNotificacaoMsg.Size = new System.Drawing.Size(214, 51);
            this.lblNotificacaoMsg.TabIndex = 0;
            this.lblNotificacaoMsg.Text = "Passando pra avisar que você\r\ntem 10 clientes que precisam\r\nde uma atenção. Que t" +
    "al conferir?";
            this.lblNotificacaoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNaoHaNotificacoes
            // 
            this.lblNaoHaNotificacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaoHaNotificacoes.AutoSize = true;
            this.lblNaoHaNotificacoes.BackColor = System.Drawing.Color.Transparent;
            this.lblNaoHaNotificacoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNaoHaNotificacoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoHaNotificacoes.ForeColor = System.Drawing.Color.White;
            this.lblNaoHaNotificacoes.Location = new System.Drawing.Point(62, 5);
            this.lblNaoHaNotificacoes.Name = "lblNaoHaNotificacoes";
            this.lblNaoHaNotificacoes.Size = new System.Drawing.Size(162, 40);
            this.lblNaoHaNotificacoes.TabIndex = 0;
            this.lblNaoHaNotificacoes.Text = "Não há notificações \r\nno momento.";
            this.lblNaoHaNotificacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panNaoHaNotificacoes
            // 
            this.panNaoHaNotificacoes.BackColor = System.Drawing.Color.Transparent;
            this.panNaoHaNotificacoes.Controls.Add(this.lblNaoHaNotificacoes);
            this.panNaoHaNotificacoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.panNaoHaNotificacoes.Location = new System.Drawing.Point(3, 3);
            this.panNaoHaNotificacoes.Name = "panNaoHaNotificacoes";
            this.panNaoHaNotificacoes.Size = new System.Drawing.Size(289, 49);
            this.panNaoHaNotificacoes.TabIndex = 14;
            // 
            // lblFecharNotificacaoMsg
            // 
            this.lblFecharNotificacaoMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecharNotificacaoMsg.AutoSize = true;
            this.lblFecharNotificacaoMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblFecharNotificacaoMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFecharNotificacaoMsg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharNotificacaoMsg.ForeColor = System.Drawing.Color.White;
            this.lblFecharNotificacaoMsg.Location = new System.Drawing.Point(271, 5);
            this.lblFecharNotificacaoMsg.Name = "lblFecharNotificacaoMsg";
            this.lblFecharNotificacaoMsg.Size = new System.Drawing.Size(15, 17);
            this.lblFecharNotificacaoMsg.TabIndex = 1;
            this.lblFecharNotificacaoMsg.Text = "X";
            this.lblFecharNotificacaoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Controls.Add(this.flpMenuNotificacao);
            this.Controls.Add(this.panMenuConfiguracoes);
            this.Controls.Add(this.panMenuCadastros);
            this.Controls.Add(this.panMenuRelatorios);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptbRelatorios);
            this.Controls.Add(this.ptbClientes);
            this.Controls.Add(this.ptbAgendamento);
            this.Controls.Add(this.flpAgendamentos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frPrincipal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flpAgendamentos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).EndInit();
            this.panConfiguracoes.ResumeLayout(false);
            this.panConfiguracoes.PerformLayout();
            this.panRelatorios.ResumeLayout(false);
            this.panRelatorios.PerformLayout();
            this.panCadastros.ResumeLayout(false);
            this.panCadastros.PerformLayout();
            this.panAgenda.ResumeLayout(false);
            this.panAgenda.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.panDRE.ResumeLayout(false);
            this.panDRE.PerformLayout();
            this.panFreqAgendamento.ResumeLayout(false);
            this.panFreqAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panMenuRelatorios.ResumeLayout(false);
            this.panMenuCadastros.ResumeLayout(false);
            this.panCadProdServ.ResumeLayout(false);
            this.panCadProdServ.PerformLayout();
            this.panCadFuncionarios.ResumeLayout(false);
            this.panCadFuncionarios.PerformLayout();
            this.panCadClientes.ResumeLayout(false);
            this.panCadClientes.PerformLayout();
            this.panMenuConfiguracoes.ResumeLayout(false);
            this.panAlterarSenha.ResumeLayout(false);
            this.panAlterarSenha.PerformLayout();
            this.flpMenuNotificacao.ResumeLayout(false);
            this.panNotificacaoMsg.ResumeLayout(false);
            this.panNotificacaoMsg.PerformLayout();
            this.panNaoHaNotificacoes.ResumeLayout(false);
            this.panNaoHaNotificacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbAgendamento;
        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.PictureBox ptbRelatorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpAgendamentos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panConfiguracoes;
        private System.Windows.Forms.Label lblConfiguracoes;
        private System.Windows.Forms.Panel panRelatorios;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Panel panCadastros;
        private System.Windows.Forms.Label lblCadastros;
        private System.Windows.Forms.Panel panAgenda;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panDRE;
        private System.Windows.Forms.Label lblDRE;
        private System.Windows.Forms.Panel panFreqAgendamento;
        private System.Windows.Forms.Label lblFreqAgendamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtAtendente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtTelCel;
        private System.Windows.Forms.ComboBox cbSerProd;
        private System.Windows.Forms.PictureBox ptbConfirmar;
        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panMenuRelatorios;
        private System.Windows.Forms.Panel panCadProdServ;
        private System.Windows.Forms.Label lblCadProdServ;
        private System.Windows.Forms.Panel panMenuCadastros;
        private System.Windows.Forms.Panel panCadFuncionarios;
        private System.Windows.Forms.Label lblCadFuncionarios;
        private System.Windows.Forms.Panel panCadClientes;
        private System.Windows.Forms.Label lblCadClientes;
        private System.Windows.Forms.Panel panMenuConfiguracoes;
        private System.Windows.Forms.Panel panAlterarSenha;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Panel panNotificacao;
        private System.Windows.Forms.FlowLayoutPanel flpMenuNotificacao;
        private System.Windows.Forms.Panel panNaoHaNotificacoes;
        private System.Windows.Forms.Label lblNaoHaNotificacoes;
        private System.Windows.Forms.Panel panNotificacaoMsg;
        private System.Windows.Forms.Label lblFecharNotificacaoMsg;
        private System.Windows.Forms.Label lblNotificacaoMsg;
    }
}


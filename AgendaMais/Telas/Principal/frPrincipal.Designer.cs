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
            this.panDRE = new System.Windows.Forms.Panel();
            this.lblDRE = new System.Windows.Forms.Label();
            this.panFreqAgendamento = new System.Windows.Forms.Panel();
            this.lblFreqAgendamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtAtendente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.cbSerProd = new System.Windows.Forms.ComboBox();
            this.ptbConfirmar = new System.Windows.Forms.PictureBox();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ckbNotificar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).BeginInit();
            this.panel2.SuspendLayout();
            this.flpAgendamentos.SuspendLayout();
            this.panConfiguracoes.SuspendLayout();
            this.panRelatorios.SuspendLayout();
            this.panCadastros.SuspendLayout();
            this.panAgenda.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.panDRE.SuspendLayout();
            this.panFreqAgendamento.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
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
            this.ptbRelatorios.MouseLeave += new System.EventHandler(this.ptbRelatorios_MouseLeave);
            this.ptbRelatorios.MouseHover += new System.EventHandler(this.ptbRelatorios_MouseHover);
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
            this.flpAgendamentos.Controls.Add(this.panel1);
            this.flpAgendamentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAgendamentos.Location = new System.Drawing.Point(7, 457);
            this.flpAgendamentos.Name = "flpAgendamentos";
            this.flpAgendamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpAgendamentos.Size = new System.Drawing.Size(1248, 247);
            this.flpAgendamentos.TabIndex = 6;
            this.flpAgendamentos.WrapContents = false;
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
            // panRelatorios
            // 
            this.panRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panRelatorios.Controls.Add(this.lblRelatorios);
            this.panRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panRelatorios.Location = new System.Drawing.Point(637, 3);
            this.panRelatorios.Name = "panRelatorios";
            this.panRelatorios.Size = new System.Drawing.Size(311, 28);
            this.panRelatorios.TabIndex = 4;
            this.panRelatorios.Click += new System.EventHandler(this.panRelatorios_Click);
            this.panRelatorios.MouseLeave += new System.EventHandler(this.panRelatorios_MouseLeave);
            this.panRelatorios.MouseHover += new System.EventHandler(this.panRelatorios_MouseHover);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.lblRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRelatorios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorios.ForeColor = System.Drawing.Color.White;
            this.lblRelatorios.Location = new System.Drawing.Point(93, 3);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(124, 22);
            this.lblRelatorios.TabIndex = 0;
            this.lblRelatorios.Text = "RELATÓRIOS";
            this.lblRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRelatorios.Click += new System.EventHandler(this.panRelatorios_Click);
            this.lblRelatorios.MouseLeave += new System.EventHandler(this.panRelatorios_MouseLeave);
            this.lblRelatorios.MouseHover += new System.EventHandler(this.panRelatorios_MouseHover);
            // 
            // panCadastros
            // 
            this.panCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastros.BackColor = System.Drawing.Color.Transparent;
            this.panCadastros.Controls.Add(this.lblCadastros);
            this.panCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panCadastros.Location = new System.Drawing.Point(320, 3);
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
            this.panAgenda.Location = new System.Drawing.Point(3, 3);
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
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.AutoSize = true;
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.flpMenu.Controls.Add(this.panAgenda);
            this.flpMenu.Controls.Add(this.panCadastros);
            this.flpMenu.Controls.Add(this.panRelatorios);
            this.flpMenu.Controls.Add(this.panConfiguracoes);
            this.flpMenu.Location = new System.Drawing.Point(-1, 6);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(1268, 34);
            this.flpMenu.TabIndex = 7;
            // 
            // panDRE
            // 
            this.panDRE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panDRE.Controls.Add(this.lblDRE);
            this.panDRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panDRE.Location = new System.Drawing.Point(636, 68);
            this.panDRE.Name = "panDRE";
            this.panDRE.Size = new System.Drawing.Size(311, 28);
            this.panDRE.TabIndex = 9;
            this.panDRE.Visible = false;
            this.panDRE.Click += new System.EventHandler(this.panDRE_Click);
            this.panDRE.MouseLeave += new System.EventHandler(this.panDRE_MouseLeave);
            this.panDRE.MouseHover += new System.EventHandler(this.panDRE_MouseHover);
            // 
            // lblDRE
            // 
            this.lblDRE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDRE.AutoSize = true;
            this.lblDRE.BackColor = System.Drawing.Color.Transparent;
            this.lblDRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDRE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRE.ForeColor = System.Drawing.Color.White;
            this.lblDRE.Location = new System.Drawing.Point(5, 4);
            this.lblDRE.Name = "lblDRE";
            this.lblDRE.Size = new System.Drawing.Size(216, 20);
            this.lblDRE.TabIndex = 1;
            this.lblDRE.Text = "Demonstrativo de Resultado";
            this.lblDRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDRE.Click += new System.EventHandler(this.panDRE_Click);
            this.lblDRE.MouseLeave += new System.EventHandler(this.panDRE_MouseLeave);
            this.lblDRE.MouseHover += new System.EventHandler(this.panDRE_MouseHover);
            // 
            // panFreqAgendamento
            // 
            this.panFreqAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.panFreqAgendamento.Controls.Add(this.lblFreqAgendamento);
            this.panFreqAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panFreqAgendamento.Location = new System.Drawing.Point(636, 40);
            this.panFreqAgendamento.Name = "panFreqAgendamento";
            this.panFreqAgendamento.Size = new System.Drawing.Size(311, 28);
            this.panFreqAgendamento.TabIndex = 8;
            this.panFreqAgendamento.Visible = false;
            this.panFreqAgendamento.Click += new System.EventHandler(this.panFreqAgendamento_Click);
            this.panFreqAgendamento.MouseLeave += new System.EventHandler(this.panFreqAgendamento_MouseLeave);
            this.panFreqAgendamento.MouseHover += new System.EventHandler(this.panFreqAgendamento_MouseHover);
            // 
            // lblFreqAgendamento
            // 
            this.lblFreqAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFreqAgendamento.AutoSize = true;
            this.lblFreqAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFreqAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFreqAgendamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreqAgendamento.ForeColor = System.Drawing.Color.White;
            this.lblFreqAgendamento.Location = new System.Drawing.Point(5, 3);
            this.lblFreqAgendamento.Name = "lblFreqAgendamento";
            this.lblFreqAgendamento.Size = new System.Drawing.Size(227, 20);
            this.lblFreqAgendamento.TabIndex = 0;
            this.lblFreqAgendamento.Text = "Frequência de Agendamento";
            this.lblFreqAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFreqAgendamento.Click += new System.EventHandler(this.panFreqAgendamento_Click);
            this.lblFreqAgendamento.MouseLeave += new System.EventHandler(this.panFreqAgendamento_MouseLeave);
            this.lblFreqAgendamento.MouseHover += new System.EventHandler(this.panFreqAgendamento_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ckbNotificar);
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
            this.cbSerProd.Size = new System.Drawing.Size(243, 30);
            this.cbSerProd.TabIndex = 4;
            // 
            // ptbConfirmar
            // 
            this.ptbConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ptbConfirmar.BackgroundImage = global::AgendaMais.Properties.Resources.checked__2_;
            this.ptbConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbConfirmar.Location = new System.Drawing.Point(1142, 3);
            this.ptbConfirmar.Name = "ptbConfirmar";
            this.ptbConfirmar.Size = new System.Drawing.Size(34, 34);
            this.ptbConfirmar.TabIndex = 5;
            this.ptbConfirmar.TabStop = false;
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.ptbCancelar.BackgroundImage = global::AgendaMais.Properties.Resources.excluir;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(1180, 3);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(34, 34);
            this.ptbCancelar.TabIndex = 6;
            this.ptbCancelar.TabStop = false;
            // 
            // ckbNotificar
            // 
            this.ckbNotificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbNotificar.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbNotificar.AutoSize = true;
            this.ckbNotificar.BackColor = System.Drawing.Color.White;
            this.ckbNotificar.CausesValidation = false;
            this.ckbNotificar.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbNotificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbNotificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ckbNotificar.FlatAppearance.BorderSize = 0;
            this.ckbNotificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ckbNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbNotificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNotificar.ForeColor = System.Drawing.Color.Black;
            this.ckbNotificar.Location = new System.Drawing.Point(1061, 7);
            this.ckbNotificar.Name = "ckbNotificar";
            this.ckbNotificar.Size = new System.Drawing.Size(75, 26);
            this.ckbNotificar.TabIndex = 99;
            this.ckbNotificar.TabStop = false;
            this.ckbNotificar.Text = "NOTIFICAR";
            this.ckbNotificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbNotificar.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.panDRE);
            this.Controls.Add(this.panFreqAgendamento);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flpAgendamentos.ResumeLayout(false);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
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
        private System.Windows.Forms.CheckBox ckbNotificar;
    }
}


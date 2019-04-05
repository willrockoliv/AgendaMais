namespace AgendaMais.Telas.Financeiro
{
    partial class frFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFinanceiro));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptbContasReceber = new System.Windows.Forms.PictureBox();
            this.ptbContasPagar = new System.Windows.Forms.PictureBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.ptbRelatorios = new System.Windows.Forms.PictureBox();
            this.ptbAgendamento = new System.Windows.Forms.PictureBox();
            this.panCabecalho = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flpLanctos = new System.Windows.Forms.FlowLayoutPanel();
            this.panLancto = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.ptbPago = new System.Windows.Forms.PictureBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panTotal = new System.Windows.Forms.Panel();
            this.lblPanTotalLegenda = new System.Windows.Forms.Label();
            this.lblPanTotalValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panPago = new System.Windows.Forms.Panel();
            this.lblPanPagoLegenda = new System.Windows.Forms.Label();
            this.lblPanPagoValor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panPendente = new System.Windows.Forms.Panel();
            this.lblPanPendenteLegenda = new System.Windows.Forms.Label();
            this.lblPanPendenteValor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panVencido = new System.Windows.Forms.Panel();
            this.lblPanVencidoLegenda = new System.Windows.Forms.Label();
            this.lblPanVencidoValor = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panVenceHoje = new System.Windows.Forms.Panel();
            this.lblPanVenceHojeLegenda = new System.Windows.Forms.Label();
            this.lblPanVenceHojeValor = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ptbAddLancto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContasReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).BeginInit();
            this.panCabecalho.SuspendLayout();
            this.flpLanctos.SuspendLayout();
            this.panLancto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPago)).BeginInit();
            this.panTotal.SuspendLayout();
            this.panPago.SuspendLayout();
            this.panPendente.SuspendLayout();
            this.panVencido.SuspendLayout();
            this.panVenceHoje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddLancto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.ptbContasReceber);
            this.flowLayoutPanel1.Controls.Add(this.ptbContasPagar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 98);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ptbContasReceber
            // 
            this.ptbContasReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbContasReceber.Image = global::AgendaMais.Properties.Resources.contas_receber;
            this.ptbContasReceber.Location = new System.Drawing.Point(3, 3);
            this.ptbContasReceber.Name = "ptbContasReceber";
            this.ptbContasReceber.Size = new System.Drawing.Size(195, 92);
            this.ptbContasReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbContasReceber.TabIndex = 1;
            this.ptbContasReceber.TabStop = false;
            this.ptbContasReceber.Click += new System.EventHandler(this.ptbContasReceber_Click);
            this.ptbContasReceber.MouseEnter += new System.EventHandler(this.ptbContasReceber_MouseEnter);
            this.ptbContasReceber.MouseLeave += new System.EventHandler(this.ptbContasReceber_MouseLeave);
            // 
            // ptbContasPagar
            // 
            this.ptbContasPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbContasPagar.Image = global::AgendaMais.Properties.Resources.contas_pagar_leave;
            this.ptbContasPagar.Location = new System.Drawing.Point(204, 3);
            this.ptbContasPagar.Name = "ptbContasPagar";
            this.ptbContasPagar.Size = new System.Drawing.Size(73, 92);
            this.ptbContasPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbContasPagar.TabIndex = 2;
            this.ptbContasPagar.TabStop = false;
            this.ptbContasPagar.Click += new System.EventHandler(this.ptbContasPagar_Click);
            this.ptbContasPagar.MouseEnter += new System.EventHandler(this.ptbContasPagar_MouseEnter);
            this.ptbContasPagar.MouseLeave += new System.EventHandler(this.ptbContasPagar_MouseLeave);
            // 
            // cbMes
            // 
            this.cbMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cbMes.Location = new System.Drawing.Point(360, 58);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(206, 32);
            this.cbMes.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(299, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "MÊS:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbClientes
            // 
            this.ptbClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbClientes.BackColor = System.Drawing.Color.Transparent;
            this.ptbClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbClientes.Image = global::AgendaMais.Properties.Resources.peaple__4__transparency;
            this.ptbClientes.Location = new System.Drawing.Point(654, 620);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(84, 84);
            this.ptbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClientes.TabIndex = 82;
            this.ptbClientes.TabStop = false;
            this.ptbClientes.Click += new System.EventHandler(this.ptbClientes_Click);
            this.ptbClientes.MouseEnter += new System.EventHandler(this.ptbClientes_MouseEnter);
            this.ptbClientes.MouseLeave += new System.EventHandler(this.ptbClientes_MouseLeave);
            // 
            // ptbRelatorios
            // 
            this.ptbRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.ptbRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbRelatorios.Image = global::AgendaMais.Properties.Resources.Relatorios_transparency;
            this.ptbRelatorios.Location = new System.Drawing.Point(376, 620);
            this.ptbRelatorios.Name = "ptbRelatorios";
            this.ptbRelatorios.Size = new System.Drawing.Size(84, 84);
            this.ptbRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRelatorios.TabIndex = 84;
            this.ptbRelatorios.TabStop = false;
            this.ptbRelatorios.Click += new System.EventHandler(this.ptbRelatorios_Click);
            this.ptbRelatorios.MouseEnter += new System.EventHandler(this.ptbRelatorios_MouseEnter);
            this.ptbRelatorios.MouseLeave += new System.EventHandler(this.ptbRelatorios_MouseLeave);
            // 
            // ptbAgendamento
            // 
            this.ptbAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.ptbAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("ptbAgendamento.Image")));
            this.ptbAgendamento.Location = new System.Drawing.Point(515, 620);
            this.ptbAgendamento.Name = "ptbAgendamento";
            this.ptbAgendamento.Size = new System.Drawing.Size(84, 84);
            this.ptbAgendamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgendamento.TabIndex = 83;
            this.ptbAgendamento.TabStop = false;
            this.ptbAgendamento.Click += new System.EventHandler(this.ptbAgendamento_Click);
            this.ptbAgendamento.MouseEnter += new System.EventHandler(this.ptbAgendamento_MouseEnter);
            this.ptbAgendamento.MouseLeave += new System.EventHandler(this.ptbAgendamento_MouseLeave);
            // 
            // panCabecalho
            // 
            this.panCabecalho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(87)))), ((int)(((byte)(35)))));
            this.panCabecalho.Controls.Add(this.label10);
            this.panCabecalho.Controls.Add(this.label8);
            this.panCabecalho.Controls.Add(this.label7);
            this.panCabecalho.Controls.Add(this.label1);
            this.panCabecalho.Controls.Add(this.label9);
            this.panCabecalho.Location = new System.Drawing.Point(12, 219);
            this.panCabecalho.Name = "panCabecalho";
            this.panCabecalho.Size = new System.Drawing.Size(1058, 40);
            this.panCabecalho.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "DIA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(902, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "VALOR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(631, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "PESSOA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESCRIÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "PAGO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpLanctos
            // 
            this.flpLanctos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpLanctos.AutoScroll = true;
            this.flpLanctos.BackColor = System.Drawing.Color.Transparent;
            this.flpLanctos.Controls.Add(this.panLancto);
            this.flpLanctos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLanctos.Location = new System.Drawing.Point(9, 265);
            this.flpLanctos.Name = "flpLanctos";
            this.flpLanctos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpLanctos.Size = new System.Drawing.Size(1061, 349);
            this.flpLanctos.TabIndex = 86;
            this.flpLanctos.WrapContents = false;
            // 
            // panLancto
            // 
            this.panLancto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panLancto.BackColor = System.Drawing.Color.White;
            this.panLancto.Controls.Add(this.txtValor);
            this.panLancto.Controls.Add(this.txtPessoa);
            this.panLancto.Controls.Add(this.ptbPago);
            this.panLancto.Controls.Add(this.txtDia);
            this.panLancto.Controls.Add(this.txtDescricao);
            this.panLancto.Location = new System.Drawing.Point(3, 3);
            this.panLancto.Name = "panLancto";
            this.panLancto.Size = new System.Drawing.Size(1026, 40);
            this.panLancto.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Location = new System.Drawing.Point(860, 9);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(161, 20);
            this.txtValor.TabIndex = 7;
            this.txtValor.Text = "R$ 900,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPessoa
            // 
            this.txtPessoa.BackColor = System.Drawing.Color.White;
            this.txtPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPessoa.Enabled = false;
            this.txtPessoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPessoa.ForeColor = System.Drawing.Color.Black;
            this.txtPessoa.Location = new System.Drawing.Point(506, 9);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.ReadOnly = true;
            this.txtPessoa.Size = new System.Drawing.Size(348, 20);
            this.txtPessoa.TabIndex = 6;
            this.txtPessoa.Text = "WILLIAM ROCHA";
            this.txtPessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbPago
            // 
            this.ptbPago.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ptbPago.BackgroundImage = global::AgendaMais.Properties.Resources.checked__2_;
            this.ptbPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPago.Location = new System.Drawing.Point(18, 3);
            this.ptbPago.Name = "ptbPago";
            this.ptbPago.Size = new System.Drawing.Size(34, 34);
            this.ptbPago.TabIndex = 5;
            this.ptbPago.TabStop = false;
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.Color.White;
            this.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDia.Enabled = false;
            this.txtDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.ForeColor = System.Drawing.Color.Black;
            this.txtDia.Location = new System.Drawing.Point(87, 9);
            this.txtDia.Name = "txtDia";
            this.txtDia.ReadOnly = true;
            this.txtDia.Size = new System.Drawing.Size(59, 20);
            this.txtDia.TabIndex = 3;
            this.txtDia.Text = "27";
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(152, 9);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(348, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "ALUGUEL";
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panTotal
            // 
            this.panTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(22)))));
            this.panTotal.Controls.Add(this.lblPanTotalLegenda);
            this.panTotal.Controls.Add(this.lblPanTotalValor);
            this.panTotal.Controls.Add(this.label2);
            this.panTotal.Location = new System.Drawing.Point(29, 113);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(200, 100);
            this.panTotal.TabIndex = 87;
            // 
            // lblPanTotalLegenda
            // 
            this.lblPanTotalLegenda.AutoSize = true;
            this.lblPanTotalLegenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanTotalLegenda.ForeColor = System.Drawing.Color.White;
            this.lblPanTotalLegenda.Location = new System.Drawing.Point(13, 60);
            this.lblPanTotalLegenda.Name = "lblPanTotalLegenda";
            this.lblPanTotalLegenda.Size = new System.Drawing.Size(49, 21);
            this.lblPanTotalLegenda.TabIndex = 2;
            this.lblPanTotalLegenda.Text = "Total";
            // 
            // lblPanTotalValor
            // 
            this.lblPanTotalValor.AutoSize = true;
            this.lblPanTotalValor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanTotalValor.ForeColor = System.Drawing.Color.White;
            this.lblPanTotalValor.Location = new System.Drawing.Point(48, 18);
            this.lblPanTotalValor.Name = "lblPanTotalValor";
            this.lblPanTotalValor.Size = new System.Drawing.Size(134, 38);
            this.lblPanTotalValor.TabIndex = 1;
            this.lblPanTotalValor.Text = "1000,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "R$";
            // 
            // panPago
            // 
            this.panPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(26)))));
            this.panPago.Controls.Add(this.lblPanPagoLegenda);
            this.panPago.Controls.Add(this.lblPanPagoValor);
            this.panPago.Controls.Add(this.label12);
            this.panPago.Location = new System.Drawing.Point(235, 113);
            this.panPago.Name = "panPago";
            this.panPago.Size = new System.Drawing.Size(200, 100);
            this.panPago.TabIndex = 88;
            // 
            // lblPanPagoLegenda
            // 
            this.lblPanPagoLegenda.AutoSize = true;
            this.lblPanPagoLegenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanPagoLegenda.ForeColor = System.Drawing.Color.White;
            this.lblPanPagoLegenda.Location = new System.Drawing.Point(16, 61);
            this.lblPanPagoLegenda.Name = "lblPanPagoLegenda";
            this.lblPanPagoLegenda.Size = new System.Drawing.Size(85, 21);
            this.lblPanPagoLegenda.TabIndex = 5;
            this.lblPanPagoLegenda.Text = "Recebido";
            // 
            // lblPanPagoValor
            // 
            this.lblPanPagoValor.AutoSize = true;
            this.lblPanPagoValor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanPagoValor.ForeColor = System.Drawing.Color.White;
            this.lblPanPagoValor.Location = new System.Drawing.Point(51, 19);
            this.lblPanPagoValor.Name = "lblPanPagoValor";
            this.lblPanPagoValor.Size = new System.Drawing.Size(134, 38);
            this.lblPanPagoValor.TabIndex = 4;
            this.lblPanPagoValor.Text = "1000,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "R$";
            // 
            // panPendente
            // 
            this.panPendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(26)))));
            this.panPendente.Controls.Add(this.lblPanPendenteLegenda);
            this.panPendente.Controls.Add(this.lblPanPendenteValor);
            this.panPendente.Controls.Add(this.label15);
            this.panPendente.Location = new System.Drawing.Point(441, 113);
            this.panPendente.Name = "panPendente";
            this.panPendente.Size = new System.Drawing.Size(200, 100);
            this.panPendente.TabIndex = 89;
            // 
            // lblPanPendenteLegenda
            // 
            this.lblPanPendenteLegenda.AutoSize = true;
            this.lblPanPendenteLegenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanPendenteLegenda.ForeColor = System.Drawing.Color.White;
            this.lblPanPendenteLegenda.Location = new System.Drawing.Point(16, 61);
            this.lblPanPendenteLegenda.Name = "lblPanPendenteLegenda";
            this.lblPanPendenteLegenda.Size = new System.Drawing.Size(87, 21);
            this.lblPanPendenteLegenda.TabIndex = 5;
            this.lblPanPendenteLegenda.Text = "Pendente";
            // 
            // lblPanPendenteValor
            // 
            this.lblPanPendenteValor.AutoSize = true;
            this.lblPanPendenteValor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanPendenteValor.ForeColor = System.Drawing.Color.White;
            this.lblPanPendenteValor.Location = new System.Drawing.Point(51, 19);
            this.lblPanPendenteValor.Name = "lblPanPendenteValor";
            this.lblPanPendenteValor.Size = new System.Drawing.Size(134, 38);
            this.lblPanPendenteValor.TabIndex = 4;
            this.lblPanPendenteValor.Text = "1000,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "R$";
            // 
            // panVencido
            // 
            this.panVencido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panVencido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.panVencido.Controls.Add(this.lblPanVencidoLegenda);
            this.panVencido.Controls.Add(this.lblPanVencidoValor);
            this.panVencido.Controls.Add(this.label18);
            this.panVencido.Location = new System.Drawing.Point(647, 113);
            this.panVencido.Name = "panVencido";
            this.panVencido.Size = new System.Drawing.Size(200, 100);
            this.panVencido.TabIndex = 90;
            // 
            // lblPanVencidoLegenda
            // 
            this.lblPanVencidoLegenda.AutoSize = true;
            this.lblPanVencidoLegenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanVencidoLegenda.ForeColor = System.Drawing.Color.White;
            this.lblPanVencidoLegenda.Location = new System.Drawing.Point(16, 61);
            this.lblPanVencidoLegenda.Name = "lblPanVencidoLegenda";
            this.lblPanVencidoLegenda.Size = new System.Drawing.Size(75, 21);
            this.lblPanVencidoLegenda.TabIndex = 5;
            this.lblPanVencidoLegenda.Text = "Vencido";
            // 
            // lblPanVencidoValor
            // 
            this.lblPanVencidoValor.AutoSize = true;
            this.lblPanVencidoValor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanVencidoValor.ForeColor = System.Drawing.Color.White;
            this.lblPanVencidoValor.Location = new System.Drawing.Point(51, 19);
            this.lblPanVencidoValor.Name = "lblPanVencidoValor";
            this.lblPanVencidoValor.Size = new System.Drawing.Size(134, 38);
            this.lblPanVencidoValor.TabIndex = 4;
            this.lblPanVencidoValor.Text = "1000,00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "R$";
            // 
            // panVenceHoje
            // 
            this.panVenceHoje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panVenceHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(153)))), ((int)(((byte)(61)))));
            this.panVenceHoje.Controls.Add(this.lblPanVenceHojeLegenda);
            this.panVenceHoje.Controls.Add(this.lblPanVenceHojeValor);
            this.panVenceHoje.Controls.Add(this.label21);
            this.panVenceHoje.Location = new System.Drawing.Point(853, 113);
            this.panVenceHoje.Name = "panVenceHoje";
            this.panVenceHoje.Size = new System.Drawing.Size(200, 100);
            this.panVenceHoje.TabIndex = 91;
            // 
            // lblPanVenceHojeLegenda
            // 
            this.lblPanVenceHojeLegenda.AutoSize = true;
            this.lblPanVenceHojeLegenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanVenceHojeLegenda.ForeColor = System.Drawing.Color.White;
            this.lblPanVenceHojeLegenda.Location = new System.Drawing.Point(16, 61);
            this.lblPanVenceHojeLegenda.Name = "lblPanVenceHojeLegenda";
            this.lblPanVenceHojeLegenda.Size = new System.Drawing.Size(99, 21);
            this.lblPanVenceHojeLegenda.TabIndex = 5;
            this.lblPanVenceHojeLegenda.Text = "Vence Hoje";
            // 
            // lblPanVenceHojeValor
            // 
            this.lblPanVenceHojeValor.AutoSize = true;
            this.lblPanVenceHojeValor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanVenceHojeValor.ForeColor = System.Drawing.Color.White;
            this.lblPanVenceHojeValor.Location = new System.Drawing.Point(51, 19);
            this.lblPanVenceHojeValor.Name = "lblPanVenceHojeValor";
            this.lblPanVenceHojeValor.Size = new System.Drawing.Size(134, 38);
            this.lblPanVenceHojeValor.TabIndex = 4;
            this.lblPanVenceHojeValor.Text = "1000,00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(16, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 21);
            this.label21.TabIndex = 3;
            this.label21.Text = "R$";
            // 
            // ptbAddLancto
            // 
            this.ptbAddLancto.BackColor = System.Drawing.Color.Transparent;
            this.ptbAddLancto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddLancto.Image = global::AgendaMais.Properties.Resources.add;
            this.ptbAddLancto.Location = new System.Drawing.Point(1076, 272);
            this.ptbAddLancto.Name = "ptbAddLancto";
            this.ptbAddLancto.Size = new System.Drawing.Size(32, 32);
            this.ptbAddLancto.TabIndex = 92;
            this.ptbAddLancto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ptbAddLancto);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panVenceHoje);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.panVencido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panPendente);
            this.panel1.Controls.Add(this.ptbAgendamento);
            this.panel1.Controls.Add(this.panPago);
            this.panel1.Controls.Add(this.ptbRelatorios);
            this.panel1.Controls.Add(this.panTotal);
            this.panel1.Controls.Add(this.ptbClientes);
            this.panel1.Controls.Add(this.panCabecalho);
            this.panel1.Controls.Add(this.flpLanctos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 716);
            this.panel1.TabIndex = 93;
            // 
            // frFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AgendaMais.Properties.Resources.bkg_financeiro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 716);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContasReceber";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbContasReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgendamento)).EndInit();
            this.panCabecalho.ResumeLayout(false);
            this.panCabecalho.PerformLayout();
            this.flpLanctos.ResumeLayout(false);
            this.panLancto.ResumeLayout(false);
            this.panLancto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPago)).EndInit();
            this.panTotal.ResumeLayout(false);
            this.panTotal.PerformLayout();
            this.panPago.ResumeLayout(false);
            this.panPago.PerformLayout();
            this.panPendente.ResumeLayout(false);
            this.panPendente.PerformLayout();
            this.panVencido.ResumeLayout(false);
            this.panVencido.PerformLayout();
            this.panVenceHoje.ResumeLayout(false);
            this.panVenceHoje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddLancto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ptbContasReceber;
        private System.Windows.Forms.PictureBox ptbContasPagar;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.PictureBox ptbRelatorios;
        private System.Windows.Forms.PictureBox ptbAgendamento;
        private System.Windows.Forms.Panel panCabecalho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flpLanctos;
        private System.Windows.Forms.PictureBox ptbPago;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Panel panPago;
        private System.Windows.Forms.Panel panPendente;
        private System.Windows.Forms.Panel panVencido;
        private System.Windows.Forms.Panel panVenceHoje;
        private System.Windows.Forms.Label lblPanTotalLegenda;
        private System.Windows.Forms.Label lblPanTotalValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPanPagoLegenda;
        private System.Windows.Forms.Label lblPanPagoValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPanPendenteLegenda;
        private System.Windows.Forms.Label lblPanPendenteValor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPanVencidoLegenda;
        private System.Windows.Forms.Label lblPanVencidoValor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPanVenceHojeLegenda;
        private System.Windows.Forms.Label lblPanVenceHojeValor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panLancto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox ptbAddLancto;
        private System.Windows.Forms.Panel panel1;
    }
}
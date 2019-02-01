namespace AgendaMais.Telas.Cadastros
{
    partial class frCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastros));
            this.label1 = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panClientes = new System.Windows.Forms.Panel();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.panFuncionarios = new System.Windows.Forms.Panel();
            this.txtFuncionarios = new System.Windows.Forms.TextBox();
            this.panProdServ = new System.Windows.Forms.Panel();
            this.txtProdServ = new System.Windows.Forms.TextBox();
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.ptbAgenda = new System.Windows.Forms.PictureBox();
            this.ptbFinanceiro = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cad1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cad2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpMenu.SuspendLayout();
            this.panClientes.SuspendLayout();
            this.panFuncionarios.SuspendLayout();
            this.panProdServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTROS";
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpMenu.Controls.Add(this.panClientes);
            this.flpMenu.Controls.Add(this.panFuncionarios);
            this.flpMenu.Controls.Add(this.panProdServ);
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(147, 160);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpMenu.Size = new System.Drawing.Size(990, 443);
            this.flpMenu.TabIndex = 8;
            this.flpMenu.WrapContents = false;
            // 
            // panClientes
            // 
            this.panClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panClientes.Controls.Add(this.txtClientes);
            this.panClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panClientes.Location = new System.Drawing.Point(3, 3);
            this.panClientes.Name = "panClientes";
            this.panClientes.Size = new System.Drawing.Size(980, 60);
            this.panClientes.TabIndex = 4;
            this.panClientes.Click += new System.EventHandler(this.Clientes_Click);
            this.panClientes.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.panClientes.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // txtClientes
            // 
            this.txtClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.txtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClientes.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes.ForeColor = System.Drawing.Color.White;
            this.txtClientes.Location = new System.Drawing.Point(3, 8);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.ReadOnly = true;
            this.txtClientes.Size = new System.Drawing.Size(974, 46);
            this.txtClientes.TabIndex = 0;
            this.txtClientes.TabStop = false;
            this.txtClientes.Text = "CLIENTES";
            this.txtClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClientes.Click += new System.EventHandler(this.Clientes_Click);
            this.txtClientes.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.txtClientes.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // panFuncionarios
            // 
            this.panFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panFuncionarios.Controls.Add(this.txtFuncionarios);
            this.panFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panFuncionarios.Location = new System.Drawing.Point(3, 69);
            this.panFuncionarios.Name = "panFuncionarios";
            this.panFuncionarios.Size = new System.Drawing.Size(980, 60);
            this.panFuncionarios.TabIndex = 5;
            this.panFuncionarios.Click += new System.EventHandler(this.txtFuncionarios_Click);
            this.panFuncionarios.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.panFuncionarios.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // txtFuncionarios
            // 
            this.txtFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.txtFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFuncionarios.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarios.ForeColor = System.Drawing.Color.White;
            this.txtFuncionarios.Location = new System.Drawing.Point(3, 8);
            this.txtFuncionarios.Name = "txtFuncionarios";
            this.txtFuncionarios.ReadOnly = true;
            this.txtFuncionarios.Size = new System.Drawing.Size(974, 46);
            this.txtFuncionarios.TabIndex = 0;
            this.txtFuncionarios.TabStop = false;
            this.txtFuncionarios.Text = "FUNCIONÁRIOS";
            this.txtFuncionarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFuncionarios.Click += new System.EventHandler(this.txtFuncionarios_Click);
            this.txtFuncionarios.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.txtFuncionarios.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // panProdServ
            // 
            this.panProdServ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panProdServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panProdServ.Controls.Add(this.txtProdServ);
            this.panProdServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panProdServ.Location = new System.Drawing.Point(3, 135);
            this.panProdServ.Name = "panProdServ";
            this.panProdServ.Size = new System.Drawing.Size(980, 60);
            this.panProdServ.TabIndex = 6;
            this.panProdServ.Click += new System.EventHandler(this.txtProdServ_Click);
            this.panProdServ.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.panProdServ.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // txtProdServ
            // 
            this.txtProdServ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProdServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.txtProdServ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProdServ.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdServ.ForeColor = System.Drawing.Color.White;
            this.txtProdServ.Location = new System.Drawing.Point(3, 8);
            this.txtProdServ.Name = "txtProdServ";
            this.txtProdServ.ReadOnly = true;
            this.txtProdServ.Size = new System.Drawing.Size(974, 46);
            this.txtProdServ.TabIndex = 0;
            this.txtProdServ.TabStop = false;
            this.txtProdServ.Text = "PRODUTOS E SERVIÇOS";
            this.txtProdServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdServ.Click += new System.EventHandler(this.txtProdServ_Click);
            this.txtProdServ.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.txtProdServ.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            // 
            // ptbClientes
            // 
            this.ptbClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbClientes.BackColor = System.Drawing.Color.Transparent;
            this.ptbClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbClientes.Image = global::AgendaMais.Properties.Resources.peaple__4__transparency;
            this.ptbClientes.Location = new System.Drawing.Point(725, 611);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(84, 84);
            this.ptbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClientes.TabIndex = 15;
            this.ptbClientes.TabStop = false;
            // 
            // ptbAgenda
            // 
            this.ptbAgenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbAgenda.BackColor = System.Drawing.Color.Transparent;
            this.ptbAgenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbAgenda.Image = global::AgendaMais.Properties.Resources.calendary_transparency;
            this.ptbAgenda.Location = new System.Drawing.Point(586, 611);
            this.ptbAgenda.Name = "ptbAgenda";
            this.ptbAgenda.Size = new System.Drawing.Size(84, 84);
            this.ptbAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAgenda.TabIndex = 14;
            this.ptbAgenda.TabStop = false;
            // 
            // ptbFinanceiro
            // 
            this.ptbFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.ptbFinanceiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbFinanceiro.Image = global::AgendaMais.Properties.Resources.money__4__tranparency;
            this.ptbFinanceiro.Location = new System.Drawing.Point(447, 611);
            this.ptbFinanceiro.Name = "ptbFinanceiro";
            this.ptbFinanceiro.Size = new System.Drawing.Size(84, 84);
            this.ptbFinanceiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFinanceiro.TabIndex = 13;
            this.ptbFinanceiro.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(99)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 29);
            this.menuStrip1.TabIndex = 16;
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.agendaToolStripMenuItem.Text = "AGENDA";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cad1ToolStripMenuItem,
            this.cad2ToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.cadastrosToolStripMenuItem.Text = "CADASTROS";
            // 
            // cad1ToolStripMenuItem
            // 
            this.cad1ToolStripMenuItem.Name = "cad1ToolStripMenuItem";
            this.cad1ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cad1ToolStripMenuItem.Text = "cad 1";
            // 
            // cad2ToolStripMenuItem
            // 
            this.cad2ToolStripMenuItem.Name = "cad2ToolStripMenuItem";
            this.cad2ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cad2ToolStripMenuItem.Text = "cad 2";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rel1ToolStripMenuItem,
            this.rel2ToolStripMenuItem});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.relatóriosToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // rel1ToolStripMenuItem
            // 
            this.rel1ToolStripMenuItem.Name = "rel1ToolStripMenuItem";
            this.rel1ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rel1ToolStripMenuItem.Text = "rel 1";
            // 
            // rel2ToolStripMenuItem
            // 
            this.rel2ToolStripMenuItem.Name = "rel2ToolStripMenuItem";
            this.rel2ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rel2ToolStripMenuItem.Text = "rel 2";
            // 
            // frCadastros
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
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpMenu.ResumeLayout(false);
            this.panClientes.ResumeLayout(false);
            this.panClientes.PerformLayout();
            this.panFuncionarios.ResumeLayout(false);
            this.panFuncionarios.PerformLayout();
            this.panProdServ.ResumeLayout(false);
            this.panProdServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinanceiro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel panClientes;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.Panel panFuncionarios;
        private System.Windows.Forms.TextBox txtFuncionarios;
        private System.Windows.Forms.Panel panProdServ;
        private System.Windows.Forms.TextBox txtProdServ;
        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.PictureBox ptbAgenda;
        private System.Windows.Forms.PictureBox ptbFinanceiro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cad1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cad2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rel2ToolStripMenuItem;
    }
}
namespace Salao
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrisToolStripMenuItem,
            this.movimentosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrisToolStripMenuItem
            // 
            this.cadastrisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.cadastrisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrisToolStripMenuItem.Image")));
            this.cadastrisToolStripMenuItem.Name = "cadastrisToolStripMenuItem";
            this.cadastrisToolStripMenuItem.Size = new System.Drawing.Size(109, 27);
            this.cadastrisToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviçosToolStripMenuItem.Image")));
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.ServiçosToolStripMenuItem_Click);
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.movimentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentosToolStripMenuItem.Image")));
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.movimentosToolStripMenuItem.Text = "&Movimentos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendasToolStripMenuItem.Image")));
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.VendasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.vendaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem1.Image")));
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(142, 28);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.ProdutosToolStripMenuItem1_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendaToolStripMenuItem.Image")));
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.VendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // lblRelogio
            // 
            this.lblRelogio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRelogio.BackColor = System.Drawing.Color.Transparent;
            this.lblRelogio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRelogio.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(589, 476);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(120, 37);
            this.lblRelogio.TabIndex = 2;
            this.lblRelogio.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(502, 393);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(285, 33);
            this.lblData.TabIndex = 3;
            this.lblData.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1288, 626);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblRelogio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salão de Beleza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}
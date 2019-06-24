namespace Salao
{
    partial class frmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServico));
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServico
            // 
            this.dgvServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(6, 83);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(983, 128);
            this.dgvServico.TabIndex = 0;
            this.dgvServico.DoubleClick += new System.EventHandler(this.DgvServico_DoubleClick);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(389, 498);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 32);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(247, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "    &Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInserir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(105, 498);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(98, 32);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "    &Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(437, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 26);
            this.lblId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descricao:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDescricao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(437, 103);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(225, 26);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(437, 140);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 26);
            this.txtValor.TabIndex = 17;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravar.BackgroundImage")));
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGravar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(531, 498);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 32);
            this.btnGravar.TabIndex = 26;
            this.btnGravar.Text = "    &Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(673, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 32);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "   &Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(815, 498);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 32);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.rdbId);
            this.groupBox2.Controls.Add(this.rdbDescricao);
            this.groupBox2.Controls.Add(this.rdbTodos);
            this.groupBox2.Controls.Add(this.btnFiltro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.dgvServico);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 217);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista dos serviços";
            // 
            // rdbId
            // 
            this.rdbId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(668, 35);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(38, 24);
            this.rdbId.TabIndex = 37;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.Visible = false;
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Location = new System.Drawing.Point(712, 35);
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.Size = new System.Drawing.Size(87, 24);
            this.rdbDescricao.TabIndex = 35;
            this.rdbDescricao.TabStop = true;
            this.rdbDescricao.Text = "Descricao";
            this.rdbDescricao.UseVisualStyleBackColor = true;
            this.rdbDescricao.Visible = false;
            // 
            // rdbTodos
            // 
            this.rdbTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(597, 35);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(65, 24);
            this.rdbTodos.TabIndex = 34;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.Visible = false;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltro.BackgroundImage")));
            this.btnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.Location = new System.Drawing.Point(483, 31);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(97, 32);
            this.btnFiltro.TabIndex = 33;
            this.btnFiltro.Text = "&Filtro";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(81, 34);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(293, 26);
            this.txtPesquisa.TabIndex = 31;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(380, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 32);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 233);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // frmServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1019, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manter Servico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.RadioButton rdbDescricao;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
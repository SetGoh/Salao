using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salao
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void ServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServico frmServ = new frmServico();
            frmServ.MdiParent = this;
            frmServ.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmVend = new frmVenda();
            frmVend.MdiParent = this;
            frmVend.Show();
        }
    }
}

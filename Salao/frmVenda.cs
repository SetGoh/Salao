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
    public partial class frmVenda : Form
    {
        Camadas.Model.Produto produto = new Camadas.Model.Produto();
        Camadas.Model.Servico servico = new Camadas.Model.Servico();

        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void habilitaCampos(bool status)
        {
            btnInserir.Visible = !status;
//            btnEditar.Visible = !status;
//            btnRemover.Visible = !status;
            btnSair.Visible = !status;
            btnGravar.Visible = status;
            btnCancelar.Visible = status;

            dtpVenda.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;
            txtServico.Enabled = status;
            cmbServico.Enabled = status;
            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;
            txtQuantidade.Enabled = status;
            txtValorProd.Enabled = status;
            txtValorServ.Enabled = status;
        }

        private void limpaCampos()
        {
            lblId.Text = "";
            dtpVenda.Value = DateTime.Now;
            txtCliente.Text = "";
            cmbCliente.Text = "";
            txtServico.Text = "";
            cmbServico.Text = "";
            txtProduto.Text = "";
            cmbProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorProd.Text = "";
            txtPesquisa.Text = "";
            lblTotal.Text = "";
            txtValorServ.Text = "";

        }
        private void calcularTotal()
        {
            int quantidade = (txtQuantidade.Text == "") ? 0 : Convert.ToInt32(txtQuantidade.Text);
            float valor = (txtValorProd.Text == "") ? 0 : Convert.ToSingle(txtValorProd.Text);
            int servico = (txtValorServ.Text == "") ? 0 : Convert.ToInt32(txtValorServ.Text);
            float total =   servico + (quantidade * valor);
            lblTotal.Text = total.ToString();
        }
        private void FrmVenda_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            dgvVenda.DataSource = "";
            dgvVenda.DataSource = bllVend.Select();

            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCli.Select();

            Camadas.BLL.Servico bllserv = new Camadas.BLL.Servico();
            cmbServico.DisplayMember = "descricao";
            cmbServico.ValueMember = "id";
            cmbServico.DataSource = bllserv.Select();

            Camadas.BLL.Produto bllprod = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "nomeProd";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllprod.Select();

            limpaCampos();
            habilitaCampos(false);
        }
        private void buscarProduto(int id)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> listaProd = new List<Camadas.Model.Produto>();
            listaProd = bllProd.SelectById(id);
            if (listaProd != null)
                produto = listaProd[0];
        }
        private void buscarServico(int id)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            List<Camadas.Model.Servico> listaServ = new List<Camadas.Model.Servico>();
            listaServ = bllServ.SelectById(id);
            if (listaServ != null)
                servico = listaServ[0];
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();

        }
        private void CmbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServico.Text = cmbServico.SelectedValue.ToString();
            int idServ = Convert.ToInt32(cmbServico.SelectedValue);
            buscarServico(idServ);
            if (servico != null)
                txtValorServ.Text = servico.valorServ.ToString();
            calcularTotal();
        }

        private void CmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cmbProduto.SelectedValue.ToString();
            txtQuantidade.Text = "";
            int idProd = Convert.ToInt32(cmbProduto.SelectedValue);
            buscarProduto(idProd);
            if (produto != null)
                txtValorProd.Text = produto.valorProd.ToString();

        }
        private void txtCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
            }
            catch
            {

            }
        }
        private void txtServico_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbServico.SelectedValue = Convert.ToInt32(txtServico.Text);
            }
            catch
            {

            }
        }
        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
                int idProd = Convert.ToInt32(cmbProduto.SelectedValue);
                buscarProduto(idProd);
                if (produto != null)
                    txtValorProd.Text = produto.valorProd.ToString();
            }
            catch
            {

            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (produto != null)
                if (Convert.ToInt32(txtQuantidade.Text) > produto.quantidade)
                {
                    MessageBox.Show("Estoque insuficiente..." + produto.quantidade.ToString());
                    txtQuantidade.Focus();
                }
            calcularTotal();

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblId.Text = "-1"; //Quando estiver -1 sei que é para inserir um dado
            txtCliente.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            Camadas.Model.Venda venda = new Camadas.Model.Venda();
            venda.id = Convert.ToInt32(lblId.Text);
            venda.data = dtpVenda.Value;
            venda.cliente = Convert.ToInt32(cmbCliente.SelectedValue);
            venda.servico = Convert.ToInt32(cmbServico.SelectedValue);
            venda.produto = Convert.ToInt32(cmbProduto.SelectedValue);
            venda.quantidade = Convert.ToInt32(txtQuantidade.Text);

            string msg;
            string titulo;
            int id = Convert.ToInt32(lblId.Text);
            if (id == -1)
            {
                msg = "Deseja inserir os dados da Venda?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja alterar os dados da Venda?";
                titulo = "Editar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
                if (id == -1)
                    bllVend.Insert(venda);
                else bllVend.Update(venda);

            dgvVenda.DataSource = ""; //Limpa os dados do gridview
            dgvVenda.DataSource = bllVend.Select(); //Pega os novos dados do gridview

            limpaCampos();
            habilitaCampos(false);

        }

        private void dgvVenda_DoubleClick(object sender, EventArgs e)
        {
            //carrega valores nos controles
            lblId.Text = dgvVenda.SelectedRows[0].Cells["id"].Value.ToString();
            dtpVenda.Value = Convert.ToDateTime(dgvVenda.SelectedRows[0].Cells["data"].Value.ToString());
//            txtCliente.Text = dgvVenda.SelectedRows[0].Cells["cliente"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(dgvVenda.SelectedRows[0].Cells["cliente"].Value.ToString());
//            txtServico.Text = dgvVenda.SelectedRows[0].Cells["servico"].Value.ToString();
            cmbServico.SelectedValue = Convert.ToInt32(dgvVenda.SelectedRows[0].Cells["servico"].Value.ToString());
//            txtProduto.Text = dgvVenda.SelectedRows[0].Cells["produto"].Value.ToString();
            cmbProduto.SelectedValue = Convert.ToInt32(dgvVenda.SelectedRows[0].Cells["produto"].Value.ToString());
            txtQuantidade.Text = dgvVenda.SelectedRows[0].Cells["quantidade"].Value.ToString();
            txtValorProd.Text = dgvVenda.SelectedRows[0].Cells["valorServ"].Value.ToString();
            lblTotal.Text = dgvVenda.SelectedRows[0].Cells["total"].Value.ToString();

        }

        private void TxtValorServ_Leave(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            dgvVenda.DataSource = "";
            dgvVenda.DataSource = bllVend.Select();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            rdbTodos.Visible = !rdbTodos.Visible;
            rdbId.Visible = !rdbId.Visible;
//            rdbNome.Visible = !rdbNome.Visible;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Venda> listaVenda = new List<Camadas.Model.Venda>();
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            if (rdbTodos.Checked)
                listaVenda = bllVend.Select();
            else if (rdbId.Checked)
                listaVenda = bllVend.SelectById(Convert.ToInt32(txtPesquisa.Text));
//            else if (rdbNome.Checked)
//                listaProduto = bllProduto.SelectByNome(txtPesquisa.Text.Trim());


            dgvVenda.DataSource = "";
            dgvVenda.DataSource = listaVenda;

            limpaCampos();
        }

    }
}

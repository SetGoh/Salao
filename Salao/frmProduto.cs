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
    public partial class frmProduto : Form
    {
        public frmProduto()
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
            btnEditar.Visible = !status;
            btnRemover.Visible = !status;
            btnSair.Visible = !status;
            btnGravar.Visible = status;
            btnCancelar.Visible = status;

            txtNome.Enabled = status;
            txtLinha.Enabled = status;
            txtMarca.Enabled = status;
            txtQuantidade.Enabled = status;
            txtValor.Enabled = status;
        }

        private void limpaCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtLinha.Text = "";
            txtMarca.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            txtPesquisa.Text = "";

        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();

            habilitaCampos(false);
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblId.Text = "-1";
            txtNome.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            produto.id = Convert.ToInt32(lblId.Text);
            produto.nomeProd = txtNome.Text;
            produto.linha = txtLinha.Text;
            produto.marca = txtMarca.Text;
            produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.valorProd = Convert.ToSingle(txtValor.Text);

            string msg;
            string titulo;
            int id = Convert.ToInt32(lblId.Text);
            if (id == -1)
            {
                msg = "Deseja inserir os dados do Produto?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja alterar os dados do Produto?";
                titulo = "Editar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
                if (id == -1)
                    bllProd.Insert(produto);
                else bllProd.Update(produto);

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();

            limpaCampos();
            habilitaCampos(false);

        }
        private void DgvProduto_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProduto.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvProduto.SelectedRows[0].Cells["nomeProd"].Value.ToString();
            txtLinha.Text = dgvProduto.SelectedRows[0].Cells["linha"].Value.ToString();
            txtMarca.Text = dgvProduto.SelectedRows[0].Cells["marca"].Value.ToString();
            txtQuantidade.Text = dgvProduto.SelectedRows[0].Cells["quantidade"].Value.ToString();
            txtValor.Text = dgvProduto.SelectedRows[0].Cells["valorProd"].Value.ToString();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                habilitaCampos(true);
                txtNome.Focus();
            }
            else MessageBox.Show("Erro - Nenhum registro selecionado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            if (lblId.Text != string.Empty)
            {
                int id = Convert.ToInt32(lblId.Text);
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja Remover? ", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                    bllProd.Delete(id);


            }
            else MessageBox.Show("Erro - Nenhum registro selecionado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaCampos();
            habilitaCampos(false);

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();
        }
        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            rdbTodos.Visible = !rdbTodos.Visible;
            rdbId.Visible = !rdbId.Visible;
            rdbNome.Visible = !rdbNome.Visible;
            rdbMarca.Visible = !rdbMarca.Visible;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Produto> listaProduto = new List<Camadas.Model.Produto>();
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            if (rdbTodos.Checked)
                listaProduto = bllProduto.Select();
            else if (rdbId.Checked)
                listaProduto = bllProduto.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbNome.Checked)
                listaProduto = bllProduto.SelectByNome(txtPesquisa.Text.Trim());
            else if (rdbMarca.Checked)
                listaProduto = bllProduto.SelectByMarca(txtPesquisa.Text.Trim());

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = listaProduto;

            limpaCampos();
        }
    }
}

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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public void btnSair_Click(object sender, EventArgs e)
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
            txtAniversario.Enabled = status;
            txtTelefone.Enabled = status;
            txtCelular.Enabled = status;
            txtEndereco.Enabled = status;
            txtNumero.Enabled = status;
            txtBairro.Enabled = status;
            txtCidade.Enabled = status;
            txtUf.Enabled = status;
            txtCep.Enabled = status;

        }

        private void limpaCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
            txtAniversario.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtCep.Text = "";
            txtPesquisa.Text = "";

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = bllCli.Select();

            limpaCampos();
            habilitaCampos(false);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblId.Text = "-1"; //Quando estiver -1 sei que é para inserir um dado
            txtNome.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            //instancia e preenche com dados o objeto produto para enviar para o banco
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            cliente.id = Convert.ToInt32(lblId.Text);
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);
            cliente.telefone = txtTelefone.Text;
            cliente.celular = txtCelular.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = txtNumero.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCidade.Text;
            cliente.uf = txtUf.Text;
            cliente.cep = txtCep.Text;

            string msg;
            string titulo;
            int id = Convert.ToInt32(lblId.Text);
            if (id == -1)
            {
                msg = "Deseja inserir os dados do Cliente?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja alterar os dados do Cliente?";
                titulo = "Editar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
                if (id == -1)
                    bllCli.Insert(cliente);
                else bllCli.Update(cliente);

            dgvCliente.DataSource = ""; //Limpa os dados do gridview
            dgvCliente.DataSource = bllCli.Select(); //Pega os novos dados do gridview

            limpaCampos();
            habilitaCampos(false);

        }

        private void DgvCliente_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvCliente.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvCliente.SelectedRows[0].Cells["nome"].Value.ToString();
            txtAniversario.Text = dgvCliente.SelectedRows[0].Cells["aniversario"].Value.ToString();
            txtTelefone.Text = dgvCliente.SelectedRows[0].Cells["telefone"].Value.ToString();
            txtCelular.Text = dgvCliente.SelectedRows[0].Cells["celular"].Value.ToString();
            txtEndereco.Text = dgvCliente.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtNumero.Text = dgvCliente.SelectedRows[0].Cells["numero"].Value.ToString();
            txtBairro.Text = dgvCliente.SelectedRows[0].Cells["bairro"].Value.ToString();
            txtCidade.Text = dgvCliente.SelectedRows[0].Cells["cidade"].Value.ToString();
            txtUf.Text = dgvCliente.SelectedRows[0].Cells["uf"].Value.ToString();
            txtCep.Text = dgvCliente.SelectedRows[0].Cells["cep"].Value.ToString();
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
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();

            if (lblId.Text != string.Empty)
            {
                int id = Convert.ToInt32(lblId.Text);
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja Remover? ", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                    bllCli.Delete(id);


            }
            else MessageBox.Show("Erro - Nenhum registro selecionado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaCampos();
            habilitaCampos(false);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = bllCli.Select();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = bllCli.Select();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            rdbTodos.Visible = !rdbTodos.Visible;
            rdbId.Visible = !rdbId.Visible;
            rdbNome.Visible = !rdbNome.Visible;
            rdbCidade.Visible = !rdbCidade.Visible;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Cliente> listaCliente = new List<Camadas.Model.Cliente>();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            if (rdbTodos.Checked)
                listaCliente = bllCliente.Select();
            else if (rdbId.Checked)
                listaCliente = bllCliente.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbNome.Checked)
                listaCliente = bllCliente.SelectByNome(txtPesquisa.Text.Trim());
            else if (rdbCidade.Checked)
                listaCliente = bllCliente.SelectByCidade(txtPesquisa.Text.Trim());

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = listaCliente;

            limpaCampos();
        }
    }
}

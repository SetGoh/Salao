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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
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

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dalCli.Insert(cliente);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
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

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dalCli.Update(cliente);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lblId.Text);

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dalCli.Delete(id);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
        }
    }
}

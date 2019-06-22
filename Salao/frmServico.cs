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
    public partial class frmServico : Form
    {
        public frmServico()
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

            txtDescricao.Enabled = status;
            txtValor.Enabled = status;
        }

        private void limpaCampos()
        {
            lblId.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtPesquisa.Text = "";

        }
        private void FrmServico_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            dgvServico.DataSource = "";
            dgvServico.DataSource = bllServ.Select();

            habilitaCampos(false);
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblId.Text = "-1";
            txtDescricao.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();

            Camadas.Model.Servico servico = new Camadas.Model.Servico();
            servico.id = Convert.ToInt32(lblId.Text);
            servico.descricao = txtDescricao.Text;
            servico.valorServ = Convert.ToSingle(txtValor.Text);

            string msg;
            string titulo;
            int id = Convert.ToInt32(lblId.Text);
            if (id == -1)
            {
                msg = "Deseja inserir os dados do Servico?";
                titulo = "Inserir";
            }
            else
            {
                msg = "Deseja alterar os dados do Servico?";
                titulo = "Editar";
            }

            DialogResult resposta;
            resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
                if (id == -1)
                    bllServ.Insert(servico);
                else bllServ.Update(servico);

            dgvServico.DataSource = "";
            dgvServico.DataSource = bllServ.Select();

            limpaCampos();
            habilitaCampos(false);

        }

        private void DgvServico_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvServico.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvServico.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtValor.Text = dgvServico.SelectedRows[0].Cells["valorServ"].Value.ToString();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                habilitaCampos(true);
                txtDescricao.Focus();
            }
            else MessageBox.Show("Erro - Nenhum registro selecionado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();

            if (lblId.Text != string.Empty)
            {
                int id = Convert.ToInt32(lblId.Text);
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja Remover? ", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                    bllServ.Delete(id);


            }
            else MessageBox.Show("Erro - Nenhum registro selecionado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaCampos();
            habilitaCampos(false);

            dgvServico.DataSource = "";
            dgvServico.DataSource = bllServ.Select();
        }
        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Servico bllServ = new Camadas.BLL.Servico();
            dgvServico.DataSource = "";
            dgvServico.DataSource = bllServ.Select();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            rdbTodos.Visible = !rdbTodos.Visible;
            rdbId.Visible = !rdbId.Visible;
            rdbDescricao.Visible = !rdbDescricao.Visible;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Camadas.Model.Servico> listaServico = new List<Camadas.Model.Servico>();
            Camadas.BLL.Servico bllServico = new Camadas.BLL.Servico();
            if (rdbTodos.Checked)
                listaServico = bllServico.Select();
            else if (rdbId.Checked)
                listaServico = bllServico.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbDescricao.Checked)
                listaServico = bllServico.SelectByDescricao(txtPesquisa.Text.Trim());

            dgvServico.DataSource = "";
            dgvServico.DataSource = listaServico;

            limpaCampos();
        }
    }
}

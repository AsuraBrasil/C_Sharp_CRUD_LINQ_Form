using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBasicoLinqToSql
{
    public partial class frmCadastroDePessoas : Form
    {
        private uint idDeAlteracao; // Atributo usado pelo método btnExcluir_Click()

        public frmCadastroDePessoas()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Text = default(string);
            txtSobrenome.Text = default(string);
            txtRua.Text = default(string);
            txtBairro.Text = default(string);
            txtCidade.Text = default(string);
            cbxUf.Text = "AC";
            txtTelefone.Text = default(string);
            txtCelular.Text = default(string);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text.Trim()) || !String.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                _Pessoas pessoa = new _Pessoas();
                pessoa.Nome = txtNome.Text;
                pessoa.SobreNome = txtSobrenome.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Uf = cbxUf.Text;
                pessoa.Telefone = txtTelefone.Text;
                pessoa.Celular = txtCelular.Text;

                if (pessoa.SalvarPessoa())
                {
                    MessageBox.Show(pessoa.Nome + " salvo(a) com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pessoasTableAdapter.Fill(baseDeDadosDataSet.Pessoas); // Recarregando o datagridview
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar o registro de " + pessoa.Nome, "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Insira o nome!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _Pessoas pessoa = new _Pessoas();
            // Reconhecendo a linha do dgvPessoas
            int linha = -1;
            if (dgvPessoas.SelectedRows.Count > 0)
                linha = dgvPessoas.SelectedRows[0].Index;
            else if (dgvPessoas.SelectedCells.Count > 0)
                linha = dgvPessoas.SelectedCells[0].RowIndex;

            if (linha > -1)
            {
                // Pegando o valor da primeira célula da linha referente ao id
                uint id;
                id = Convert.ToUInt32(dgvPessoas.Rows[linha].Cells[0].Value);
                string nomePessoa = Convert.ToString(dgvPessoas.Rows[linha].Cells[1].Value); 

                DialogResult confirmacao = MessageBox.Show("Realmente deseja excluir o registro de " + nomePessoa + "?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (pessoa.ExcluirPessoa(id))
                    {
                        MessageBox.Show(nomePessoa + " excluído(a) com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        pessoasTableAdapter.Fill(baseDeDadosDataSet.Pessoas); // Recarregando o datagridview
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o registro de " + nomePessoa, "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar")
            {
                // Reconhecendo a linha do dgvPessoas
                int linha = -1;
                if (dgvPessoas.SelectedRows.Count > 0)
                    linha = dgvPessoas.SelectedRows[0].Index;
                else if (dgvPessoas.SelectedCells.Count > 0)
                    linha = dgvPessoas.SelectedCells[0].RowIndex;

                // Jogando os dados pros textboxes e salvando o ID
                idDeAlteracao = Convert.ToUInt32(dgvPessoas.Rows[linha].Cells[0].Value);
                txtNome.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[1].Value);
                txtSobrenome.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[2].Value);
                txtRua.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[3].Value);
                txtBairro.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[4].Value);
                txtCidade.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[5].Value);
                cbxUf.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[6].Value);
                txtTelefone.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[7].Value);
                txtCelular.Text = Convert.ToString(dgvPessoas.Rows[linha].Cells[8].Value);

                //Mudando a propriedade text do btnAlterar
                btnAlterar.Text = "Concluir";
                btnSalvar.Enabled = false; // Desabilita a opção salvar
                btnExcluir.Enabled = false; // Dasabilita a opção excluir
            }
            else
            {
                _Pessoas pessoa = new _Pessoas();
                pessoa.Nome = txtNome.Text;
                pessoa.SobreNome = txtSobrenome.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Uf = cbxUf.Text;
                pessoa.Telefone = txtTelefone.Text;
                pessoa.Celular = txtCelular.Text;

                if ( pessoa.AlterarPessoa(idDeAlteracao))
                {
                    MessageBox.Show(pessoa.Nome + " alterado(a) com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o registro de " + pessoa.Nome, "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Restaurando estado anterior dos itens modificados
                btnAlterar.Text = "Alterar";
                btnSalvar.Enabled = true;
                btnExcluir.Enabled = true;
                pessoasTableAdapter.Fill(baseDeDadosDataSet.Pessoas); // Recarregando o datagridview
                LimparCampos();
            }
        }

        private void PesquisaDePessoas()
        {
            pessoasBindingSource.Filter = "Nome like '%" + txtNomePesquisa.Text + "%' AND " +
                "SobreNome like '%" + txtSobrenomePesquisa.Text + "%'";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LimparCampos();
            // TODO: This line of code loads data into the 'baseDeDadosDataSet.Pessoas' table. You can move, or remove it, as needed.
            this.pessoasTableAdapter.Fill(this.baseDeDadosDataSet.Pessoas);
        }

        // Evento de mudança de texto que chama o método PesquisaDePessoas()
        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisaDePessoas();
        }
    }
}

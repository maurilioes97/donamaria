using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasodeUsoDonamaria.Model;

namespace CasodeUsoDonamaria
{
    public partial class FormCadastrarCozinha : Form
    {
        // Variável de controle para o modo de edição
        private int _idParaAtualizar = -1;

        public FormCadastrarCozinha()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("O campo Descrição é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }
            return true;
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TipoCozinha.SelecionarTodos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (_idParaAtualizar != -1)
            {
                TipoCozinha cozinhaAtualizada = new TipoCozinha();
                cozinhaAtualizada.id = _idParaAtualizar;
                cozinhaAtualizada.Nome = txtNome.Text;
                cozinhaAtualizada.Descricao = txtDescricao.Text;

                TipoCozinha.Atualizar(cozinhaAtualizada);

                _idParaAtualizar = -1;
                MessageBox.Show("Cozinha atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                TipoCozinha cozinha = new TipoCozinha();
                cozinha.Nome = txtNome.Text;
                cozinha.Descricao = txtDescricao.Text;

                cozinha.Incluir();
                MessageBox.Show("Cozinha cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            AtualizarGrid();
            txtNome.Clear();
            txtDescricao.Clear();
        }

        /*
         * metodo que trata o clique nos botoes do datagridview
         * para os casos de editar e excluir os items
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                if (e.ColumnIndex == dataGridView1.Columns["Column4"].Index)
                {
                    TipoCozinha? cozinhaParaAtualizar = TipoCozinha.SelecionarTodos().FirstOrDefault(c => c.id == id);
                    if (cozinhaParaAtualizar != null)
                    {
                        txtNome.Text = cozinhaParaAtualizar.Nome;
                        txtDescricao.Text = cozinhaParaAtualizar.Descricao;

                        _idParaAtualizar = id;
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Column5"].Index)
                {
                  
                        TipoCozinha.Excluir(id);
                        AtualizarGrid();
                        MessageBox.Show("Cozinha excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
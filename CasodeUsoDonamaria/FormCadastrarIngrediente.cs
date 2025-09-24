using CasodeUsoDonamaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasodeUsoDonamaria
{
    public partial class FormCadastrarIngrediente : Form
    {
        public FormCadastrarIngrediente()
        {
            InitializeComponent();
        }

        private void FormCadastrarIngrediente_Load(object sender, EventArgs e)
        {
            GrdItensIngrediente.AutoGenerateColumns = false;
            GrdItensIngrediente.DataSource = Ingrediente.SelecionarTodos();
        }

        private void GrdItensIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool VereificaControles()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo com nome", ProductName, MessageBoxButtons.OK);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
            TxtDescricao.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (VereificaControles())
            {
                if (TxtId.Text == "")
                {
                    Ingrediente oIngrediente = new Ingrediente();
                    oIngrediente.Nome = TxtNome.Text;
                    oIngrediente.Descricao = TxtDescricao.Text;
                    oIngrediente.Incluir();
                    
                }
                else
                {
                    Ingrediente? oIngrediente = Ingrediente.SelecionarPeloId(int.Parse(TxtId.Text));
                    if(oIngrediente!=null)
                    {
                        oIngrediente.Nome = TxtNome.Text;
                        oIngrediente.Descricao = TxtDescricao.Text;
                    }
                }
                LimpaControles();
                GrdItensIngrediente.DataSource = Ingrediente.SelecionarTodos();
            }

        }

        private void GrdItensIngrediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItensIngrediente.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdItensIngrediente.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Ingrediente oIngrediente = (Ingrediente)GrdItensIngrediente.Rows[e.RowIndex].DataBoundItem;
                    TxtId.Text = oIngrediente.Id.ToString();
                    TxtNome.Text = oIngrediente.Nome;
                    TxtDescricao.Text = oIngrediente.Descricao;

                }
                if (GrdItensIngrediente.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if(MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        Ingrediente oIngrediente = (Ingrediente)GrdItensIngrediente.Rows[e.RowIndex].DataBoundItem;
                        Ingrediente.Excluir(oIngrediente.Id);
                        GrdItensIngrediente.DataSource = Ingrediente.SelecionarTodos();
                    }
                }
            }
        }
    }
}

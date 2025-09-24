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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        /* 
         função genérica para abrir um formulário único dentro do MDI container.
        */
        private void AbrirFormularioUnico<T>() where T : Form, new()
        {
            T? formExistente = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (formExistente != null)
            {
                formExistente.BringToFront();
                formExistente.Focus();
            }
            else
            {
                T form = new T();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void cadastrarIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormularioUnico<FormCadastrarIngrediente>();
        }

        private void cadastrarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormCadastrarReceita>();
        }

        private void cadastrarCozinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormCadastrarCozinha>();
        }

        private void cadastrarTipoDeReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormConsultarReceita>();
        }

        private void detalhesDaReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormDetalhesReceitas>();
        }
    }
}

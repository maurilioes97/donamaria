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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        /* função genérica para abrir um formulário único dentro do MDI container. */
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

        private void MnuIngredientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormCadastrarIngrediente>();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarReceitaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormCadastrarReceita>();
        }

        private void cadastrarCozinhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormCadastrarCozinha>();
        }

        private void consultarDetalhesReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormDetalhesReceitas>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void consltarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioUnico<FormConsultarReceita>();
        }
    }
}
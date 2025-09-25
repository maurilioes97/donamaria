using CasodeUsoDonamaria.Model;
using System;
using System.Windows.Forms;

namespace CasodeUsoDonamaria
{
    public partial class FormConsultarReceita : Form
    {
        /// <summary>
        /// Método de inicialização da instância do formulário.
        /// </summary>
        public FormConsultarReceita()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para executar ações pós evento de inicio do formulário. (Carregar dados das receitas no grid).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormConsultarReceita_Load(object sender, EventArgs e)
        {
            GrdLocalizar.AutoGenerateColumns = false;

            // Configura a coluna de imagem
            if (GrdLocalizar.Columns["datagridview_imagem"] is DataGridViewImageColumn imgCol)
            {
                imgCol.DataPropertyName = "Imagem"; // liga à propriedade Imagem da classe Receita
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            GrdLocalizar.DataSource = FormCadastrarReceita.listaReceitas;
        }

        /// <summary>
        /// Método para executar ação após evento click no botão pesquisar. (Localizar Texto se contém caracteres do textbox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            {
                string textoPesquisa = TxtLocalizar.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(textoPesquisa))
                {
                    // Se não digitou nada, mostra todas as receitas
                    GrdLocalizar.DataSource = FormCadastrarReceita.listaReceitas;
                }
                else
                {
                    // Filtra a lista por nome da receita ou ingrediente
                    var resultados = FormCadastrarReceita.listaReceitas
                        .Where(r => r.Nome.ToLower().Contains(textoPesquisa) ||
                        r.Ingredientes.ToLower().Contains(textoPesquisa))
                        .ToList();

                    // Atualiza o DataGridView
                    GrdLocalizar.DataSource = resultados;
                }
            }
        }

        
    }
}


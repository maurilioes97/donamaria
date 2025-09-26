using CasodeUsoDonamaria.Model;
using System;
using System.Windows.Forms;

namespace CasodeUsoDonamaria
{
    public partial class FormConsultarReceita : Form
    {
        /// <summary>
        /// M�todo de inicializa��o da inst�ncia do formul�rio.
        /// </summary>
        public FormConsultarReceita()
        {
            InitializeComponent();
        }

        /// <summary>
        /// M�todo para executar a��es p�s evento de inicio do formul�rio. (Carregar dados das receitas no grid).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormConsultarReceita_Load(object sender, EventArgs e)
        {
            GrdLocalizar.AutoGenerateColumns = false;

            // Configura a coluna de imagem
            if (GrdLocalizar.Columns["datagridview_imagem"] is DataGridViewImageColumn imgCol)
            {
                imgCol.DataPropertyName = "Imagem"; // liga � propriedade Imagem da classe Receita
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            GrdLocalizar.DataSource = FormCadastrarReceita.listaReceitas;
        }

        /// <summary>
        /// M�todo para executar a��o ap�s evento click no bot�o pesquisar. (Localizar Texto se cont�m caracteres do textbox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            {
                string textoPesquisa = TxtLocalizar.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(textoPesquisa))
                {
                    // Se n�o digitou nada, mostra todas as receitas
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

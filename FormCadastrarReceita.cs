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
    public partial class FormCadastrarReceita : Form
    {
        private int indexEditando = -1;

        public FormCadastrarReceita()
        {
            InitializeComponent();

        }
        private List<Receita> listaReceitas = new List<Receita>();
        private string imagemSelecionada = "";

        private void Btn_imagem_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            // Apenas executa se o usuário selecionar um arquivo e clicar em OK
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagemSelecionada = openFile.FileName; // pega o caminho do arquivo
                picImagem.Image = Image.FromFile(imagemSelecionada); // carrega a imagem
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private int proximoCodigo = 1; // contador de códigos

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            // 1. Validação
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da receita.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_modopreparo.Text))
            {
                MessageBox.Show("Informe o modo de preparo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIngredientes.Text))
            {
                MessageBox.Show("Informe os ingredientes necessários.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verifica se está editando ou criando
            if (indexEditando >= 0)
            {
                // Atualizar receita existente
                Receita receita = listaReceitas[indexEditando];
                receita.Nome = txtNome.Text;
                receita.Ingredientes = txtIngredientes.Text;
                receita.ModoPreparo = Txt_modopreparo.Text;
                receita.Imagem = picImagem.Image;

                // Atualiza DataGridView
                var row = datagridview.Rows[indexEditando];
                row.Cells["datagridview_nome"].Value = receita.Nome;
                row.Cells["datagridview_ingredientes"].Value = receita.Ingredientes;
                row.Cells["datagridview_modopreparo"].Value = receita.ModoPreparo;
                row.Cells["datagridview_imagem"].Value = receita.Imagem;
            }
            else
            {
                // Criar nova receita
                Receita novaReceita = new Receita()
                {
                    Codigo = proximoCodigo++, // gera novo código
                    Nome = txtNome.Text,
                    Ingredientes = txtIngredientes.Text,
                    ModoPreparo = Txt_modopreparo.Text,
                    Imagem = picImagem.Image
                };

                listaReceitas.Add(novaReceita);

                // Adiciona nova linha no DataGridView
                datagridview.Rows.Add(
                    novaReceita.Imagem,
                    novaReceita.Codigo,
                    novaReceita.Nome,
                    novaReceita.Ingredientes,
                    novaReceita.ModoPreparo,
                    "Alterar",
                    "Excluir"
                );
            }

            // 3. Resetar edição e limpar os campos
            indexEditando = -1;
            Btn_salvar.Text = "Salvar";

            txtCodigo.Clear();
            txtNome.Clear();
            txtIngredientes.Clear();
            Txt_modopreparo.Clear();
            picImagem.Image = null;
            imagemSelecionada = "";
        }



        private void FormCadastrarReceita_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            datagridview.AllowUserToAddRows = false;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview.RowTemplate.Height = 80;

            if (datagridview.Columns["Imagem"] is DataGridViewImageColumn colunaImg)
            {
                colunaImg.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            //Para arrumar a imagem na célula.
            datagridview.RowTemplate.Height = 80;
            datagridview_imagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        
            
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = datagridview.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "datagridview_excluir")
            {
                if (MessageBox.Show("Deseja excluir esta receita?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Remove da lista e do grid
                    listaReceitas.RemoveAt(e.RowIndex);
                    datagridview.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (nomeColuna == "datagridview_alterar")
            {
                Receita receitaSelecionada = listaReceitas[e.RowIndex];

                txtCodigo.Text = receitaSelecionada.Codigo.ToString();
                txtNome.Text = receitaSelecionada.Nome;
                txtIngredientes.Text = receitaSelecionada.Ingredientes;
                Txt_modopreparo.Text = receitaSelecionada.ModoPreparo;
                picImagem.Image = receitaSelecionada.Imagem;
                var img = datagridview.Rows[e.RowIndex].Cells["datagridview_imagem"].Value as Image;
                picImagem.Image = img;

                // opcional: marcar modo edição
                indexEditando = e.RowIndex;
                Btn_salvar.Text = "Atualizar";

                if (e.RowIndex < 0) return;
                var col = datagridview.Columns[e.ColumnIndex];
                MessageBox.Show($"Clicou: colunaIndex={e.ColumnIndex}, Name='{col.Name}', HeaderText='{col.HeaderText}'");
            }
        }

    }
}


    











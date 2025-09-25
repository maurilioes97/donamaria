using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CasodeUsoDonamaria.Model;

namespace CasodeUsoDonamaria
{
    public partial class FormCadastrarReceita : Form
    {
        private int indexEditando = -1; // controle de edição
        public static BindingList<Receita> listaReceitas = new BindingList<Receita>();
        private string imagemSelecionada = "";
        private int proximoCodigo = 1;

        public FormCadastrarReceita()
        {
            InitializeComponent();
        }

        private void FormCadastrarReceita_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            datagridview.AutoGenerateColumns = false;
            datagridview.DataSource = listaReceitas;
        }

        public void ConfigurarDataGridView()
        {
            datagridview.AllowUserToAddRows = false;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview.RowTemplate.Height = 80;

            if (datagridview.Columns["datagridview_imagem"] is DataGridViewImageColumn colunaImg)
            {
                colunaImg.DataPropertyName = "Imagem"; // liga a coluna à propriedade Imagem
                colunaImg.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void Btn_imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagemSelecionada = openFile.FileName;
                picImagem.Image = Image.FromFile(imagemSelecionada);
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Informe os ingredientes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (indexEditando >= 0)
            {
                // Atualiza receita existente
                Receita receita = listaReceitas[indexEditando];
                receita.Nome = txtNome.Text;
                receita.Ingredientes = txtIngredientes.Text;
                receita.ModoPreparo = Txt_modopreparo.Text;
                receita.Imagem = picImagem.Image;
            }
            else
            {
                // Adiciona nova receita
                Receita novaReceita = new Receita()
                {
                    Codigo = proximoCodigo++,
                    Nome = txtNome.Text,
                    Ingredientes = txtIngredientes.Text,
                    ModoPreparo = Txt_modopreparo.Text,
                    Imagem = picImagem.Image
                };

                listaReceitas.Add(novaReceita);
            }

            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtIngredientes.Clear();
            Txt_modopreparo.Clear();
            picImagem.Image = null;
            imagemSelecionada = "";
            indexEditando = -1;
            Btn_salvar.Text = "Salvar";
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = datagridview.Columns[e.ColumnIndex].Name;
            Receita receitaSelecionada = datagridview.Rows[e.RowIndex].DataBoundItem as Receita;
            if (receitaSelecionada == null) return;

            if (nomeColuna == "datagridview_excluir")
            {
                if (MessageBox.Show("Deseja excluir esta receita?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaReceitas.Remove(receitaSelecionada);
                }
            }
            else if (nomeColuna == "datagridview_alterar")
            {
                // Preenche formulário com os dados da receita
                txtCodigo.Text = receitaSelecionada.Codigo.ToString();
                txtNome.Text = receitaSelecionada.Nome;
                txtIngredientes.Text = receitaSelecionada.Ingredientes;
                Txt_modopreparo.Text = receitaSelecionada.ModoPreparo;
                picImagem.Image = receitaSelecionada.Imagem;

                indexEditando = listaReceitas.IndexOf(receitaSelecionada);
                Btn_salvar.Text = "Atualizar";
            }
        }
    }
}
















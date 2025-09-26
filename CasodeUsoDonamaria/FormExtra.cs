using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing; // Adicionado para usar Size, Point, etc. se necessário no futuro.

namespace FormExtra
{
    // A classe principal FormCardapio
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
            MainMenuStrip = menuStrip1;
        }

        #region Manipuladores de Arquivo (Salvar)

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // 💡 Melhoria: Usando 'using' para garantir que o SaveFileDialog seja liberado.
                using (SaveFileDialog salvar = new SaveFileDialog
                {
                    Filter = "Arquivo de Texto|*.txt",
                    Title = "Salvar Cardápio",
                    FileName = "cardapio.txt"
                })
                {
                    if (salvar.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(salvar.FileName, rtbCardapio.Text, System.Text.Encoding.UTF8);

                        File.WriteAllText(salvar.FileName, rtbCardapio.Text);

                        MessageBox.Show("Cardápio salvo com sucesso!",
                                        "Cozinha da Dona Maria",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Manipuladores de Cardápio (Adicionar Prato)

        private void AdicionarPrato(string dia)
        {
            string prato = InputHelper.ShowInputDialog($"Adicionar Prato - {dia}", $"Qual prato para {dia}?");

            if (!string.IsNullOrWhiteSpace(prato) && prato.Length <= 100)
            {
                rtbCardapio.AppendText($"{dia}: {prato}{Environment.NewLine}");
            }
        }

        // 🔹 Eventos dos menus chamando o método genérico (Estão perfeitos!)
        private void segundafeiraToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Segunda-feira");
        private void tercafeiraToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Terça-feira");
        private void quartafeiraToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Quarta-feira");
        private void quintafeiraToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Quinta-feira");
        private void sextafeiraToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Sexta-feira");
        private void sabadoToolStripMenuItem_Click(object sender, EventArgs e) => AdicionarPrato("Sábado");
        private void especialToolStripMenuItem1_Click(object sender, EventArgs e) => AdicionarPrato("Especial");

        #endregion
    }

    public static class InputHelper
    {
        public static string ShowInputDialog(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 350,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 10, Top = 10, Text = prompt, AutoSize = true };

            TextBox textBox = new TextBox { Width = 300, Left = 10, Top = 35 };

            Button okButton = new Button { Text = "OK", DialogResult = DialogResult.OK, Left = 220, Top = 70 };

            promptForm.AcceptButton = okButton;

            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(okButton);
            promptForm.Controls.Add(textLabel);

            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                return textBox.Text;
            }

            return string.Empty;
        }
    }
}
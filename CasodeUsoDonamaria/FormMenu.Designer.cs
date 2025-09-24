namespace CasodeUsoDonamaria
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarIngredienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarReceitaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCozinhaToolStripMenuItem = new ToolStripMenuItem();
            consultarReceitaToolStripMenuItem = new ToolStripMenuItem();
            detalhesDaReceitaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(600, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarIngredienteToolStripMenuItem, cadastrarReceitaToolStripMenuItem, cadastrarCozinhaToolStripMenuItem, consultarReceitaToolStripMenuItem, detalhesDaReceitaToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(50, 22);
            cadastrarToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarIngredienteToolStripMenuItem
            // 
            cadastrarIngredienteToolStripMenuItem.Name = "cadastrarIngredienteToolStripMenuItem";
            cadastrarIngredienteToolStripMenuItem.Size = new Size(187, 22);
            cadastrarIngredienteToolStripMenuItem.Text = "Cadastrar Ingrediente";
            cadastrarIngredienteToolStripMenuItem.Click += cadastrarIngredienteToolStripMenuItem_Click;
            // 
            // cadastrarReceitaToolStripMenuItem
            // 
            cadastrarReceitaToolStripMenuItem.Name = "cadastrarReceitaToolStripMenuItem";
            cadastrarReceitaToolStripMenuItem.Size = new Size(187, 22);
            cadastrarReceitaToolStripMenuItem.Text = "Cadastrar Receita";
            cadastrarReceitaToolStripMenuItem.Click += cadastrarReceitaToolStripMenuItem_Click;
            // 
            // cadastrarCozinhaToolStripMenuItem
            // 
            cadastrarCozinhaToolStripMenuItem.Name = "cadastrarCozinhaToolStripMenuItem";
            cadastrarCozinhaToolStripMenuItem.Size = new Size(187, 22);
            cadastrarCozinhaToolStripMenuItem.Text = "Cadastrar Cozinha";
            cadastrarCozinhaToolStripMenuItem.Click += cadastrarCozinhaToolStripMenuItem_Click;
            // 
            // consultarReceitaToolStripMenuItem
            // 
            consultarReceitaToolStripMenuItem.Name = "consultarReceitaToolStripMenuItem";
            consultarReceitaToolStripMenuItem.Size = new Size(187, 22);
            consultarReceitaToolStripMenuItem.Text = "Consultar Receita";
            consultarReceitaToolStripMenuItem.Click += consultarReceitaToolStripMenuItem_Click;
            // 
            // detalhesDaReceitaToolStripMenuItem
            // 
            detalhesDaReceitaToolStripMenuItem.Name = "detalhesDaReceitaToolStripMenuItem";
            detalhesDaReceitaToolStripMenuItem.Size = new Size(187, 22);
            detalhesDaReceitaToolStripMenuItem.Text = "Detalhes da Receita";
            detalhesDaReceitaToolStripMenuItem.Click += detalhesDaReceitaToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 283);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormMenu";
            Text = "Menu Cadastro dona Maria";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarIngredienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarReceitaToolStripMenuItem;
        private ToolStripMenuItem cadastrarCozinhaToolStripMenuItem;
        private ToolStripMenuItem consultarReceitaToolStripMenuItem;
        private ToolStripMenuItem detalhesDaReceitaToolStripMenuItem;
    }
}
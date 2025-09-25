namespace CasodeUsoDonamaria
{
    partial class FormPrincipal
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
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            MnuIngredientes = new ToolStripMenuItem();
            cadastrarReceitaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCozinhaToolStripMenuItem = new ToolStripMenuItem();
            consltarReceitaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuIngredientes, cadastrarReceitaToolStripMenuItem, cadastrarCozinhaToolStripMenuItem, consltarReceitaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // MnuIngredientes
            // 
            MnuIngredientes.Name = "MnuIngredientes";
            MnuIngredientes.Size = new Size(241, 26);
            MnuIngredientes.Text = "Cadastrar Ingredientes";
            MnuIngredientes.Click += MnuIngredientes_Click;
            // 
            // cadastrarReceitaToolStripMenuItem
            // 
            cadastrarReceitaToolStripMenuItem.Name = "cadastrarReceitaToolStripMenuItem";
            cadastrarReceitaToolStripMenuItem.Size = new Size(241, 26);
            cadastrarReceitaToolStripMenuItem.Text = "Cadastrar Receita";
            cadastrarReceitaToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            cadastrarReceitaToolStripMenuItem.Click += cadastrarReceitaToolStripMenuItem_Click_1;
            // 
            // cadastrarCozinhaToolStripMenuItem
            // 
            cadastrarCozinhaToolStripMenuItem.Name = "cadastrarCozinhaToolStripMenuItem";
            cadastrarCozinhaToolStripMenuItem.Size = new Size(241, 26);
            cadastrarCozinhaToolStripMenuItem.Text = "Cadastrar Cozinha";
            cadastrarCozinhaToolStripMenuItem.Click += cadastrarCozinhaToolStripMenuItem_Click_1;
            // 
            // consltarReceitaToolStripMenuItem
            // 
            consltarReceitaToolStripMenuItem.Name = "consltarReceitaToolStripMenuItem";
            consltarReceitaToolStripMenuItem.Size = new Size(241, 26);
            consltarReceitaToolStripMenuItem.Text = "Consltar Receita";
            consltarReceitaToolStripMenuItem.Click += consltarReceitaToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Cozinha da vovó";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem MnuIngredientes;
        private ToolStripMenuItem cadastrarReceitaToolStripMenuItem;
        private ToolStripMenuItem cadastrarCozinhaToolStripMenuItem;
        private ToolStripMenuItem consultarReceitaToolStripMenuItem;
        private ToolStripMenuItem cadastrarReceitaToolStripMenuItem1;
        private ToolStripMenuItem consltarReceitaToolStripMenuItem;
    }
}
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
            cadastrarTipoDeReceitaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarIngredienteToolStripMenuItem = new ToolStripMenuItem();
            cadastrarReceitaToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem1 = new ToolStripMenuItem();
            pesquisarToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(544, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarTipoDeReceitaToolStripMenuItem, cadastrarIngredienteToolStripMenuItem, cadastrarReceitaToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(73, 29);
            cadastrarToolStripMenuItem.Text = "Menu";
            cadastrarToolStripMenuItem.Click += this.cadastrarToolStripMenuItem_Click;
            // 
            // cadastrarTipoDeReceitaToolStripMenuItem
            // 
            cadastrarTipoDeReceitaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, pesquisarToolStripMenuItem });
            cadastrarTipoDeReceitaToolStripMenuItem.Name = "cadastrarTipoDeReceitaToolStripMenuItem";
            cadastrarTipoDeReceitaToolStripMenuItem.Size = new Size(314, 34);
            cadastrarTipoDeReceitaToolStripMenuItem.Text = "Cadastrar Tipo de Receita";
            cadastrarTipoDeReceitaToolStripMenuItem.Click += this.cadastrarTipoDeReceitaToolStripMenuItem_Click;
            // 
            // cadastrarIngredienteToolStripMenuItem
            // 
            cadastrarIngredienteToolStripMenuItem.Name = "cadastrarIngredienteToolStripMenuItem";
            cadastrarIngredienteToolStripMenuItem.Size = new Size(314, 34);
            cadastrarIngredienteToolStripMenuItem.Text = "Cadastrar Ingrediente";
            // 
            // cadastrarReceitaToolStripMenuItem
            // 
            cadastrarReceitaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem1, pesquisarToolStripMenuItem1 });
            cadastrarReceitaToolStripMenuItem.Name = "cadastrarReceitaToolStripMenuItem";
            cadastrarReceitaToolStripMenuItem.Size = new Size(314, 34);
            cadastrarReceitaToolStripMenuItem.Text = "Cadastrar Receita";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(270, 34);
            incluirToolStripMenuItem.Text = "Incluir";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(270, 34);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += this.pesquisarToolStripMenuItem_Click;
            // 
            // incluirToolStripMenuItem1
            // 
            incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            incluirToolStripMenuItem1.Size = new Size(270, 34);
            incluirToolStripMenuItem1.Text = "Incluir";
            // 
            // pesquisarToolStripMenuItem1
            // 
            pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            pesquisarToolStripMenuItem1.Size = new Size(270, 34);
            pesquisarToolStripMenuItem1.Text = "Pesquisar";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 196);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem cadastrarTipoDeReceitaToolStripMenuItem;
        private ToolStripMenuItem cadastrarIngredienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarReceitaToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem1;
        private ToolStripMenuItem pesquisarToolStripMenuItem1;
    }
}
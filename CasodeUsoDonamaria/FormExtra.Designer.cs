namespace FormExtra
{
    partial class FormCardapio
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
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            segundafeiraToolStripMenuItem = new ToolStripMenuItem();
            tercafeiraToolStripMenuItem = new ToolStripMenuItem();
            quartafeiraToolStripMenuItem = new ToolStripMenuItem();
            quintafeiraToolStripMenuItem = new ToolStripMenuItem();
            sextafeiraToolStripMenuItem = new ToolStripMenuItem();
            sabadoToolStripMenuItem = new ToolStripMenuItem();
            especialToolStripMenuItem1 = new ToolStripMenuItem();
            BtnSalvar = new Button();
            rtbCardapio = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FloralWhite;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, segundafeiraToolStripMenuItem, tercafeiraToolStripMenuItem, quartafeiraToolStripMenuItem, quintafeiraToolStripMenuItem, sextafeiraToolStripMenuItem, sabadoToolStripMenuItem, especialToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, fecharToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(109, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(109, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            // 
            // segundafeiraToolStripMenuItem
            // 
            segundafeiraToolStripMenuItem.Name = "segundafeiraToolStripMenuItem";
            segundafeiraToolStripMenuItem.Size = new Size(93, 20);
            segundafeiraToolStripMenuItem.Text = "Segunda-feira";
            segundafeiraToolStripMenuItem.Click += segundafeiraToolStripMenuItem_Click;
            // 
            // tercafeiraToolStripMenuItem
            // 
            tercafeiraToolStripMenuItem.Name = "tercafeiraToolStripMenuItem";
            tercafeiraToolStripMenuItem.Size = new Size(75, 20);
            tercafeiraToolStripMenuItem.Text = "Terça-feira";
            tercafeiraToolStripMenuItem.Click += tercafeiraToolStripMenuItem_Click;
            // 
            // quartafeiraToolStripMenuItem
            // 
            quartafeiraToolStripMenuItem.Name = "quartafeiraToolStripMenuItem";
            quartafeiraToolStripMenuItem.Size = new Size(83, 20);
            quartafeiraToolStripMenuItem.Text = "Quarta-feira";
            quartafeiraToolStripMenuItem.Click += quartafeiraToolStripMenuItem_Click;
            // 
            // quintafeiraToolStripMenuItem
            // 
            quintafeiraToolStripMenuItem.Name = "quintafeiraToolStripMenuItem";
            quintafeiraToolStripMenuItem.Size = new Size(83, 20);
            quintafeiraToolStripMenuItem.Text = "Quinta-feira";
            quintafeiraToolStripMenuItem.Click += quintafeiraToolStripMenuItem_Click;
            // 
            // sextafeiraToolStripMenuItem
            // 
            sextafeiraToolStripMenuItem.Name = "sextafeiraToolStripMenuItem";
            sextafeiraToolStripMenuItem.Size = new Size(74, 20);
            sextafeiraToolStripMenuItem.Text = "Sexta-feira";
            sextafeiraToolStripMenuItem.Click += sextafeiraToolStripMenuItem_Click;
            // 
            // sabadoToolStripMenuItem
            // 
            sabadoToolStripMenuItem.Name = "sabadoToolStripMenuItem";
            sabadoToolStripMenuItem.Size = new Size(58, 20);
            sabadoToolStripMenuItem.Text = "Sábado";
            sabadoToolStripMenuItem.Click += sabadoToolStripMenuItem_Click;
            // 
            // especialToolStripMenuItem1
            // 
            especialToolStripMenuItem1.Name = "especialToolStripMenuItem1";
            especialToolStripMenuItem1.Size = new Size(61, 20);
            especialToolStripMenuItem1.Text = "Especial";
            especialToolStripMenuItem1.Click += especialToolStripMenuItem1_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(716, 48);
            BtnSalvar.Margin = new Padding(4, 3, 4, 3);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(173, 27);
            BtnSalvar.TabIndex = 2;
            BtnSalvar.Text = "Salvar Cardápio";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // rtbCardapio
            // 
            rtbCardapio.Location = new Point(14, 48);
            rtbCardapio.Margin = new Padding(4, 3, 4, 3);
            rtbCardapio.Name = "rtbCardapio";
            rtbCardapio.Size = new Size(684, 205);
            rtbCardapio.TabIndex = 3;
            rtbCardapio.Text = "";
            // 
            // FormCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(rtbCardapio);
            Controls.Add(BtnSalvar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCardapio";
            Text = "Cardápio Diário";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundafeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercafeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartafeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quintafeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sextafeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialToolStripMenuItem1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.RichTextBox rtbCardapio;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}


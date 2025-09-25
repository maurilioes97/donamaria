namespace CasodeUsoDonamaria
{
    partial class FormConsultarReceita
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblLocalizar = new Label();
            TxtLocalizar = new TextBox();
            BtnLocalizar = new Button();
            GrdLocalizar = new DataGridView();
            Imagem = new DataGridViewImageColumn();
            nomedareceita = new DataGridViewTextBoxColumn();
            ModoPreparo = new DataGridViewTextBoxColumn();
            Ingredientes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GrdLocalizar).BeginInit();
            SuspendLayout();
            // 
            // LblLocalizar
            // 
            LblLocalizar.AutoSize = true;
            LblLocalizar.Location = new Point(21, 19);
            LblLocalizar.Margin = new Padding(2, 0, 2, 0);
            LblLocalizar.Name = "LblLocalizar";
            LblLocalizar.Size = new Size(207, 20);
            LblLocalizar.TabIndex = 0;
            LblLocalizar.Text = "Critérios para localizar receita";
            // 
            // TxtLocalizar
            // 
            TxtLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtLocalizar.Location = new Point(21, 41);
            TxtLocalizar.Margin = new Padding(2, 3, 2, 3);
            TxtLocalizar.Name = "TxtLocalizar";
            TxtLocalizar.Size = new Size(1406, 27);
            TxtLocalizar.TabIndex = 1;
            // 
            // BtnLocalizar
            // 
            BtnLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnLocalizar.Location = new Point(21, 69);
            BtnLocalizar.Margin = new Padding(2, 3, 2, 3);
            BtnLocalizar.Name = "BtnLocalizar";
            BtnLocalizar.Size = new Size(1405, 33);
            BtnLocalizar.TabIndex = 2;
            BtnLocalizar.Text = "Localizar receita";
            BtnLocalizar.UseVisualStyleBackColor = true;
            BtnLocalizar.Click += BtnLocalizar_Click;
            // 
            // GrdLocalizar
            // 
            GrdLocalizar.AllowUserToAddRows = false;
            GrdLocalizar.AllowUserToDeleteRows = false;
            GrdLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdLocalizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdLocalizar.Columns.AddRange(new DataGridViewColumn[] { Imagem, nomedareceita, ModoPreparo, Ingredientes });
            GrdLocalizar.Location = new Point(11, 131);
            GrdLocalizar.Margin = new Padding(2, 3, 2, 3);
            GrdLocalizar.Name = "GrdLocalizar";
            GrdLocalizar.RowHeadersVisible = false;
            GrdLocalizar.RowHeadersWidth = 62;
            GrdLocalizar.RowTemplate.Height = 500;
            GrdLocalizar.Size = new Size(1416, 1416);
            GrdLocalizar.TabIndex = 3;
            // 
            // Imagem
            // 
            Imagem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Imagem.DataPropertyName = "Imagem";
            Imagem.FillWeight = 200F;
            Imagem.HeaderText = "Imagem";
            Imagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagem.MinimumWidth = 60;
            Imagem.Name = "Imagem";
            Imagem.Resizable = DataGridViewTriState.True;
            // 
            // nomedareceita
            // 
            nomedareceita.DataPropertyName = "Nome";
            nomedareceita.HeaderText = "Nome da receita";
            nomedareceita.MinimumWidth = 8;
            nomedareceita.Name = "nomedareceita";
            nomedareceita.Width = 400;
            // 
            // ModoPreparo
            // 
            ModoPreparo.DataPropertyName = "ModoPreparo";
            ModoPreparo.HeaderText = "Modo de preparo";
            ModoPreparo.MinimumWidth = 8;
            ModoPreparo.Name = "ModoPreparo";
            ModoPreparo.Width = 500;
            // 
            // Ingredientes
            // 
            Ingredientes.DataPropertyName = "Ingredientes";
            Ingredientes.HeaderText = "Ingredientes";
            Ingredientes.MinimumWidth = 6;
            Ingredientes.Name = "Ingredientes";
            Ingredientes.Width = 400;
            // 
            // FormConsultarReceita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 850);
            Controls.Add(GrdLocalizar);
            Controls.Add(BtnLocalizar);
            Controls.Add(TxtLocalizar);
            Controls.Add(LblLocalizar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormConsultarReceita";
            Text = "Consultar receitas";
            WindowState = FormWindowState.Maximized;
            Load += FormConsultarReceita_Load;
            ((System.ComponentModel.ISupportInitialize)GrdLocalizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLocalizar;
        private TextBox TxtLocalizar;
        private Button BtnLocalizar;
        private DataGridView GrdLocalizar;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn nomedareceita;
        private DataGridViewTextBoxColumn ModoPreparo;
        private DataGridViewTextBoxColumn Ingredientes;
    }
}

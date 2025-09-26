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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            LblLocalizar.Location = new Point(18, 14);
            LblLocalizar.Margin = new Padding(2, 0, 2, 0);
            LblLocalizar.Name = "LblLocalizar";
            LblLocalizar.Size = new Size(161, 15);
            LblLocalizar.TabIndex = 0;
            LblLocalizar.Text = "Critérios para localizar receita";
            // 
            // TxtLocalizar
            // 
            TxtLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtLocalizar.Location = new Point(18, 31);
            TxtLocalizar.Margin = new Padding(2, 2, 2, 2);
            TxtLocalizar.Name = "TxtLocalizar";
            TxtLocalizar.Size = new Size(1231, 23);
            TxtLocalizar.TabIndex = 1;
            // 
            // BtnLocalizar
            // 
            BtnLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnLocalizar.Location = new Point(18, 69);
            BtnLocalizar.Margin = new Padding(2, 2, 2, 2);
            BtnLocalizar.Name = "BtnLocalizar";
            BtnLocalizar.Size = new Size(1229, 25);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GrdLocalizar.DefaultCellStyle = dataGridViewCellStyle1;
            GrdLocalizar.Location = new Point(10, 117);
            GrdLocalizar.Margin = new Padding(2, 2, 2, 2);
            GrdLocalizar.Name = "GrdLocalizar";
            GrdLocalizar.RowHeadersVisible = false;
            GrdLocalizar.RowHeadersWidth = 62;
            GrdLocalizar.RowTemplate.Height = 250;
            GrdLocalizar.Size = new Size(1239, 1043);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 565);
            Controls.Add(GrdLocalizar);
            Controls.Add(BtnLocalizar);
            Controls.Add(TxtLocalizar);
            Controls.Add(LblLocalizar);
            Margin = new Padding(2, 2, 2, 2);
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
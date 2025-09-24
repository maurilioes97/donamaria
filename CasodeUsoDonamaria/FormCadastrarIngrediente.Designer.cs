namespace CasodeUsoDonamaria
{
    partial class FormCadastrarIngrediente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtDescricao = new TextBox();
            GrdItensIngrediente = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItensIngrediente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 69);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // button1
            // 
            button1.Location = new Point(26, 206);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 3;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(26, 30);
            TxtId.Margin = new Padding(2);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(180, 27);
            TxtId.TabIndex = 4;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(227, 30);
            TxtNome.Margin = new Padding(2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(614, 27);
            TxtNome.TabIndex = 5;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(26, 91);
            TxtDescricao.Margin = new Padding(2);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.ScrollBars = ScrollBars.Vertical;
            TxtDescricao.Size = new Size(815, 110);
            TxtDescricao.TabIndex = 6;
            // 
            // GrdItensIngrediente
            // 
            GrdItensIngrediente.AllowUserToAddRows = false;
            GrdItensIngrediente.AllowUserToDeleteRows = false;
            GrdItensIngrediente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensIngrediente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, BtnAlterar, BtnExcluir });
            GrdItensIngrediente.Location = new Point(10, 238);
            GrdItensIngrediente.Margin = new Padding(2);
            GrdItensIngrediente.Name = "GrdItensIngrediente";
            GrdItensIngrediente.RowHeadersWidth = 62;
            GrdItensIngrediente.Size = new Size(875, 258);
            GrdItensIngrediente.TabIndex = 7;
            GrdItensIngrediente.CellClick += GrdItensIngrediente_CellClick;
            GrdItensIngrediente.CellContentClick += GrdItensIngrediente_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Nome";
            Column2.HeaderText = "Nome";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Descricao";
            Column3.HeaderText = "Descrição";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 8;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 125;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 8;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 125;
            // 
            // FormCadastrarIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 507);
            Controls.Add(GrdItensIngrediente);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormCadastrarIngrediente";
            Text = "Cadastrar Ingrediente";
            Load += FormCadastrarIngrediente_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensIngrediente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtDescricao;
        private DataGridView GrdItensIngrediente;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}
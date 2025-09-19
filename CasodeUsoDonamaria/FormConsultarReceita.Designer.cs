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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            nomedareceita = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            Column1 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "Critérios para localizar receita";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(25, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(965, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(25, 88);
            button1.Name = "button1";
            button1.Size = new Size(965, 41);
            button1.TabIndex = 2;
            button1.Text = "Localizar receita";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomedareceita, descricao, Column2, Column1 });
            dataGridView1.Location = new Point(25, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(965, 327);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nomedareceita
            // 
            nomedareceita.HeaderText = "Nome da receita";
            nomedareceita.MinimumWidth = 8;
            nomedareceita.Name = "nomedareceita";
            nomedareceita.Width = 200;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 8;
            descricao.Name = "descricao";
            descricao.Width = 400;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Alterar";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            Column2.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Excluir";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // FormConsultarReceita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 485);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormConsultarReceita";
            Text = "Consultar receitas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomedareceita;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewButtonColumn Column2;
        private DataGridViewButtonColumn Column1;
    }
}

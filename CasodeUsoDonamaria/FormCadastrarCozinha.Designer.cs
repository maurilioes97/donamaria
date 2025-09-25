namespace CasodeUsoDonamaria
{
    partial class FormCadastrarCozinha
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Column5 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 64);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(24, 159);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 20);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, descricao, Column4, Column5 });
            dataGridView1.Location = new Point(11, 192);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(840, 118);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(24, 34);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(140, 34);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(548, 23);
            txtNome.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(24, 81);
            txtDescricao.Margin = new Padding(2);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(664, 74);
            txtDescricao.TabIndex = 7;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            // 
            // nome
            // 
            nome.DataPropertyName = "Nome";
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 8;
            nome.Name = "nome";
            nome.Width = 150;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 8;
            descricao.Name = "descricao";
            descricao.Width = 250;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "alterar";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            Column4.DefaultCellStyle = dataGridViewCellStyle1;
            Column4.HeaderText = "Alterar";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "excluir";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.HeaderText = "Excluir";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormCadastrarCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 356);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormCadastrarCozinha";
            Text = "Cadastrar Tipo de Cozinha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalvar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
    }
}
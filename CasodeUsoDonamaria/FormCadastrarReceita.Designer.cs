namespace CasodeUsoDonamaria
{
    partial class FormCadastrarReceita
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            label5 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            label6 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            dataGridView3 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, -2);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, -2);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrediente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(499, 31);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(3, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(617, 159);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(508, 86);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Detalhes";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Adicionar";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6 });
            dataGridView2.Location = new Point(3, 315);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(617, 152);
            dataGridView2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(3, 595);
            button2.Name = "button2";
            button2.Size = new Size(1118, 45);
            button2.TabIndex = 10;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 287);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 11;
            label5.Text = "Ingredientes da receita";
            // 
            // Column5
            // 
            Column5.HeaderText = "Nome";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Excluir";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 470);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 12;
            label6.Text = "Modo de Preparo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 498);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1118, 91);
            textBox4.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(635, 235);
            button3.Name = "button3";
            button3.Size = new Size(271, 35);
            button3.TabIndex = 14;
            button3.Text = "Carregar imagem da receita...";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(635, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 191);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(635, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(301, 31);
            textBox5.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(635, -2);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 18;
            label4.Text = "Tipo de Cozinha";
            // 
            // button4
            // 
            button4.Location = new Point(942, 25);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 19;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dataGridView3.Location = new Point(635, 65);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(486, 164);
            dataGridView3.TabIndex = 20;
            // 
            // Column7
            // 
            Column7.HeaderText = "Código";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Nome";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Detalhes";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.HeaderText = "";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 40;
            // 
            // FormCadastrarReceita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 640);
            Controls.Add(dataGridView3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastrarReceita";
            Text = "Cadastrar Receita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridView dataGridView2;
        private Button button2;
        private Label label5;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private Label label6;
        private TextBox textBox4;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label4;
        private Button button4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewCheckBoxColumn Column10;
    }
}
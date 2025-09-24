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
            Lbl_codigo = new Label();
            Lbl_nome = new Label();
            Lbl_ingredientes = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            Btn_salvar = new Button();
            label6 = new Label();
            Txt_modopreparo = new TextBox();
            Btn_imagem = new Button();
            picImagem = new PictureBox();
            txtIngredientes = new TextBox();
            datagridview = new DataGridView();
            datagridview_imagem = new DataGridViewImageColumn();
            datagridview_codigo = new DataGridViewTextBoxColumn();
            datagridview_nome = new DataGridViewTextBoxColumn();
            datagridview_ingredientes = new DataGridViewTextBoxColumn();
            datagridview_modopreparo = new DataGridViewTextBoxColumn();
            datagridview_alterar = new DataGridViewButtonColumn();
            datagridview_excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            SuspendLayout();
            // 
            // Lbl_codigo
            // 
            Lbl_codigo.AutoSize = true;
            Lbl_codigo.Location = new Point(10, 7);
            Lbl_codigo.Margin = new Padding(2, 0, 2, 0);
            Lbl_codigo.Name = "Lbl_codigo";
            Lbl_codigo.Size = new Size(46, 15);
            Lbl_codigo.TabIndex = 0;
            Lbl_codigo.Text = "Código";
            // 
            // Lbl_nome
            // 
            Lbl_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Lbl_nome.AutoSize = true;
            Lbl_nome.Location = new Point(126, 7);
            Lbl_nome.Margin = new Padding(2, 0, 2, 0);
            Lbl_nome.Name = "Lbl_nome";
            Lbl_nome.Size = new Size(40, 15);
            Lbl_nome.TabIndex = 1;
            Lbl_nome.Text = "Nome";
            // 
            // Lbl_ingredientes
            // 
            Lbl_ingredientes.AutoSize = true;
            Lbl_ingredientes.Location = new Point(10, 52);
            Lbl_ingredientes.Margin = new Padding(2, 0, 2, 0);
            Lbl_ingredientes.Name = "Lbl_ingredientes";
            Lbl_ingredientes.Size = new Size(72, 15);
            Lbl_ingredientes.TabIndex = 2;
            Lbl_ingredientes.Text = "Ingredientes";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(10, 23);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(106, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 23);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(652, 23);
            txtNome.TabIndex = 4;
            // 
            // Btn_salvar
            // 
            Btn_salvar.Location = new Point(10, 248);
            Btn_salvar.Margin = new Padding(2);
            Btn_salvar.Name = "Btn_salvar";
            Btn_salvar.Size = new Size(768, 27);
            Btn_salvar.TabIndex = 10;
            Btn_salvar.Text = "Salvar";
            Btn_salvar.UseVisualStyleBackColor = true;
            Btn_salvar.Click += Btn_salvar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 12;
            label6.Text = "Modo de Preparo";
            // 
            // Txt_modopreparo
            // 
            Txt_modopreparo.Location = new Point(10, 142);
            Txt_modopreparo.Margin = new Padding(2);
            Txt_modopreparo.Multiline = true;
            Txt_modopreparo.Name = "Txt_modopreparo";
            Txt_modopreparo.Size = new Size(448, 84);
            Txt_modopreparo.TabIndex = 13;
            // 
            // Btn_imagem
            // 
            Btn_imagem.Location = new Point(526, 214);
            Btn_imagem.Margin = new Padding(2);
            Btn_imagem.Name = "Btn_imagem";
            Btn_imagem.Size = new Size(219, 30);
            Btn_imagem.TabIndex = 14;
            Btn_imagem.Text = "Carregar imagem da receita...";
            Btn_imagem.UseVisualStyleBackColor = true;
            Btn_imagem.Click += Btn_imagem_Click;
            // 
            // picImagem
            // 
            picImagem.Location = new Point(512, 68);
            picImagem.Margin = new Padding(2);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(243, 128);
            picImagem.TabIndex = 16;
            picImagem.TabStop = false;
            // 
            // txtIngredientes
            // 
            txtIngredientes.Location = new Point(10, 68);
            txtIngredientes.Margin = new Padding(2);
            txtIngredientes.Multiline = true;
            txtIngredientes.Name = "txtIngredientes";
            txtIngredientes.Size = new Size(448, 46);
            txtIngredientes.TabIndex = 21;
            // 
            // datagridview
            // 
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Columns.AddRange(new DataGridViewColumn[] { datagridview_imagem, datagridview_codigo, datagridview_nome, datagridview_ingredientes, datagridview_modopreparo, datagridview_alterar, datagridview_excluir });
            datagridview.Location = new Point(10, 288);
            datagridview.Margin = new Padding(2);
            datagridview.Name = "datagridview";
            datagridview.RowHeadersVisible = false;
            datagridview.RowHeadersWidth = 62;
            datagridview.Size = new Size(835, 209);
            datagridview.TabIndex = 24;
            datagridview.CellClick += datagridview_CellClick;
            // 
            // datagridview_imagem
            // 
            datagridview_imagem.HeaderText = "Imagem";
            datagridview_imagem.MinimumWidth = 6;
            datagridview_imagem.Name = "datagridview_imagem";
            datagridview_imagem.Width = 125;
            // 
            // datagridview_codigo
            // 
            datagridview_codigo.HeaderText = "Código";
            datagridview_codigo.MinimumWidth = 8;
            datagridview_codigo.Name = "datagridview_codigo";
            datagridview_codigo.Width = 80;
            // 
            // datagridview_nome
            // 
            datagridview_nome.HeaderText = "Nome";
            datagridview_nome.MinimumWidth = 8;
            datagridview_nome.Name = "datagridview_nome";
            datagridview_nome.Width = 125;
            // 
            // datagridview_ingredientes
            // 
            datagridview_ingredientes.HeaderText = "Ingredientes";
            datagridview_ingredientes.MinimumWidth = 6;
            datagridview_ingredientes.Name = "datagridview_ingredientes";
            datagridview_ingredientes.Width = 125;
            // 
            // datagridview_modopreparo
            // 
            datagridview_modopreparo.HeaderText = "Modo de preparo";
            datagridview_modopreparo.MinimumWidth = 6;
            datagridview_modopreparo.Name = "datagridview_modopreparo";
            datagridview_modopreparo.Width = 125;
            // 
            // datagridview_alterar
            // 
            datagridview_alterar.HeaderText = "Alterar";
            datagridview_alterar.MinimumWidth = 6;
            datagridview_alterar.Name = "datagridview_alterar";
            datagridview_alterar.Resizable = DataGridViewTriState.True;
            datagridview_alterar.SortMode = DataGridViewColumnSortMode.Automatic;
            datagridview_alterar.Width = 125;
            // 
            // datagridview_excluir
            // 
            datagridview_excluir.HeaderText = "Excluir";
            datagridview_excluir.MinimumWidth = 6;
            datagridview_excluir.Name = "datagridview_excluir";
            datagridview_excluir.Width = 125;
            // 
            // FormCadastrarReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 499);
            Controls.Add(datagridview);
            Controls.Add(txtIngredientes);
            Controls.Add(picImagem);
            Controls.Add(Btn_imagem);
            Controls.Add(Txt_modopreparo);
            Controls.Add(label6);
            Controls.Add(Btn_salvar);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(Lbl_ingredientes);
            Controls.Add(Lbl_nome);
            Controls.Add(Lbl_codigo);
            Margin = new Padding(2);
            Name = "FormCadastrarReceita";
            Text = "Cadastrar Receita";
            Load += FormCadastrarReceita_Load;
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_codigo;
        private Label Lbl_nome;
        private Label Lbl_ingredientes;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Button Btn_salvar;
        private Label label6;
        private TextBox Txt_modopreparo;
        private Button Btn_imagem;
        private PictureBox picImagem;
        private TextBox txtIngredientes;
        private DataGridView datagridview;
        private DataGridViewImageColumn datagridview_imagem;
        private DataGridViewTextBoxColumn datagridview_codigo;
        private DataGridViewTextBoxColumn datagridview_nome;
        private DataGridViewTextBoxColumn datagridview_ingredientes;
        private DataGridViewTextBoxColumn datagridview_modopreparo;
        private DataGridViewButtonColumn datagridview_alterar;
        private DataGridViewButtonColumn datagridview_excluir;
    }
}
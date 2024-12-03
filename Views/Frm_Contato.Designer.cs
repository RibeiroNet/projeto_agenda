namespace Projeto_Agenda.Views
{
    partial class Frm_Contato
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
            groupBox1 = new GroupBox();
            cmb_categoria = new ComboBox();
            button_alterar = new Button();
            button_excluir = new Button();
            button_cadastrar = new Button();
            txt_telefone = new TextBox();
            txt_contato = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DGV_contato = new DataGridView();
            button_voltar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_contato).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(cmb_categoria);
            groupBox1.Controls.Add(button_alterar);
            groupBox1.Controls.Add(button_excluir);
            groupBox1.Controls.Add(button_cadastrar);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Controls.Add(txt_contato);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 5);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(237, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar novo Contato";
            // 
            // cmb_categoria
            // 
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(4, 139);
            cmb_categoria.Margin = new Padding(3, 2, 3, 2);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(213, 23);
            cmb_categoria.TabIndex = 9;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // button_alterar
            // 
            button_alterar.Location = new Point(4, 166);
            button_alterar.Margin = new Padding(3, 2, 3, 2);
            button_alterar.Name = "button_alterar";
            button_alterar.Size = new Size(95, 32);
            button_alterar.TabIndex = 8;
            button_alterar.Text = "Alterar";
            button_alterar.UseVisualStyleBackColor = true;
            button_alterar.Click += button_alterar_Click;
            // 
            // button_excluir
            // 
            button_excluir.Location = new Point(122, 166);
            button_excluir.Margin = new Padding(3, 2, 3, 2);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new Size(95, 32);
            button_excluir.TabIndex = 7;
            button_excluir.Text = "Excluir";
            button_excluir.UseVisualStyleBackColor = true;
            button_excluir.Click += button_excluir_Click;
            // 
            // button_cadastrar
            // 
            button_cadastrar.Location = new Point(14, 214);
            button_cadastrar.Margin = new Padding(3, 2, 3, 2);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(204, 32);
            button_cadastrar.TabIndex = 6;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = true;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(4, 87);
            txt_telefone.Margin = new Padding(3, 2, 3, 2);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(213, 23);
            txt_telefone.TabIndex = 4;
            txt_telefone.TextChanged += textBox2_TextChanged;
            // 
            // txt_contato
            // 
            txt_contato.Location = new Point(5, 35);
            txt_contato.Margin = new Padding(3, 2, 3, 2);
            txt_contato.Name = "txt_contato";
            txt_contato.Size = new Size(213, 23);
            txt_contato.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Contato";
            // 
            // DGV_contato
            // 
            DGV_contato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_contato.Location = new Point(274, 5);
            DGV_contato.Margin = new Padding(3, 2, 3, 2);
            DGV_contato.Name = "DGV_contato";
            DGV_contato.RowHeadersWidth = 51;
            DGV_contato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_contato.Size = new Size(239, 250);
            DGV_contato.TabIndex = 1;
            DGV_contato.CellContentClick += DGV_contato_CellContentClick;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(358, 260);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(155, 32);
            button_voltar.TabIndex = 5;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // Frm_Contato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._03_Pag_contatos_anuncio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 295);
            Controls.Add(button_voltar);
            Controls.Add(DGV_contato);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Contato";
            Text = "Frm_Contato";
            Load += Frm_Contato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_contato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_telefone;
        private TextBox txt_contato;
        private Button button_alterar;
        private Button button_excluir;
        private Button button_cadastrar;
        private DataGridView DGV_contato;
        private ComboBox cmb_categoria;
        private Button button_voltar;
    }
}
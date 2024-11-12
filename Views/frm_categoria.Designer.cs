namespace Projeto_Agenda.Views
{
    partial class frm_categoria
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
            button_cadastrar = new Button();
            textbox_categoria = new TextBox();
            DGV_categoria = new DataGridView();
            button_excluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_categoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_cadastrar);
            groupBox1.Controls.Add(textbox_categoria);
            groupBox1.Location = new Point(40, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button_cadastrar
            // 
            button_cadastrar.Location = new Point(5, 94);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(280, 51);
            button_cadastrar.TabIndex = 1;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = true;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // textbox_categoria
            // 
            textbox_categoria.Location = new Point(18, 45);
            textbox_categoria.Name = "textbox_categoria";
            textbox_categoria.Size = new Size(249, 23);
            textbox_categoria.TabIndex = 0;
            // 
            // DGV_categoria
            // 
            DGV_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_categoria.Location = new Point(417, 12);
            DGV_categoria.Name = "DGV_categoria";
            DGV_categoria.Size = new Size(291, 404);
            DGV_categoria.TabIndex = 1;
            DGV_categoria.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_excluir
            // 
            button_excluir.Location = new Point(75, 347);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new Size(214, 52);
            button_excluir.TabIndex = 2;
            button_excluir.Text = "Excluir";
            button_excluir.UseVisualStyleBackColor = true;
            button_excluir.Click += button_excluir_Click;
            // 
            // frm_categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._03_Pag_contatos_anuncio;
            ClientSize = new Size(800, 450);
            Controls.Add(button_excluir);
            Controls.Add(DGV_categoria);
            Controls.Add(groupBox1);
            Name = "frm_categoria";
            Text = "frm_categoria";
            Load += frm_categoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_categoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_cadastrar;
        private TextBox textbox_categoria;
        private DataGridView DGV_categoria;
        private Button button_excluir;
    }
}
namespace Projeto_Agenda.Views
{
    partial class frm_usuário
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
            DGV_usuario = new DataGridView();
            button_excluir_usuario = new Button();
            groupBox1 = new GroupBox();
            button_cadastrar_usuario = new Button();
            txt_nova_senha = new TextBox();
            txt_usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_usuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_usuario
            // 
            DGV_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_usuario.Location = new Point(30, 16);
            DGV_usuario.Margin = new Padding(3, 4, 3, 4);
            DGV_usuario.Name = "DGV_usuario";
            DGV_usuario.RowHeadersWidth = 51;
            DGV_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_usuario.Size = new Size(265, 248);
            DGV_usuario.TabIndex = 0;
            // 
            // button_excluir_usuario
            // 
            button_excluir_usuario.Location = new Point(85, 291);
            button_excluir_usuario.Margin = new Padding(3, 4, 3, 4);
            button_excluir_usuario.Name = "button_excluir_usuario";
            button_excluir_usuario.Size = new Size(166, 68);
            button_excluir_usuario.TabIndex = 1;
            button_excluir_usuario.Text = "Excluir";
            button_excluir_usuario.UseVisualStyleBackColor = true;
            button_excluir_usuario.Click += button_excluir_usuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_cadastrar_usuario);
            groupBox1.Controls.Add(txt_nova_senha);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(336, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(250, 253);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Senha";
            // 
            // button_cadastrar_usuario
            // 
            button_cadastrar_usuario.Location = new Point(63, 196);
            button_cadastrar_usuario.Margin = new Padding(3, 4, 3, 4);
            button_cadastrar_usuario.Name = "button_cadastrar_usuario";
            button_cadastrar_usuario.Size = new Size(125, 43);
            button_cadastrar_usuario.TabIndex = 3;
            button_cadastrar_usuario.Text = "Cadastrar";
            button_cadastrar_usuario.UseVisualStyleBackColor = true;
            button_cadastrar_usuario.Click += button_cadastrar_usuario_Click;
            // 
            // txt_nova_senha
            // 
            txt_nova_senha.Location = new Point(25, 152);
            txt_nova_senha.Margin = new Padding(3, 4, 3, 4);
            txt_nova_senha.Name = "txt_nova_senha";
            txt_nova_senha.Size = new Size(201, 27);
            txt_nova_senha.TabIndex = 3;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(25, 73);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(201, 27);
            txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 128);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Nova Senha ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // frm_usuário
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._03_Pag_contatos_anuncio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 393);
            Controls.Add(groupBox1);
            Controls.Add(button_excluir_usuario);
            Controls.Add(DGV_usuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_usuário";
            Text = "frm_usuário";
            ((System.ComponentModel.ISupportInitialize)DGV_usuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_usuario;
        private Button button_excluir_usuario;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button button_cadastrar_usuario;
        private TextBox txt_nova_senha;
        private TextBox txt_usuario;
    }
}
﻿namespace Projeto_Agenda.Views
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
            DGV_usuario.Location = new Point(26, 12);
            DGV_usuario.Name = "DGV_usuario";
            DGV_usuario.RowHeadersWidth = 51;
            DGV_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_usuario.Size = new Size(232, 186);
            DGV_usuario.TabIndex = 0;
            // 
            // button_excluir_usuario
            // 
            button_excluir_usuario.Location = new Point(74, 218);
            button_excluir_usuario.Name = "button_excluir_usuario";
            button_excluir_usuario.Size = new Size(145, 51);
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
            groupBox1.Location = new Point(294, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 190);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Senha";
            // 
            // button_cadastrar_usuario
            // 
            button_cadastrar_usuario.Location = new Point(55, 147);
            button_cadastrar_usuario.Name = "button_cadastrar_usuario";
            button_cadastrar_usuario.Size = new Size(109, 32);
            button_cadastrar_usuario.TabIndex = 3;
            button_cadastrar_usuario.Text = "Cadastrar";
            button_cadastrar_usuario.UseVisualStyleBackColor = true;
            button_cadastrar_usuario.Click += button_cadastrar_usuario_Click;
            // 
            // txt_nova_senha
            // 
            txt_nova_senha.Location = new Point(22, 114);
            txt_nova_senha.Name = "txt_nova_senha";
            txt_nova_senha.Size = new Size(176, 23);
            txt_nova_senha.TabIndex = 3;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(22, 55);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(176, 23);
            txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 96);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Nova Senha ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // frm_usuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._03_Pag_contatos_anuncio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 295);
            Controls.Add(groupBox1);
            Controls.Add(button_excluir_usuario);
            Controls.Add(DGV_usuario);
            Name = "frm_usuário";
            Text = "frm_usuário";
            Load += frm_usuário_Load;
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
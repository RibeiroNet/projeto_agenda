﻿namespace Projeto_Agenda
{
    partial class tela_inicial
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
            textbox_nome = new TextBox();
            textbox_usuario2 = new TextBox();
            text_telefone = new TextBox();
            textbox_senha = new TextBox();
            text_senha_confirma = new TextBox();
            button_cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_cancelar = new Button();
            SuspendLayout();
            // 
            // textbox_nome
            // 
            textbox_nome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_nome.Location = new Point(10, 32);
            textbox_nome.Margin = new Padding(3, 2, 3, 2);
            textbox_nome.Name = "textbox_nome";
            textbox_nome.Size = new Size(599, 36);
            textbox_nome.TabIndex = 3;
            textbox_nome.TextChanged += textbox_nome_TextChanged;
            // 
            // textbox_usuario2
            // 
            textbox_usuario2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_usuario2.Location = new Point(16, 98);
            textbox_usuario2.Margin = new Padding(3, 2, 3, 2);
            textbox_usuario2.Name = "textbox_usuario2";
            textbox_usuario2.Size = new Size(599, 36);
            textbox_usuario2.TabIndex = 4;
            textbox_usuario2.TextChanged += textbox_usuario2_TextChanged;
            // 
            // text_telefone
            // 
            text_telefone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_telefone.Location = new Point(10, 165);
            text_telefone.Margin = new Padding(3, 2, 3, 2);
            text_telefone.Name = "text_telefone";
            text_telefone.Size = new Size(599, 36);
            text_telefone.TabIndex = 5;
            // 
            // textbox_senha
            // 
            textbox_senha.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_senha.Location = new Point(10, 230);
            textbox_senha.Margin = new Padding(3, 2, 3, 2);
            textbox_senha.Name = "textbox_senha";
            textbox_senha.Size = new Size(295, 36);
            textbox_senha.TabIndex = 6;
            // 
            // text_senha_confirma
            // 
            text_senha_confirma.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_senha_confirma.Location = new Point(314, 230);
            text_senha_confirma.Margin = new Padding(3, 2, 3, 2);
            text_senha_confirma.Name = "text_senha_confirma";
            text_senha_confirma.Size = new Size(295, 36);
            text_senha_confirma.TabIndex = 7;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.DeepSkyBlue;
            button_cadastrar.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cadastrar.Location = new Point(314, 272);
            button_cadastrar.Margin = new Padding(3, 2, 3, 2);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(295, 55);
            button_cadastrar.TabIndex = 8;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 2);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 10;
            label1.Text = "nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 68);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 12;
            label3.Text = "Usuário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 133);
            label4.Name = "label4";
            label4.Size = new Size(134, 30);
            label4.TabIndex = 13;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 200);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 14;
            label5.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(314, 200);
            label6.Name = "label6";
            label6.Size = new Size(204, 30);
            label6.TabIndex = 15;
            label6.Text = "Repita a Senha:";
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.DeepSkyBlue;
            button_cancelar.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(10, 272);
            button_cancelar.Margin = new Padding(3, 2, 3, 2);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(229, 55);
            button_cancelar.TabIndex = 16;
            button_cancelar.Text = "Retornar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // tela_inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(705, 338);
            Controls.Add(button_cancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_cadastrar);
            Controls.Add(text_senha_confirma);
            Controls.Add(textbox_senha);
            Controls.Add(text_telefone);
            Controls.Add(textbox_usuario2);
            Controls.Add(textbox_nome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tela_inicial";
            Text = "tela_inicial";
            Load += tela_inicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_nome;
        private TextBox textbox_usuario2;
        private TextBox text_telefone;
        private TextBox textbox_senha;
        private TextBox text_senha_confirma;
        private Button button_cadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_cancelar;
    }
}
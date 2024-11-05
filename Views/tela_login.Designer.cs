namespace Projeto_Agenda
{
    partial class tela_login
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
            label1 = new Label();
            label2 = new Label();
            textbox_usuário = new TextBox();
            textbox_senha = new TextBox();
            button_entrar = new Button();
            button_cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 146);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // textbox_usuário
            // 
            textbox_usuário.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_usuário.Location = new Point(41, 64);
            textbox_usuário.Margin = new Padding(3, 2, 3, 2);
            textbox_usuário.Name = "textbox_usuário";
            textbox_usuário.Size = new Size(596, 47);
            textbox_usuário.TabIndex = 2;
            textbox_usuário.TextChanged += textbox_usuário_TextChanged_1;
            // 
            // textbox_senha
            // 
            textbox_senha.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_senha.Location = new Point(41, 178);
            textbox_senha.Margin = new Padding(3, 2, 3, 2);
            textbox_senha.Name = "textbox_senha";
            textbox_senha.Size = new Size(596, 47);
            textbox_senha.TabIndex = 3;
            textbox_senha.TextChanged += textbox_senha_TextChanged;
            // 
            // button_entrar
            // 
            button_entrar.BackColor = Color.DeepSkyBlue;
            button_entrar.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_entrar.Location = new Point(88, 250);
            button_entrar.Margin = new Padding(3, 2, 3, 2);
            button_entrar.Name = "button_entrar";
            button_entrar.Size = new Size(175, 69);
            button_entrar.TabIndex = 4;
            button_entrar.Text = "Entrar";
            button_entrar.UseVisualStyleBackColor = false;
            button_entrar.Click += button_entrar_Click;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.DeepSkyBlue;
            button_cadastrar.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cadastrar.Location = new Point(400, 250);
            button_cadastrar.Margin = new Padding(3, 2, 3, 2);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(175, 69);
            button_cadastrar.TabIndex = 5;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            button_cadastrar.Click += button2_Click;
            // 
            // tela_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(button_cadastrar);
            Controls.Add(button_entrar);
            Controls.Add(textbox_senha);
            Controls.Add(textbox_usuário);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tela_login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textbox_usuário;
        private TextBox textbox_senha;
        private Button button_entrar;
        private Button button_cadastrar;
    }
}

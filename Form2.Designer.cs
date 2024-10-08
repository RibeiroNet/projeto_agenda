namespace Projeto_Agenda
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
            textbox_usuário = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // textbox_usuário
            // 
            textbox_usuário.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_usuário.Location = new Point(12, 43);
            textbox_usuário.Name = "textbox_usuário";
            textbox_usuário.Size = new Size(684, 43);
            textbox_usuário.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(684, 43);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(684, 43);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(337, 43);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(359, 306);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(337, 43);
            textBox4.TabIndex = 7;
            // 
            // button_cadastrar
            // 
            button_cadastrar.BackColor = Color.DeepSkyBlue;
            button_cadastrar.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cadastrar.Location = new Point(84, 383);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(201, 55);
            button_cadastrar.TabIndex = 8;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 10;
            label1.Text = "nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 12;
            label3.Text = "Usuário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(170, 37);
            label4.TabIndex = 13;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 266);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 14;
            label5.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(359, 266);
            label6.Name = "label6";
            label6.Size = new Size(258, 37);
            label6.TabIndex = 15;
            label6.Text = "Repita a Senha:";
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.DeepSkyBlue;
            button_cancelar.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(416, 383);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(201, 55);
            button_cancelar.TabIndex = 16;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            // 
            // tela_inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_cadastrar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textbox_usuário);
            Name = "tela_inicial";
            Text = "tela_inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_usuário;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
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
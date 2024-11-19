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
            ((System.ComponentModel.ISupportInitialize)DGV_usuario).BeginInit();
            SuspendLayout();
            // 
            // DGV_usuario
            // 
            DGV_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_usuario.Location = new Point(26, 12);
            DGV_usuario.Name = "DGV_usuario";
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
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(294, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 190);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Senha";
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
            ((System.ComponentModel.ISupportInitialize)DGV_usuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_usuario;
        private Button button_excluir_usuario;
        private GroupBox groupBox1;
    }
}
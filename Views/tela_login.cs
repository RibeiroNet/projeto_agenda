
using Projeto_Agenda.controller;
using Projeto_Agenda.Views;

namespace Projeto_Agenda
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }
        private void habilitarbotaologin()
        {
            if (textbox_usuário.Text != "" && textbox_senha.Text.Length >= 8)
            {
                button_entrar.Enabled = true;
            }
            else
            {
                button_entrar.Enabled = false;
            }
        }
        private void textbox_senha_TextChanged(object sender, EventArgs e)
        {
            habilitarbotaologin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_inicial tela_Inicial = new tela_inicial();
            tela_Inicial.ShowDialog();
        }

        private void textbox_usuário_TextChanged(object sender, EventArgs e)
        {
            habilitarbotaologin();
        }

        private void textbox_usuário_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            UsuarioController controleusuario = new UsuarioController();
            bool resultado = controleusuario.LogarUsuario(textbox_usuário.Text, textbox_senha.Text);
            MessageBox.Show(resultado.ToString());
            if (resultado)
            {
                frm_Principal principal = new frm_Principal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar.");
            }
        }
    }
}

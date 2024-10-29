using MySql.Data.MySqlClient;
using Projeto_Agenda.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }
        private void habilitarbotaocadastrar()
        {
            bool erro = false;
            if (textbox_nome.Text == "")
            {
                erro = true;
            }
            if (textbox_usuario2.Text == "")
            {
                erro = true;
            }
            if (textbox_senha.Text.Length < 8)
            {
                erro = true;
            }
            if (textbox_senha.Text != text_senha_confirma.Text)
            {
                erro |= true;
            }
            if (erro == false)
            {
                button_cadastrar.Enabled = true;
            }
            else
            {
                button_cadastrar.Enabled = false;
            }
        }


        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulário
            string nome = textbox_nome.Text;
            string usuario =textbox_usuario2.Text;
            string telefone = text_telefone.Text;
            string senha = textbox_senha.Text;

            //instanciando o objeto UsuarioController
            UsuarioController controleusuario = new UsuarioController();

            //inserindo usuario
            bool resultado = controleusuario.AddUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível concluir o cadastro.");
            }
        }
    }
}

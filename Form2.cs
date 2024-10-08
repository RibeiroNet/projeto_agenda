using MySql.Data.MySqlClient;
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
            string string_conexao = "Server=127.0.0.1; DataBase=dbAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            conexao.Open();
            string sql = $"INSERT INTO tbUsuarios (nome, usuario, senha) Values ('{textbox_nome.Text}', '{textbox_usuario2.Text}', '{textbox_senha}')";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
            conexao.Clone();
        }

        private void textbox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
''
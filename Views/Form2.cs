using MySql.Data.MySqlClient;
using Projeto_Agenda.data;
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
            MySqlConnection conexao = conexaoDB.CriarConexao();
            conexao.Open();

            string sql = $"INSERT INTO tb_usuario (nome, usuario, telefone senha) Values (@nome, @usuario, @senha)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", textbox_nome.Text);
            comando.Parameters.AddWithValue("@usuario", textbox_usuario2.Text);
            comando.Parameters.AddWithValue("@telefone", text_telefone.Text);
            comando.Parameters.AddWithValue("@senha", textbox_senha.Text);
            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Cadastro realizado com sucesso! \n Você não pode fazer login.");
            this.Close();
        }

        private void textbox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_usuario2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

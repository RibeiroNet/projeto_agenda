using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.controller
{
    internal class ContatoController
    {
        public bool AddUsuario(string contato, string telefone, string categoria)
        {
            try
            {
                //cria a conexão, utilizando a classe conexaoDB que está dentro da pasta 
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //comando sql que será executado
                string sql = "INSERT INTO tb_Contato (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);"

                //abrindo conexão com o banco 
                conexao.Open();

                //responsável por executar o comando sql 
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // trocando o valor de @ por informações posteriormente cadastradas 
                // tais informações vieram dos parâmetros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@telefone", telefone);

                //executando no banco de dados 
                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (LinhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }
        }
    }
}
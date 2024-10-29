using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            //cria a conexão, utilizando a classe conexaoDB que está dentro da pasta 
            MySqlConnection conexao = conexaoDB.CriarConexao();

            //comando sql que será executado
            string sql = "INSERT INTO tbusuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";   
        
            //abrindo conexão com o banco 
            conexao.Open();

            //responsável por executar o comando sql 
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            // trocando o valor de @ por informações posteriormente cadastradas 
            // tais informações vieram dos parâmetros da função
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha", senha);

            //executando no baco de dados 
            comando.ExecuteNonQuery();
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
    }
}

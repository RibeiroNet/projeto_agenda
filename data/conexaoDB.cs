using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.data
{
    static internal class conexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            //conecta ao mysql utilizando o hoot como hoot para criar o usuário // string sql
            string string_conexao = "Server=127.0.0.1; DataBase=dbAgenda;User ID=root;Password=root;";

            //responsável por executar o comando sql 
            MySqlConnection conexao = new MySqlConnection(string_conexao);

            //retorna a conexão
            return conexao;
        }


        static public MySqlConnection CriarConexao(string usuario, string senha)
        {

            //conecta ao mysql utilizando o usuário para usar o programa // string sql
            string string_conexao = $"Server=127.0.0.1; DataBase=dbAgenda;User ID='{usuario}';Password='{senha}';";


            //responsável por executar o comando sql 
            MySqlConnection conexao = new MySqlConnection(string_conexao);

            //retorna a conexão
            return conexao;
        }
    }
}

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
            string string_conexao = "Server=127.0.0.1; DataBase=dbAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            return conexao;
        }


        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            string string_conexao = $"Server=127.0.0.1; DataBase=dbAgenda;User ID='{usuario}';Password='{senha}';";
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            return conexao;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda
{
    internal class conexaoDB
    {
        public MySqlAttributeConnection Criarconexao()
        {
            static internal class 
            string string_conexao = "Server=127.0.0.1; DataBase=bdAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(string_conexao);
            return conexao;
        }
    }
}

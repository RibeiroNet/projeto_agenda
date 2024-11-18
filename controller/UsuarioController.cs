using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
            try
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

                //executando no banco de dados 
                int LinhasAfetadas = comando.ExecuteNonQuery();

                this.CriarUsuarioSQL(usuario, senha);

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

        public bool LogarUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao();
                string sql = @"select * from tbusuarios
                                where nome = 'neto ribeiro'
                                and binary = '123434566;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //executando no banco de dados 
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch

            {
                return false;
            }
        }
            public bool CriarUsuarioSQL(string usuario, string senha)
            {
                MySqlConnection conexao = null;
                try
                {
                    conexao = conexaoDB.CriarConexao();

                    string sql = $"CREATE USER '{usuario}'@'%IDENTIFIED BY'{senha}';";

                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    MySqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }


            }
        
    }
}

﻿using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Projeto_Agenda.data;
using Projeto_Agenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
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
                string sql = "INSERT INTO tbusuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);" +
                             $"create user '{usuario}'@'%' identified by '{senha}';" +
                             $"grant select, insert, update, delete on dbAgenda.* to '{usuario}'@'%';";


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
                //conexão ao DB utilizando a classe conexaoDB que está dentro da pasta 
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //string do mysql
                string sql = @"select * from tbusuarios
                                where usuario = @usuario
                                and binary senha = @senha;";
                
                //abrindo conexão
                conexao.Open();

                //responsável pela conexão MSql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //executando no banco de dados 
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    //verificando os dados do usuário
                    UserSession.usuario = resultado.GetString("usuario");
                    UserSession.senha = resultado.GetString("senha");
                    UserSession.nome = resultado.GetString("nome");
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
            //conexão vazia
            MySqlConnection conexao = null;
            try
            {
                //cria a conexão, utilizando a classe conexaoDB que está dentro da pasta 
                conexao = conexaoDB.CriarConexao();

                //string que é passada ao mysql
                string sql = $"CREATE USER '{usuario}'@'%IDENTIFIED BY'{senha}';";

                //abrindo a conexão
                conexao.Open();


                //responsável por executar o comando sql 
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

        public DataTable GetUsuario()
        {
            //Criando uma conxão vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo conexão com ConexaoDB 
                conexao = conexaoDB.CriarConexao();

                // SELECT que retorna categorias
                string sql = "select nome AS 'nome', usuario AS 'usuario' from tbUsuarios;";

                conexao.Open();

                // adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                // adaptador preenchendo a tabela
                adaptador.Fill(tabela);

                // tabela preenchida
                return tabela;
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return new DataTable();
            }
            finally
            {
                //Fechei a conexão
                conexao.Close();
            }
        }

        public bool ExcluirUsuario(string usuario)
        {
            try
            {
                //inserindo conexão com ConexaoDB 
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //string de dentro do mysql
                string sql = "DELETE FROM tbUsuarios WHERE usuario = @usuario;";

                //abrindo a conexão
                conexao.Open();

                //responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // trocando  @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@usuario", usuario);

                //verifinaod se há linhas com problemas < or > 0
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
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return false;
            }
        }

        public bool AlterarSenha(string senha, string usuario)
        {
            try
            {
                //inserindo conexão com ConexaoDB 
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //dados de string dentro do mysql
                string sql = "UPDATE tbUsuarios SET senha = @senha WHERE usuario = @usuario; "+
                    $"alter user '{usuario}'@'%' identified by '{senha}';";

                //abrindo conexão
                conexao.Open();

                //executando dentro do mysql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //trocando e verificando os parâmetros
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@usuario", usuario);

                //verificando erros
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
            //possível erro 
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return false;
            }

        }
    }
   
}
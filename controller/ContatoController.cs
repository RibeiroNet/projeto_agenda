using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
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
    internal class ContatoController
    {
        public bool AddContato(string contato, string telefone, string categoria)
        {
            try
            {
                //cria a conexão, utilizando a classe conexaoDB que está dentro da pasta 
                MySqlConnection conexao = conexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);

                //comando sql que será executado
                string sql = "INSERT INTO tb_Contato (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

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

        public DataTable GetContato()
        {
            //Criando uma conxão vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo conexão com ConexaoDB 
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                // SELECT que retorna categorias
                string sql = "select cod_contato AS 'Código Contato', contato AS 'Contato',  telefone AS 'Telefone', categoria AS 'Categoria'  from tb_Contato WHERE usuario = User();";

                //abrindo a conexão
                conexao.Open();

                // adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                // adaptador preenchendo a tabela
                adaptador.Fill(tabela);

                // tabela preenchida
                return tabela;
            }
            //caso de erro
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar contato:{erro.Message}");
                return new DataTable();
            }
            finally
            {
                //Fechei a conexão
                conexao.Close();
            }
        }

        public bool ExcluirContato(string cod_contato)
        {
            try
            {
                //cria a conexão, utilizando a classe conexaoDB que está dentro da pasta 
                MySqlConnection conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que será executado
                string sql = "DELETE FROM tb_Contato WHERE cod_contato = @cod_contato;";

                //abrindo a conexão
                conexao.Open();

                //responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // trocando  @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_contato", cod_contato);

                //executando no banco de dados 
                int LinhasAfetadas = comando.ExecuteNonQuery();

                //fechando conexão
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
                //mensagem a ser exibida
                MessageBox.Show($"Erro ao deletar contato:{erro.Message}");
                return false;
            }
        }

        public bool AlterarContato(string contato, string categoria, int cod_contato)
        {
            //Criando uma conxão vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo conexão com ConexaoDB 
                conexao = conexaoDB.CriarConexao();

                // SELECT que retorna categorias
                string sql = @"UPDATE dbagenda.tb_Contato SET contato = (@contato), categoria = (@categoria) WHERE cod_contato = (@cod_contato);";

                //abrindo a conexão
                conexao.Open();

                //responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // trocando o valor de @ por informações posteriormente cadastradas 
                // tais informações vieram dos parâmetros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@cod_contato", cod_contato);

                //executando no banco de dados 
                int LinhasAfetadas = comando.ExecuteNonQuery();

                if (LinhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //caso de erro
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar o contato:{erro.Message}");
                return false;
            }
            finally
            {
                //Fechei a conexão
                conexao.Close();
            }

        }
    }
}
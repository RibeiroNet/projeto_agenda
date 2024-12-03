using MySql.Data.MySqlClient;
using Projeto_Agenda.data;
using Projeto_Agenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string nome_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = "INSERT INTO tb_categoria(nome_categoria) VALUES (@nome_categoria );";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome_categoria", nome_categoria);

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

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao Cadastrar categoria");
                return false;

            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                //cria conexão, usa a classe ConexaoDB que já havia sido criado 
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha); 

                //select que vai retornar dados 
                string sql = "select cod_categoria as 'Código', nome_categoria as 'Categoria' from tb_categoria WHERE usuario = User();";

                conexao.Open();

                //ao invés de mysqlcommand usamos mysqldataadapter, pois quero trabalhar 
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //crei uma tabela vazia 
                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ExcluirCategoria(int cod_categoria)
        {
            try
            {
                // cria conexão, classe conexãoDB que está dentro de DATA
                MySqlConnection conexao = conexaoDB.CriarConexao();

                //comando a ser executado
                string sql = "DELETE FROM tb_categoria WHERE cod_categoria = @cod_categoria;";

                //abriu conexão
                conexao.Open();

                //responsável por executar o comando SQl
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //trocando valores de @ por informações a serem cadastradas 
                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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
                MessageBox.Show($"Erro ao excluir categoria: {erro.Message}");

                return false;
            }
        }

        public bool UpdateCategoria(int cod_categoria, string nome_categoria)
        {
            MySqlConnection conexao = null;

            try
            {
                // cria conexão, classe conexãoDB que está dentro de DATA
                conexao = conexaoDB.CriarConexao();

                //comando a ser executado
                string sql = "UPDATE tb_categoria SET nome_categoria = @nome_categoria where cod_categoria = @cod_categoria;";

                //abrir a conexão
                conexao.Open();

                //responsável por executar o comando SQl
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //trocando valores de @ por informações a serem cadastradas 
                comando.Parameters.AddWithValue("@nome_categoria", nome_categoria);
                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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
                MessageBox.Show($"Erro ao alterar categoria: {erro.Message}");

                return false;
            }

        }
    }
}

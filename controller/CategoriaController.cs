using MySql.Data.MySqlClient;
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
                 conexao = conexaoDB.CriarConexao();

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
                conexao = conexaoDB.CriarConexao();

                //select que vai retornar dados 
                string sql = @"select cod_categoria as 'Código', nome_categoria as 'Categoria'
                             from tb_categoria;";

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
                MySqlConnection conexao = conexaoDB.CriarConexao();

                string sql = "DELETE FROM tbCategoria WHERE cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("cod_categoria", cod_categoria);

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
                MessageBox.Show($"Erro ao recuperar categoria: {erro.Message}");

                return false;
            }
            }
        }
    }


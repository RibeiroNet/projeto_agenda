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
                MySqlConnection conexao = conexaoDB.CriarConexao();

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
                conexao = conexaoDB.CriarConexao();

                // SELECT que retorna categorias
                string sql = "select contato AS 'Contato', telefone AS 'Telefone', categoria AS 'Categoria'  from tb_Contato;";

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
                MessageBox.Show($"Erro ao recuperar contato:{erro.Message}");
                return new DataTable();
            }
            finally
            {
                //Fechei a conexão
                conexao.Close();
            }
        }

        public bool ExcluirContato(string telefone)
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = "DELETE FROM tb_Contato WHERE telefone = @telefone;";

                conexao.Open();

                //responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // trocando  @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@telefone", telefone);

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
                MessageBox.Show($"Erro ao deletar contato:{erro.Message}");
                return false;
            }
        }
    }
}
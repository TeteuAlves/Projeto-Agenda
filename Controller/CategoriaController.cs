using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Projeto_Agenda.Data;
using Projeto_Agenda.VariableGlobal;

namespace Projeto_Agenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = "insert into tbcategoria (categoria) values(@categoria);";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
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
                MessageBox.Show($"Erro ao efutuar o cadastro: {erro.Message}");
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
                conexao = conexaoDB.CriarConexao();

                String sql = @"select cod_categoria as 'Código' , categoria as 'Categoria' from tbcategoria";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

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
        public bool ExCategoria(int cod_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = @"delete from tbcategoria
                                where cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
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
                MessageBox.Show($"Erro ao efutuar o cadastro: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }

        public bool UpdateCategoria(int cod_categoria, string novo_nome)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = @"UPDATE tbcategoria SET categoria = @novo_nome WHERE cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);
                comando.Parameters.AddWithValue("@novo_nome", novo_nome);

                int linhasAfetadas = comando.ExecuteNonQuery();



                if (linhasAfetadas > 0)
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
                MessageBox.Show($"Alteração não realizada: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}


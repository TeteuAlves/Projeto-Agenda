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
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string senha)
        {
            //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
            
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tbUsuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha);";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);



                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();





                if (linhasAfetadas > 0)
                {
                    string sql2 = $@"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                    GRANT ALL PRIVILEGES ON dbagenda.* TO '{usuario}'@'%';
                    FLUSH PRIVILEGES;";
                   

                    comando = new MySqlCommand(sql2, conexao);

                    linhasAfetadas = comando.ExecuteNonQuery();

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

        public bool LoginUsuario(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = conexaoDB.CriarConexao();

                string sql = @"select nome, usuario, senha from tbusuarios
                               where usuario = @usuario
                                and BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();



                if (resultado.Read())
                {
                    UserSession.nome = resultado.GetString("nome");
                    UserSession.usuario = resultado.GetString("usuario");
                    UserSession.senha = resultado.GetString("senha");
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }

            }
            catch
            {
                return false;
            }

        }

        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = conexaoDB.CriarConexao();

                String sql = @"select usuario as 'Usuario' from tbusuarios";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar usuario: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }



        }

        public bool ExUsuarios(string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao();

                string sql = @"delete from tbusuarios
                                where usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

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

        public bool AlterSenha(string senha, string novasenha, string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = conexaoDB.CriarConexao();

                string sql = @"UPDATE tbusuarios SET senha = @novasenha WHERE usuarios = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@novasenha", novasenha);
                comando.Parameters.AddWithValue("@usuario", usuario);

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
    }
}


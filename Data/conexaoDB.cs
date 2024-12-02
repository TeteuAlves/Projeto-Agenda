using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Agenda.Data
{
    static internal class conexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            string stringconexao = "Server=localhost;Database= dbAgenda;User ID=root;Password=root;";

            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;

        }
        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            string stringconexao = $"Server=localhost;Database= dbAgenda;User ID={usuario};Password={senha};";

            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;
        }
    }
}

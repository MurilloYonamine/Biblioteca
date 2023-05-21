using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class BancoDeDados
    {
        static string conexao = "server=localhost;port=3306;" +
        "database=bd_biblioteca;uid=root;password=011221";
        static MySqlConnection connection;
        public MySqlConnection conectar()
        {
            connection = new MySqlConnection(conexao);
            if (!connection.State.HasFlag(System.Data.ConnectionState.Open))
            {
                connection.Close();
                connection.Open();
            }
            return connection;
        }
    }
}

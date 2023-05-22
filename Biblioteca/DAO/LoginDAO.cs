using Biblioteca.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public class LoginDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            throw new NotImplementedException();
        }

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            Usuario usuario = (Usuario)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                string comando = "SELECT * FROM tb_usuario WHERE email = @email AND senha = @senha";
                cmd = new MySqlCommand(comando, conn);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    usuario = new Usuario
                    {
                        Nome = reader.GetString("nome"),
                        Nome_social = reader.GetString("nome_social")
                    };
                    reader.Close();
                    return usuario;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}

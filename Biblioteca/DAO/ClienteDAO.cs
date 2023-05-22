using Biblioteca.DAO;
using Biblioteca.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class ClienteDAO : IDAO
    {
        public ArrayList all()
        {
            throw new NotImplementedException();
        }

        public object create(object objeto)
        {
            Cliente cliente = (Cliente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO tb_usuario" +
                    "(cpf, nome, email, senha, nascimento, idade, nome_social, genero, tipo)" +
                    "VALUES(@cpf, @nome, @email, @senha, @nascimento, @idade, @nome_social, @genero, @tipo)";

                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@senha", cliente.Senha);
                cmd.Parameters.AddWithValue("@nascimento", cliente.Nascimento);
                cmd.Parameters.AddWithValue("@idade", cliente.Idade());
                cmd.Parameters.AddWithValue("@nome_social", cliente.Nome_social);
                cmd.Parameters.AddWithValue("@genero", cliente.Genero);
                cmd.Parameters.AddWithValue("@tipo", cliente.Tipo);

                cmd.CommandText = "INSERT INTO tb_cliente" +
                "(cliente_cpf)" +
                "VALUES(@cliente_cpf)";
                cmd.Parameters.AddWithValue("@cliente_cpf", cliente.Cpf);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }


            return cliente;
        }

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}

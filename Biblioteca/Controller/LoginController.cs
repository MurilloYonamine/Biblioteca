using Biblioteca.DAO;
using Biblioteca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class LoginController
    {
        internal bool Salvar(Usuario usuario, out string mensagem)
        {
            LoginDAO lDAO = new LoginDAO();
            Usuario resultado = (Usuario)lDAO.read(usuario);

            if (resultado != null)
            {
                if(resultado.Nome_social != "")
                {
                    mensagem = resultado.Nome_social;
                    return true;
                }
                else
                {
                    mensagem = resultado.Nome;
                    return true;
                }
            }
            else
            {
                mensagem = "ERRO";
                return false;
            }
        }
    }
}

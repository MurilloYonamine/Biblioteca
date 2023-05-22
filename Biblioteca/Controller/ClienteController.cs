using Biblioteca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class ClienteController
    {
        internal void Salvar(Cliente cliente)
        {
            ClienteDAO cDAO = new ClienteDAO();
            cDAO.create(cliente);
        }
    }
}

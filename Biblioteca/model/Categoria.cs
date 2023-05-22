using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Categoria
    {
        private int id;
        private string nome;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Categoria_Livro
    {
        private int Livro_id;
        private int Categoria_id;

        public int Livro
        {
            get { return this.Livro_id; }
            set { this.Livro_id = value; }
        }
        public int Categoria
        {
            get { return this.Categoria_id; }
            set { this.Categoria_id = value; }
        }
    }
}

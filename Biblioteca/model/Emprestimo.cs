using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Emprestimo
    {
        private int id;
        private string cpf;
        private string livro_isbn;
        private DateTime data;
        private DateTime devolucao;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
        public string Livro_Isbn
        {
            get { return this.livro_isbn; }
            set { this.livro_isbn = value; }
        }
        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public DateTime Devolucao
        {
            get { return this.devolucao; }
            set { this.devolucao = value; }
        }
    }
}

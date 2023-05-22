using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Autor
    {
        private string nome;
        private string nacionalidade;
        private DateTime nascimento;
        private int id;

        public virtual string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public virtual string Nacionalidade
        {
            get { return this.nacionalidade; }
            set { this.nacionalidade = value; }
        }
        public virtual DateTime Nascimento
        {
            get { return this.nascimento; }
            set { this.nascimento = value; }
        }
        public virtual int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

    }
}

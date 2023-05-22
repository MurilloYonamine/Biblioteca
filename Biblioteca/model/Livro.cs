using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Livro
    {
        private string titulo;
        private int autor_id;
        private string isbn;
        private DateTime publicacao;
        private string idioma;
        private int pagina;
        private string sinopse;

        public virtual string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public virtual int Autor_Id
        {
            get { return this.autor_id; }
            set { this.autor_id = value; }
        }
        public virtual string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }
        public virtual DateTime Publicacao
        {
            get { return this.publicacao; }
            set { this.publicacao = value; }
        }
        public virtual string Idioma
        {
            get { return this.idioma; }
            set { this.idioma = value; }
        }
        public virtual string Sinopse
        {
            get { return this.sinopse; }
            set { this.sinopse = value; }
        }
    }
}

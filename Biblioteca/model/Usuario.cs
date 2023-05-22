using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public class Usuario
    {
        private string cpf;
        private string nome;
        private string nome_social;
        private string genero;
        private string email;
        private string senha;
        private DateTime nascimento;
        private int idade;
        private string tipo;

        public virtual string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }
        public virtual string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public virtual string Nome_social
        {
            get { return this.nome_social; }
            set { this.nome_social = value; }
        }
        public virtual string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }
        public virtual string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public virtual string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
        public virtual DateTime Nascimento
        {
            get { return this.nascimento; }
            set { this.nascimento = value; }
        }
        public virtual string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public virtual int Idade()
        {
            this.idade = DateTime.Now.Year - this.nascimento.Year;
            if (DateTime.Now.DayOfYear < this.nascimento.DayOfYear)
            {
                this.idade = this.idade - 1;
            }
            return this.idade;
        }

        public bool Email_verificacao()
        {
            try
            {
                MailAddress email_verify = new MailAddress(this.email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ValidaCPF(string vrCPF)

        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }

            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }
    }
}

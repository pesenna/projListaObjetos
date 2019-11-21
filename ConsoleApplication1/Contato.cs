using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Contato
    {
        private string email, nome, telefone;

        public Contato(string email, string nome, string telefone)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
        }

        public Contato()
            : this("", "", "")
        {
        }

        public string Email
        {
            get{return email;}

            set{email = value;}
        }

        public string Nome
        {
            get{return nome;}

            set{nome = value;}
        }

        public string Telefone
        {
            get{return telefone;}

            set{telefone = value;}
        }

        public override bool Equals(object obj) // CAST
        {
            return ((Contato)obj).Email.Equals(this.Email); //Recebe dado tipo object, 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

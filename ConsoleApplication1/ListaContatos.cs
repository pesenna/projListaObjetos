using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ListaContatos
    {
        private List<Contato> meusContatos;

        public List<Contato> MeusContatos
        {
            get { return meusContatos; }
        }

        public void adicionar (Contato contato)
        {
            this.meusContatos.Add(contato);
        }

        public void remover(Contato contato)
        {
            meusContatos.Remove(contato);
        }

        public Contato pesquisar (Contato contato)
        {
            foreach (Contato c in meusContatos)
                if (c.Email.Equals(c.Email))
                    return c;
            return contato;
        }

        public void alterar(Contato contato)
        {
            pesquisar(contato);
            remover(contato);
            adicionar(contato);
        }

       
    }
}

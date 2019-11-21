using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            ListaContatos listaContatos;
            listaContatos = new ListaContatos();
            do
            {
                Console.WriteLine("0. Finalizar\n1. Adicionar\n2. Pesquisar\n3. Alterar\n4. Remover\n5. Listar");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        string emailAdd, nomeAdd, telefoneAdd;
                        Console.WriteLine("Digite o email: ");
                        emailAdd = Console.ReadLine();
                        Console.WriteLine("Digite o nome: ");
                        nomeAdd = Console.ReadLine();
                        Console.WriteLine("Digite o telefone: ");
                        telefoneAdd = Console.ReadLine();
                        listaContatos.adicionar(new Contato(emailAdd, nomeAdd, telefoneAdd));
                        break;

                    case 2:
                        string emailPesq;
                        Console.WriteLine("Digite o contato que deseja procurar: ");
                        emailPesq = Console.ReadLine();
                        Contato contatoPesq;
                        contatoPesq = listaContatos.pesquisar(new Contato(emailPesq,"",""));
                        if (contatoPesq.Email.Equals(""))
                            Console.WriteLine("Contato não encontrado");
                        else
                            Console.WriteLine(contatoPesq);
                        break;

                    case 3:

                        break;

                    case 4:
                        string emailRem;
                        Console.WriteLine("Digite o contato que deseja remover: ");
                        emailRem= Console.ReadLine();
                        listaContatos.remover(new Contato(emailRem, "", ""));
                        break;

                    case 5:
                        foreach (Contato c in listaContatos.MeusContatos)
                            Console.WriteLine(c.Email+ " - " + c.Nome + " - " + c.Telefone);
                        Console.WriteLine("-");
                        break;

                    default:

                        break;
                }
            }
            while (opcao > 0);
        }
    }
}

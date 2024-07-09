using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Editora
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        public void InserirEditora(ref Editora objeditora)
        {
            Console.WriteLine("Informe os dados:");
            Console.Write("Código: ");

            objeditora.Codigo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nome: ");

            objeditora.Nome = Console.ReadLine();

            Console.Write("E-mail: ");

            objeditora.Email = Console.ReadLine();

            Console.Write("Telefone: ");

            objeditora.Telefone = Console.ReadLine();

            Console.Write("Endereço: ");

            objeditora.Endereco = Console.ReadLine();

            Console.Write("Cidade: ");

            objeditora.Cidade = Console.ReadLine();
        }
    }
}

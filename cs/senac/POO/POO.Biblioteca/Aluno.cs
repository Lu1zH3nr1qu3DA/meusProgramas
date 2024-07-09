using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Celular { get; set; }

        public void InserirDados(ref Aluno objaluno)
        {
            Console.WriteLine("Informe os dados:");
            Console.Write("Código: ");

            objaluno.Codigo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nome: ");

            objaluno.Nome = Console.ReadLine();

            Console.Write("Nascimento: ");

            objaluno.Nascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Endereço: ");

            objaluno.Endereco = Console.ReadLine();

            Console.Write("Número: ");

            objaluno.Numero = Console.ReadLine();

            Console.Write("Celular: ");

            objaluno.Celular = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Autor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Origem { get; set; }

        public void InserirAutor(ref Autor objautor)
        {
            Console.WriteLine("Informe os dados:");
            Console.Write("Código: ");

            objautor.Codigo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nome: ");

            objautor.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");

            try
            {
                objautor.Nascimento = Convert.ToDateTime(Console.ReadLine());
            } 
            catch (ArgumentOutOfRangeException erro)
            {
                Console.Clear();
                Console.WriteLine(erro.Message);
            }

            Console.Write("E-mail: ");

            objautor.Email = Console.ReadLine();

            Console.Write("Origem: ");

            objautor.Origem = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Livro
    {
        public int Codigo { get; set; }
        public string Titulo { get; set;}
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public string Secao { get; set; }
        public string ISBN { get; set; }
        public DateTime Lancamento { get; set; }

        public void InserirLivro(ref Livro objlivro)
        {
            Console.WriteLine("Informe os dados:");
            Console.Write("Código: ");

            objlivro.Codigo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Título: ");

            objlivro.Titulo = Console.ReadLine();

            Console.Write("Autor: ");

            objlivro.Autor = Console.ReadLine();

            Console.Write("Editora: ");

            objlivro.Editora = Console.ReadLine();

            Console.Write("Genero: ");

            objlivro.Genero = Console.ReadLine();

            Console.Write("Seção: ");

            objlivro.Secao = Console.ReadLine();

            Console.Write("ISBN: ");

            objlivro.ISBN = Console.ReadLine();

            Console.Write("Data de Lançamento: ");

            objlivro.Lancamento = Convert.ToDateTime(Console.ReadLine());
        }
    }
}

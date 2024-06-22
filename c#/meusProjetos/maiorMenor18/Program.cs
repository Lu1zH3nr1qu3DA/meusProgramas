using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorMenor18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Insira sua idade.");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade.");
            }
            else
            {
                Console.WriteLine("Você é maior de idade.");
            }
            Console.WriteLine("\nPressione qualquer tecla para sair. . . ");
            Console.ReadKey();
        }
    }
}
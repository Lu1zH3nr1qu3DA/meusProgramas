using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;

            Console.WriteLine("Soma\n");

            Console.WriteLine("Insira o número de valores a serem somados.");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[n];

            for (int posicao = 0; posicao < numeros.Length; posicao++)
            {
                Console.WriteLine($"Insira o valor do {posicao + 1}º número.");
                numeros[posicao] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nResultado: ");
            for (int posicao = 0; posicao < numeros.Length; posicao++)
            {
                Console.Write($" + {numeros[posicao]}");
                soma = soma + numeros[posicao];
            }
            Console.WriteLine($" = {soma}");
            Console.ReadKey();
        }
    }
}
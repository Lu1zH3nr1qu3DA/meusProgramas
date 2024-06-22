using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace e0.parOuImpar
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int numero;
            int resto;

            Console.WriteLine("Insira um número.");
            numero = Convert.ToInt32(Console.ReadLine());

            resto = numero % 2;

            if(resto == 0)
            {
                Console.WriteLine("\nO número é Par.");
            } else
            {
                Console.WriteLine("\nO número é Ímpar.");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tempoDeVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento;
            int tempo;

            Console.Write("Insira sua data de nascimento: ");
            nascimento = Convert.ToDateTime(Console.ReadLine());

            tempo = Convert.ToInt16(DateTime.Now.Subtract(nascimento).Days);

            Console.WriteLine($"\nVocê viveu, aproximadamente, {tempo} dias.");

            Console.Write("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
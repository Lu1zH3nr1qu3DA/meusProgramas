using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e15.diasVividos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            DateTime nascimento;

            Console.Write("Insira sua data de nascimento: ");
            nascimento = Convert.ToDateTime(Console.ReadLine());

            tempo = DateTime.Now.Subtract(nascimento).Days;

            Console.Write($"\nVocê viveu, aproximadamente, {tempo} dias.");

            Console.Write("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
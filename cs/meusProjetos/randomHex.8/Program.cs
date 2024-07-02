using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toChar._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MsgToChar();
            Console.ReadKey();
        }

        static void MsgToChar()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string input = "Look at you, hacker, a \npathetic creature of meat \nand bone. How can you \nchallenge a perfect, \nimmortal machine?";
            char[] values = input.ToCharArray();

            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                Console.Write($"{value:X} ");
            }
        }

        static void RandomChar()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Random random = new Random();
            byte ranChar = 0;
            while (0 == 0)
            {
                int rep = 1;
                while (rep <= 32)
                {
                    ranChar = Convert.ToByte(random.Next(0, 256));
                    int ranHex = Convert.ToInt32(ranChar);
                    Console.Write($"{ranHex:X} ");
                    rep++;
                }
                Console.Write("\n");
            }
        }
    }

}
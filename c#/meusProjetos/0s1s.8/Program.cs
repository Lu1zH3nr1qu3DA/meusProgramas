using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomBin._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MsgToBin();
            Console.ReadKey();
        }
        static void MsgToBin() {
            Console.ForegroundColor = ConsoleColor.Green;

            string input = "Look at you, hacker, \na pathetic creature of meat and bone. \nHow can you challenge the certainty \nof a perfect machine?";

            string converted = String.Empty;
            byte[] values = Encoding.ASCII.GetBytes(input);

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    converted += (values[i] & 0x80) > 0 ? "1" : "0";
                    values[i] <<= 1;
                }
            }
            Console.Write(converted);
        }
        static void RandomBin()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Random random = new Random();
            int ZorO = 0;
            while (0 == 0)
            {
                int rep = 1;
                while (rep < 32)
                {
                    ZorO = random.Next(0, 2);
                    Console.Write(ZorO + " ");
                    rep++;
                }
                ZorO = random.Next(0, 2);
                Console.Write(ZorO + "\n");
            }
        }
    }
}
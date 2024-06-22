using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        public void VerificaTriangulo()
        {
            if (LadoA != LadoB && LadoB != LadoC)
            {
                Console.WriteLine("Escaleno.");
            }
            else
            {
                if (LadoA == LadoB || LadoB == LadoC)
                {
                    Console.WriteLine("Isósceles.");
                }
                else
                {
                    if (LadoA == LadoB && LadoB == LadoC)
                    {
                        Console.WriteLine("Equilátero.");
                    }
                }
            }
        }
    }
}

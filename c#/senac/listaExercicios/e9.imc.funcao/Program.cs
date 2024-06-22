using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e9.imc.funcao
{
    internal class Program
    {

        static void Coletar(ref string pesoStr, ref string alturaStr)
        {
            Console.WriteLine("Calculadora IMC.");
            Console.Write("Insira seu peso (kg): ");
            pesoStr = Console.ReadLine();
            Console.Write("\nInsira sua altura (m): ");
            alturaStr = Console.ReadLine();
        }
        static double Calcular(double peso, double altura)
        {
            double imc;
            imc = peso / (altura * altura);
            return imc;
        }
        static void Exibir(double imc)
        {
            Console.WriteLine($"\nO seu IMC é aproximadamente {imc}.");
            if (imc < 18.50)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else
            {
                if (18.50 <= imc && imc < 25.00)
                {
                    Console.WriteLine("Você está no peso ideal.");
                }
                else
                {
                    if (25.00 <= imc && imc < 30.00)
                    {
                        Console.WriteLine("Você está acima do peso ideal.");
                    }
                    else
                    {
                        if (30.00 <= imc && imc < 35.00)
                        {
                            Console.WriteLine("Você está obeso (grau I).");
                        }
                        else
                        {
                            if (35.00 <= imc && imc < 40.00)
                            {
                                Console.WriteLine("Você está obeso (grau II - severa).");
                            }
                            else
                            {
                                if (imc >= 40.00)
                                {
                                    Console.WriteLine("Você está obeso (grau III - mórbida).");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\nO IMC ideal está entre 18,5 e 25,0.");

            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . .");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            double peso;
            string pesoStr = "";
            double altura;
            string alturaStr = "";
            double imc;

            Coletar(ref pesoStr, ref alturaStr);
            peso = Convert.ToDouble(pesoStr);
            altura = Convert.ToDouble(alturaStr);


            imc = Calcular(peso, altura);

            Exibir(imc);
        }
    }
}
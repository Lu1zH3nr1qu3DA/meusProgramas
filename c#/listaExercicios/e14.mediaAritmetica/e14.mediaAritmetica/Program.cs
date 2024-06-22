using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e14.mediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int faltas;
            decimal nota1;
            decimal nota2;
            decimal nota3;
            decimal nota4;
            decimal media;
            string situacao = "";
            string resposta = "";

            Console.WriteLine("Insira o nome do Aluno.");
            nome = Console.ReadLine();
            Console.WriteLine("\nInsira o número de Faltas.");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 1º Bimestre.");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 2º Bimestre.");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 3º Bimestre.");
            nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 4º Bimestre.");
            nota4 = Convert.ToDecimal(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(faltas > 12)
            {
                situacao = "Reprovado pelo número de faltas.";
            }
            else
            {
                if(media >= 7)
                {
                    situacao = "Aprovado.";
                }
                else
                {
                    if(media >= 5 && media < 7) {
                        situacao = "Exame.";
                    }
                else
                    {
                        if(media < 5) {
                            situacao = "Reprovado.";
                        }
                    }
                }
            }

            while(resposta != "4")
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("\n1 - Exibir notas e faltas");
                Console.WriteLine("2 - Exibir média");
                Console.WriteLine("3 - Exibir situação");
                Console.WriteLine("4 - Sair\n");

                resposta = Console.ReadLine();

                if(resposta == "1") { 
                    Console.Clear();

                    Console.WriteLine("Nome:        " + nome);
                    Console.WriteLine("\nFaltas:      " + faltas);
                    Console.WriteLine("\nNotas");
                    Console.WriteLine("1º Bimestre: " + nota1);
                    Console.WriteLine("2º Bimestre: " + nota2);
                    Console.WriteLine("3º Bimestre: " + nota3);
                    Console.WriteLine("4º Bimestre: " + nota4);
                    
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar. . . ");
                    Console.ReadKey();
                }
                else
                {
                    if(resposta == "2")
                    {
                        Console.Clear();

                        Console.WriteLine("Nome:  " + nome);
                        Console.WriteLine("\nMédia: " + media);
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar. . . ");
                        Console.ReadKey();
                    }
                    else
                    {
                        if(resposta == "3")
                        {
                            Console.Clear();

                            Console.WriteLine("Nome:     " + nome);
                            Console.WriteLine("\nSituação: " + situacao);

                            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . . ");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e14.mediaAritmetica
{
    internal class Program
    {
        static string nome;
        static int faltas;
        static double nota1;
        static double nota2;
        static double nota3;
        static double nota4;
        static double media;
        static string situacao;
        static string resposta;

        static void Inserir()
        {
            Console.WriteLine("Insira o nome do Aluno.");
            nome = Console.ReadLine();
            Console.WriteLine("\nInsira o número de Faltas.");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 1º Bimestre.");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 2º Bimestre.");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 3º Bimestre.");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 4º Bimestre.");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (faltas > 12)
            {
                situacao = "Reprovado pelo número de faltas.";
            }
            else
            {
                if (media >= 7)
                {
                    situacao = "Aprovado.";
                }
                else
                {
                    if (media >= 5 && media < 7)
                    {
                        situacao = "Exame.";
                    }
                    else
                    {
                        if (media < 5)
                        {
                            situacao = "Reprovado.";
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Inserir();

            while (resposta != "5")
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("\n1 - Inserir dados novamente");
                Console.WriteLine("2 - Exibir notas e faltas");
                Console.WriteLine("3 - Exibir média");
                Console.WriteLine("4 - Exibir situação");
                Console.WriteLine("5 - Sair\n");

                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.Clear();
                    Inserir();
                }
                else
                {
                    if (resposta == "2")
                    {
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
                        if (resposta == "3")
                        {
                            Console.Clear();

                            Console.WriteLine("Nome:  " + nome);
                            Console.WriteLine("\nMédia: " + media);
                            Console.WriteLine("\n\nPressione qualquer tecla para continuar. . . ");
                            Console.ReadKey();
                        }
                        else
                        {
                            if (resposta == "4")
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
}
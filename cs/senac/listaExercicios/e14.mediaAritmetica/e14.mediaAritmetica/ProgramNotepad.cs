using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e14
{
    internal class Program
    {
        public static string nome = "";
        public static int faltas = 0;
        public static decimal nota1 = 0;
        public static decimal nota2 = 0;
        public static decimal nota3 = 0;
        public static decimal nota4 = 0;
        public static decimal media = 0;
        public static string situacao = "";
        public static string resposta = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do Aluno.\n");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o número de Faltas.\n");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a nota do 1º Bimestre.\n");
            nota1= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira a nota do 2º Bimestre.\n");
            nota2= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira a nota do 3º Bimestre.\n");
            nota3= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira a nota do 4º Bimestre.\n");
            nota4= Convert.ToDecimal(Console.ReadLine());

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
                Console.WriteLine("\n1 - Exibir notas");
                Console.WriteLine("2 - Exibir média");
                Console.WriteLine("3 - Exibir situação");
                Console.WriteLine("4 - Sair\n");

                resposta = Console.ReadLine();

                if(resposta == "1") { 
                    Console.Clear();

                    Console.WriteLine("Nome:    " + nome);
                    Console.WriteLine("\nFaltas:    " + faltas);
                    Console.WriteLine("\nNotas:");
                    Console.WriteLine("1º Bimestre:    " + nota1);
                    Console.WriteLine("2º Bimestre:    " + nota2);
                    Console.WriteLine("3º Bimestre:    " + nota3);
                    Console.WriteLine("4º Bimestre:    " + nota4);
                    
                    Console.WriteLine("\nPressione ENTER para Continuar.");
                    Console.ReadKey();


                }
                else
                {
                    if(resposta == "2")
                    {
						Console.WriteLine("Nome:	" + nome);
						Console.WriteLine("Média:	" + media);
						
                        Console.WriteLine("\nPressione ENTER para Continuar.");
                        Console.ReadKey();
                    }
                    else
                    {
                        if(resposta == "3")
                        {
							Console.WriteLine("Nome:	" + nome);
							Console.WriteLine("Situação:	" + situacao);
							
                            Console.WriteLine("\nPressione ENTER para Continuar.");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
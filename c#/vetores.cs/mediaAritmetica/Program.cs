using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e14.mediaAritmetica
{
    internal class Program
    {
        static int nAlunos = 0;
        static int nMaterias = 0;
        static string[] aluno = new string[nAlunos];
        static string[] materia = new string[nMaterias];
        static int[] faltas = new int[nAlunos];
        static double[] nota1 = new double[nMaterias];
        static double[] nota2 = new double[nMaterias];
        static double[] nota3 = new double[nMaterias];
        static double[] nota4 = new double[nMaterias];
        static double[] media = new double[nMaterias];
        static string[] situacao = new string[nAlunos];
        static string resposta;

        static void Inserir()
        {
            Console.Write("Insira a quantidade de alunos: ");
            nAlunos = Convert.ToInt32(Console.ReadLine());
            aluno = new string[nAlunos];
            situacao = new string[nAlunos];
            faltas = new int[nAlunos];
            Console.Write("\nInsira a quantidade de matérias: ");
            nMaterias = Convert.ToInt32(Console.ReadLine());
            materia = new string[nMaterias];
            nota1 = new double[nMaterias];
            nota2 = new double[nMaterias];
            nota3 = new double[nMaterias];
            nota4 = new double[nMaterias];
            media = new double[nMaterias];
            for (int imateria = 0; imateria < materia.Length; imateria++)
            {
                Console.Write($"Insira o nome da {imateria + 1}ª matéria: ");
                materia[imateria] = Console.ReadLine();
            }
            for (int ialuno = 0; ialuno < aluno.Length; ialuno++) 
            {
                Console.Write($"\nInsira o nome do {ialuno + 1}º Aluno: ");
                aluno[ialuno] = Console.ReadLine();
                Console.Write($"Insira sua quantidade de faltas: ");
                faltas[ialuno] = Convert.ToInt32(Console.ReadLine());
                for (int imateria = 0; imateria < materia.Length; imateria++)
                {
                    Console.WriteLine($"Inserir Notas de {materia[imateria]}: ");
                    Console.Write("Insira a nota do 1º Bimestre: ");
                    nota1[imateria] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Insira a nota do 2º Bimestre: ");
                    nota2[imateria] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Insira a nota do 3º Bimestre: ");
                    nota3[imateria] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Insira a nota do 4º Bimestre: ");
                    nota4[imateria] = Convert.ToDouble(Console.ReadLine());

                    media[imateria] = (nota1[imateria] + nota2[imateria] + nota3[imateria] + nota4[imateria]) / 4;

                    if (faltas[ialuno] > 10)
                    {
                        situacao[ialuno] = "Reprovado pelo número de faltas.";
                    }
                    else
                    {
                        if (media[imateria] >= 7)
                        {
                            situacao[ialuno] = "Aprovado.";
                        }
                        else
                        {
                            if (media[imateria] >= 5 && media[imateria] < 7)
                            {
                                situacao[ialuno] = "Exame.";
                            }
                            else
                            {
                                if (media[imateria] < 5)
                                {
                                    situacao[ialuno] = "Reprovado.";
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Inserir();

            while (resposta != "3")
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("\n1 - Inserir dados novamente");
                Console.WriteLine("2 - Exibir boletim");
                Console.WriteLine("3 - Sair\n");

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
                        for (int inome = 0; inome < aluno.Length; inome++)
                        {
                            Console.WriteLine($"Nome -     {aluno[inome]}");
                            Console.WriteLine($"Faltas -     {faltas[inome]}");
                            Console.WriteLine("Notas");
                            for (int imateria = 0; imateria < materia.Length; imateria++)
                            {
                                Console.WriteLine($"1º Bimestre: {nota1[imateria]}");
                                Console.WriteLine($"2º Bimestre: {nota2[imateria]}");
                                Console.WriteLine($"3º Bimestre: {nota3[imateria]}");
                                Console.WriteLine($"4º Bimestre: {nota4[imateria]}");
                            }
                            Console.WriteLine($"Situação - {situacao[inome]}\n");
                        }
                        Console.Write("\n\n\nPressione qualquer tecla para continuar. . . ");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
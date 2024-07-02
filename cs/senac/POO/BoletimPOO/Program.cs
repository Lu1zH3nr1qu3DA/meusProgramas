using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOBoletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            
            string resposta = "";


            while (resposta != "4")
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Informe a Disciplina");
                Console.WriteLine("2 - Exibir Média");
                Console.WriteLine("3 - Exibir boletim");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("\n");

                Console.Write("  > ");
                resposta = Console.ReadLine();

                Console.Clear();

                if (resposta == "1")
                {
                    Disciplina objDisciplina = new Disciplina();
                    Console.Write("Insira o nome da Disciplina: ");
                    objDisciplina.Nome = Console.ReadLine();
                    Console.Write($"Insira a 1ª Nota de {objDisciplina.Nome}: ");
                    objDisciplina.Nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Insira a 2ª Nota de {objDisciplina.Nome}: ");
                    objDisciplina.Nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Insira a quantidade de Faltas nas aulas de {objDisciplina.Nome}: ");
                    objDisciplina.Faltas = Convert.ToInt16(Console.ReadLine());

                    objDisciplina.CalcSituacao();

                    listaDisciplinas.Add(objDisciplina);
                }
                else
                {
                    if (resposta == "2")
                    {
                        foreach (Disciplina obj in listaDisciplinas)
                        {
                            obj.CalcSituacao();
                        }
                    }
                    else
                    {
                        if (resposta == "3")
                        {
                            foreach (Disciplina disciplina in listaDisciplinas)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine($"________________________________");
                                Console.WriteLine(disciplina.Nome);
                                Console.WriteLine($"Nota 1: {disciplina.Nota1}");
                                Console.WriteLine($"Nota 2: {disciplina.Nota2}");
                                Console.WriteLine($"Faltas: {disciplina.Faltas}");
                                Console.WriteLine($"Média: {disciplina.Media}");
                                Console.WriteLine($"Situação: {disciplina.Situacao}");
                            }
                            Console.WriteLine($"________________________________");
                        }
                    }
                }
                Console.Write("\n\nPressione qualquer tecla para continuar. . . ");
                Console.ReadKey();
            }
        }
    }
}
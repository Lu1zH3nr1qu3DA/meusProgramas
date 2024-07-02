using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno objaluno = new Aluno();

            //Console.Write("Informe o nome: ");
            //objaluno.Nome = Console.ReadLine();
            //Console.Write("Informe a data de Nascimento: ");
            //objaluno.Nascimento = Convert.ToDateTime(Console.ReadLine());
            //Console.Write("Infome o CPF/CNPJ: ");
            //objaluno.CpfCnpj = Console.ReadLine();

            //objaluno.CalculaDias();

            Triangulo objtriangulo = new Triangulo();

            Console.Write("Insira o tamanho do Lado A: ");
            objtriangulo.LadoA = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insira o tamanho do Lado B: ");
            objtriangulo.LadoB = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insira o tamanho do Lado C: ");
            objtriangulo.LadoC = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n\nPressione qualquer tecla para continuar. . . ");
            Console.ReadKey();
        }
    }
}

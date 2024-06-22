using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cidadesPredefinidas = { "Prudente", "Assis", "Bauru", "Maringá" };
            int n;

            Console.WriteLine("Lista de Cidades\n");

            Console.Write("Insira o número de cidades: ");
            n = Convert.ToInt32(Console.ReadLine());
            string[] cidadesInseridas = new string[n];

            for (int posicao = 0; posicao <= cidadesInseridas.Length - 1; posicao++)
            {
                Console.Write($"Insira o nome da {posicao+1}ª cidade: ");
                cidadesInseridas[posicao] = Console.ReadLine();
            }

            Array.Sort(cidadesInseridas);
            Console.WriteLine("\nCidades Inseridas: ");
            for (int posicao = 0; posicao <= cidadesInseridas.Length-1; posicao++)
            {
                Console.WriteLine($"Posição: {posicao} - Cidade: {cidadesInseridas[posicao]}");
            }

            Array.Sort(cidadesPredefinidas);
            Console.WriteLine("\nCidades Predefidas: ");
            for (int posicao = 0; posicao <= cidadesPredefinidas.Length - 1; posicao++)
            {
                Console.WriteLine($"Posição: {posicao} - Cidade: {cidadesPredefinidas[posicao]}");
            }

            Console.Write("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
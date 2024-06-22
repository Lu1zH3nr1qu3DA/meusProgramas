using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e13.financiamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeProprietario;
            double valorTerreno;
            int tamanhoTerreno;
            double valorEntrada;
            int numeroParcelas;
            double valorParcela;
            double valorMetroQuadrado;
            int parcela = 1;

            Console.WriteLine("Insira o nome do Proprietário.");
            nomeProprietario = Console.ReadLine();
            Console.WriteLine("\nInsira o valor do Terreno.");
            valorTerreno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira o tamanho do Terreno (m²).");
            tamanhoTerreno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira o valor de Entrada.");
            valorEntrada = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira o número de Parcelas.");
            numeroParcelas = Convert.ToInt32(Console.ReadLine());

            valorParcela = (valorTerreno - valorEntrada) / numeroParcelas;
            valorMetroQuadrado = valorTerreno / tamanhoTerreno;

            Console.Clear();

            while(parcela <= numeroParcelas) {
                Console.WriteLine("Parcela " + parcela + " - Valor: R$" + valorParcela + "  Data: " + DateTime.Today.Date.AddMonths(parcela));
                parcela = parcela + 1;
            }
            Console.WriteLine("\nO valor do m²: R$" +valorMetroQuadrado);

            Console.WriteLine("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e15.diasVividos.funcoes
{
    internal class Program
    {
        static void Inserir(ref int dia, ref int mes, ref int ano, ref DateTime tempoData)
        {
            Console.Write("Insira o Dia em que voce nasceu: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Mês em que você nasceu: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Ano em que você nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
            tempoData = new DateTime(ano, mes, dia);
        }
        static int Calcular(ref int tempo, ref DateTime tempoData)
        {
            tempo = DateTime.Now.Subtract(tempoData).Days;
            return tempo;
        }

        static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int tempo = 0;
            DateTime tempoData = DateTime.Today;

            Inserir(ref dia, ref mes, ref ano, ref tempoData);

            Calcular(ref tempo, ref tempoData);

            Console.Write($"\nVocê viveu, aproximadamente, {tempo} dias.");
            Console.ReadKey();
        }
    }
}
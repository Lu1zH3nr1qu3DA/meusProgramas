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
        static void Inserir(ref int diaAtual, ref int mesAtual, ref int anoAtual, ref int dia, ref int mes, ref int ano)
        {
            Console.Write("Insira o Dia de hoje: ");
            diaAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Mês em que você nasceu: ");
            mesAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Ano em que você nasceu: ");
            anoAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Dia em que voce nasceu: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Mês em que você nasceu: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Ano em que você nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
        }
        static int Calcular(ref int tempo, ref int dia, ref int mes, ref int ano, ref int diaAtual, ref int mesAtual, ref int anoAtual)
        {
            tempo = (diaAtual - dia) + ((mesAtual - mes) * 30) + ((anoAtual - ano) * 365);
            return tempo;
        }

        static void Main(string[] args)
        {
            int diaAtual = 0;
            int mesAtual = 0;
            int anoAtual = 0;
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int tempo = 0;

            Inserir(ref diaAtual, ref mesAtual, ref anoAtual, ref dia, ref mes, ref ano);

            Calcular(ref tempo, ref dia, ref mes, ref ano, ref diaAtual, ref mesAtual, ref anoAtual);

            Console.Write($"\nVocê viveu, aproximadamente, {tempo} dias.");
            Console.ReadKey();
        }
    }
}
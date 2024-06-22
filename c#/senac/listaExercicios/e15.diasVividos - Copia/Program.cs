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
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int ano;
            int dias;
            int meses;
            int anos;
            string tempo;

            Console.Write("Insira o Dia em que voce nasceu: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Mês em que você nasceu: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o Ano em que você nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
            DateTime tempoo = new DateTime(ano, mes, dia, 0, 0, 0, 0);

            tempo = Convert.ToInt32(DateTime.Now.Day - dia) + ((Convert.ToInt32(DateTime.Now.Month) - mes) * 30) + ((Convert.ToInt32(DateTime.Now.Year) - ano) * 365);
            tempo = Convert.ToString(DateTime.Now.Date.Subtract(tempoo));
            anos = tempo / 365;
            meses = (tempo % 365) / 30;
            dias = (tempo % 365) % 30;

            Console.Write($"\nVocê viveu, aproximadamente, {anos} anos, {meses} meses, e {dias} dias.   {tempo}     {tempo}");

            Console.WriteLine("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}
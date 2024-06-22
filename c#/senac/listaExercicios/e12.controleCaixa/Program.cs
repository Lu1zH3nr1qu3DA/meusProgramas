using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e12.controleCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double credito = 0.00;
            double debito = 0.00;
            double valor;
            double saldo;
            string resposta = "";

            while (resposta != "4")
            {
                Console.Clear();
                Console.WriteLine("Sistema de Controle de Caixa");
                Console.WriteLine("\nDigite uma opção");
                Console.WriteLine("1 - Adicionar Crédito");
                Console.WriteLine("2 - Adicionar Débito");
                Console.WriteLine("3 - Consultar saldo");
                Console.WriteLine("4 - Sair\n");
                resposta = Console.ReadLine();
                Console.Clear();

                if(resposta == "1") {
                    Console.Write("Insira o valor de crédito.\nR$");
                    valor = Convert.ToDouble(Console.ReadLine());
                    credito = credito + valor;
                }
                else
                {
                    if (resposta == "2")
                    {
                        Console.Write("Insira o valor de débito.\nR$");
                        valor = Convert.ToDouble(Console.ReadLine());
                        debito = debito + valor;
                    }
                    else
                    {
                        if (resposta == "3")
                        {
                            saldo = credito - debito;
                            saldo = Math.Round(saldo, 2);
                            Console.WriteLine("Você tem um saldo de R$" + saldo);
                            Console.WriteLine("Pressione qualquer tecla para continuar. . . ");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
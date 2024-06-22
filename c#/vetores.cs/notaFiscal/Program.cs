using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notaFiscal
{
    internal class Program
    {
        static int nProdutos = 0;
        static string[] produto = new string[nProdutos];
        static string[] origem = new string[nProdutos];
        static double[] valor = new double[nProdutos];
        static int[] quantidade = new int[nProdutos];
        static double[] icms = new double[nProdutos];
        static double[] subtotal = new double[nProdutos];
        static double comissao = 0;
        static double total = 0.00;
        static string resposta;

        static void Exibir()
        {
            for (int xproduto = 0; xproduto < produto.Length; xproduto++)
            {
                Console.WriteLine($"\nProduto nº{xproduto + 1}  - {produto[xproduto]}");
                Console.WriteLine($"Valor        - R${Math.Round(valor[xproduto], 2)}");
                Console.WriteLine($"Quantidade   - {quantidade[xproduto]}");
                Console.WriteLine($"Origem       - {origem[xproduto]}");
                Console.WriteLine($"ICMS         - {icms[xproduto]}%");
                Console.WriteLine($"Total        - R${Math.Round(subtotal[xproduto], 2)}");
                total = total + subtotal[xproduto];
            }
            Console.WriteLine($"\nTotal        - R${Math.Round(total, 2)}");

            comissao = total * 0.25;
            Console.WriteLine($"Comissão Total - R${Math.Round(comissao, 2)}");
        }
        static void Main(string[] args)
        {

            while (resposta != "5")
            {
                Console.Clear();

                Console.WriteLine("..........Nota Fiscal (CRUD)...........");  //          CRUD: Create, Read, Update and Delete)
                Console.WriteLine("............Menu de Opções.............\n");
                Console.WriteLine("Digite uma opção.");
                Console.WriteLine("\n(1) - Adicionar Produtos\n");
                Console.WriteLine("(2) - Calcular Comissão\n");
                Console.WriteLine("(3) - Imprimir Danfe\n");
                Console.WriteLine("(4) - Excluir um Produto\n");
                Console.WriteLine("(5) - Sair\n");

                resposta = Console.ReadLine();

                Console.Clear();

                if (resposta == "1")
                {
                    Console.Write($"Quantidade de produtos: ");
                    nProdutos = Convert.ToInt32(Console.ReadLine());

                    produto = new string[nProdutos];
                    origem = new string[nProdutos];
                    valor = new double[nProdutos];
                    quantidade = new int[nProdutos];
                    icms = new double[nProdutos];
                    subtotal = new double[nProdutos];

                    for (int xproduto = 0; xproduto < produto.Length; xproduto++)
                    {
                        Console.Write($"\nInforme o Produto: ");
                        produto[xproduto] = Console.ReadLine();
                        Console.Write($"Informe o Valor do(a) {produto[xproduto]}: R$");
                        valor[xproduto] = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"Informe a Quantidade de {produto[xproduto]}s: ");
                        quantidade[xproduto] = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Informe a Origem do produto: ");
                        origem[xproduto] = Console.ReadLine();
                        Console.Write($"Informe o valor do ICMS: ");
                        icms[xproduto] = Convert.ToDouble(Console.ReadLine());

                        subtotal[xproduto] = (valor[xproduto] * quantidade[xproduto]) + ((valor[xproduto] / 100) * icms[xproduto]);
                    }
                }
                else
                {
                    if (resposta == "2")
                    {
                        Exibir();

                        Console.Write("\n\nPressione qualquer tecla para continuar. . . ");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (resposta == "3")
                        {
                            Exibir();
                            Console.Write($"Insira o número do Produto que você deseja excluir: ");
                            resposta = Console.ReadLine();


                        }
                    }
                }
            }
        }
    }
}
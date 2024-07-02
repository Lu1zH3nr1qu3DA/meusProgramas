using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Danfe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes();
            List<Produtos> listProdutos = new List<Produtos>();

            string resposta = "";

            while (resposta != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Informar o Cliente");
                Console.WriteLine("2 - Informar os Produtos");
                Console.WriteLine("3 - Imprimir Danfe");
                Console.WriteLine("4 - Sair\n");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Console.Write("Insira o Nome do cliente: ");
                        cliente.Nome = Console.ReadLine();
                        Console.Write($"Insira o Endereço de {cliente.Nome}: ");
                        cliente.Endereco = Console.ReadLine();
                        Console.Write($"Insira o Número de {cliente.Nome}: ");
                        cliente.Numero = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Insira a Cidade de {cliente.Nome}: ");
                        cliente.Cidade = Console.ReadLine();
                        break;
                    case "2":
                        Produtos produto = new Produtos();

                        produto.Item = listProdutos.Count;
                        Console.Write("Insira o Nome do Produto: ");
                        produto.Nome = Console.ReadLine();
                        Console.Write($"Insira o Preço do(a) {produto.Nome}: ");
                        produto.ValUnitario = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"Insira a Quantidade do(a) {produto.Nome}: ");
                        produto.Quantidade = Convert.ToInt16(Console.ReadLine());

                        produto.CalcSubtotal();

                        listProdutos.Add(produto);
                        break;
                    case "3":
                        int larguraTabela = 96;
                        Console.Clear();
                        Linha(ref larguraTabela);
                        Console.WriteLine($"Nome: {cliente.Nome}");
                        Console.WriteLine($"Endereço: {cliente.Endereco}");
                        Console.WriteLine($"Número: {cliente.Numero}");
                        Console.WriteLine($"Cidade: {cliente.Cidade}\n");
                        Linha(ref larguraTabela);
                        Cabecalho(ref larguraTabela, "Item", "Produto", "Valor Unitário", "Quantidade", "Subtotal");
                        foreach (Produtos objProduto in listProdutos)
                        {
                            Linha(ref larguraTabela);
                            Cabecalho(ref larguraTabela, $"{objProduto.Item}", $"{objProduto.Nome}", $"{objProduto.ValUnitario.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{objProduto.Quantidade}", $"{objProduto.Subtotal.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
                        }
                        Linha(ref larguraTabela);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Erro: a opção inserida não existe.");
                        break;
                }
                Console.Write("\n\nPressione qualquer tecla para continuar. . . ");
                Console.ReadKey();
            }

            void Linha(ref int larguraTabela)
            {
                Console.WriteLine(new string('-', larguraTabela));
            }
            void Cabecalho(ref int larguraTabela, params string[] colunas)
            {
                int largura = (larguraTabela - colunas.Length) / colunas.Length;
                string row = "|";

                foreach (string coluna in colunas)
                {
                    row += Centralizar(coluna, largura) + "|";
                }

                Console.WriteLine(row);
            }
            string Centralizar(string texto, int largura)
            {
                texto = texto.Length > largura ? texto.Substring(0, largura - 3) + "..." : texto;

                if (string.IsNullOrEmpty(texto))
                {
                    return new string(' ', largura);
                }
                else
                {
                    return texto.PadRight(largura - (largura - texto.Length) / 2).PadLeft(largura);
                }
            }
        }
    }
}
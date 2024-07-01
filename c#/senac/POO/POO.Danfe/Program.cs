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
            List<Clientes> clientes = new List<Clientes>();
            List<Produtos> produtos = new List<Produtos>();

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
                        Clientes cliente = new Clientes();
                        InserirCliente(ref cliente);
                        clientes.Add(cliente);
                        break;
                    case "2":
                        Produtos produto = new Produtos();
                        InserirProduto(ref produto);
                        produtos.Add(produto);
                        break;
                    case "3":
                        ExibirTabela();
                        break;
                    default:
                        Console.WriteLine("Erro: a opção inserida não existe.");
                        break;
                }
                Console.Write("\n\nPressione qualquer tecla para continuar. . . ");
                Console.ReadKey();
            }

            void InserirCliente(ref Clientes cliente)
            {
                Console.Write("Insira o Nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.Write($"Insira o Endereço de {cliente.Nome}: ");
                cliente.Endereco = Console.ReadLine();
                Console.Write($"Insira o Número de {cliente.Nome}: ");
                cliente.Numero = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Insira a Cidade de {cliente.Nome}: ");
                cliente.Cidade = Console.ReadLine();
            }

            void InserirProduto(ref Produtos produto)
            {
                Console.Write("Insira o Nome do Produto: ");
                produto.Nome = Console.ReadLine();
                Console.Write($"Insira o Preço do(a) {produto.Nome}: ");
                produto.ValUnitario = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Insira a Quantidade do(a) {produto.Nome}: ");
                produto.Quantidade = Convert.ToInt16(Console.ReadLine());
            }

            void ExibirTabela()
            {
                int larguraTabela = 96;
                Console.Clear();
                Linha(ref larguraTabela);
                foreach (Clientes cliente in clientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}");
                    Console.WriteLine($"Endereço: {cliente.Endereco}");
                    Console.WriteLine($"Número: {cliente.Numero}");
                    Console.WriteLine($"Cidade: {cliente.Cidade}\n");
                    foreach (Produtos produto in produtos)
                    {
                        Linha(ref larguraTabela);
                        Cabecalho(ref larguraTabela, "Item", "Produto", "Valor Unitário", "Quantidade", "Total");
                        Linha(ref larguraTabela);
                        Cabecalho(ref larguraTabela, $"{produto.Item}", $"{produto.Nome}", $"{produto.ValUnitario}", $"{produto.Quantidade}", $"{produto.Total}");
                    }
                }
                Linha(ref larguraTabela);
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
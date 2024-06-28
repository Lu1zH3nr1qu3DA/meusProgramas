using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POOFolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> listFuncionarios = new List<Funcionarios>();

            int ultimoFuncionario = 0;

            string resposta = "";

            while (resposta != "5")
            {
                Console.Clear();
                Console.WriteLine(".......Folha de Pagamento (CRUD).......");
                Console.WriteLine("............Menu de Opções.............\n");
                Console.WriteLine("Digite uma opção.");
                Console.WriteLine("(1) - Cadastrar um Funcionário");
                Console.WriteLine("(2) - Listar Funcionários");
                Console.WriteLine("(3) - Alterar um Funcionário");
                Console.WriteLine("(4) - Excluir um Funcionário");
                Console.WriteLine("(5) - Sair\n");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Funcionarios objFuncionarios = new Funcionarios();
                        Inserir(ref objFuncionarios);
                        listFuncionarios.Add(objFuncionarios);
                        break;
                    case "2":
                        int tableWidth = 96;
                        Console.Clear();
                        PrintLine(ref tableWidth);
                        PrintRow(ref tableWidth, "ID", "Nome", "Salário", "INSS", "IR", "Valor Líquido");
                        PrintLine(ref tableWidth);
                        foreach (Funcionarios funcionario in listFuncionarios)
                        {
                            PrintRow(ref tableWidth, $"{funcionario.Id}", $"{funcionario.Nome}", $"{funcionario.Salario.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValInss.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValIR.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValLiquido.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
                        }
                        PrintLine(ref tableWidth);
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Insira o Número do funcionário que deseja Alterar: ");
                        resposta = Console.ReadLine();
                        int alterar = Convert.ToInt16(resposta);
                        listFuncionarios.ElementAt(alterar);
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Insira o Número do funcionário que deseja Excluir: ");
                        resposta = Console.ReadLine();
                        int excluir = Convert.ToInt16(resposta) - 1;
                        listFuncionarios.RemoveAt(excluir);
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("\nErro: A opção inserida não existe.");
                        break;
                }
                Console.Write("\n\n\nPressione qualquer tecla para continuar. . . ");
                Console.ReadKey();
            }
            void Inserir(ref Funcionarios objFuncionarios)
            {
                Console.Write("Insira o Nome do funcionário: ");
                objFuncionarios.Nome = Console.ReadLine();
                Console.Write($"Insira o valor do Salário de {objFuncionarios.Nome}: R$  ");
                objFuncionarios.Salario = Convert.ToDouble(Console.ReadLine());

                objFuncionarios.Inss();
                objFuncionarios.IR();
                objFuncionarios.VLiquido();
                ultimoFuncionario++;
                objFuncionarios.Id = ultimoFuncionario;
            }
            void PrintLine(ref int tableWidth)
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            void PrintRow( ref int tableWidth, params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            string AlignCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }
        }
    }
}
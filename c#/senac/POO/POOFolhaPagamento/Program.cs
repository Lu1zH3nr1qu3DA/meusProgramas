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
                        ExibirTabela();
                        break;
                    case "3":
                        Console.Clear();
                        ExibirTabela();

                        Console.Write("Insira o Número do funcionário que deseja Alterar: ");
                        resposta = Console.ReadLine();
                        int alterar = Convert.ToInt16(resposta);

                        break;
                    case "4":
                        Console.Clear();
                        ExibirTabela();

                        Console.Write("Insira o Número do funcionário que deseja Excluir: ");
                        resposta = Console.ReadLine();
                        int excluir = Convert.ToInt16(resposta);
                        listFuncionarios.RemoveAll(delegate(Funcionarios funcionario) { return funcionario.Id == excluir; });
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
            void Linha(ref int larguraTabela)
            {
                Console.WriteLine(new string('-', larguraTabela));
            }

            void Cabecalho( ref int larguraTabela, params string[] colunas)
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
            void ExibirTabela()
            {
                int larguraTabela = 96;
                Console.Clear();
                Linha(ref larguraTabela);
                Cabecalho(ref larguraTabela, "ID", "Nome", "Salário", "INSS", "IR", "Valor Líquido");
                Linha(ref larguraTabela);
                foreach (Funcionarios funcionario in listFuncionarios)
                {
                    Cabecalho(ref larguraTabela, $"{funcionario.Id}", $"{funcionario.Nome}", $"{funcionario.Salario.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValInss.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValIR.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}", $"{funcionario.ValLiquido.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
                }
                Linha(ref larguraTabela);
            }
        }
    }
}
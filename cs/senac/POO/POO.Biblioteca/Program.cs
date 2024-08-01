using bibliotecaconsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    internal class Program
    {
        static string resposta = "";

        static Tabela tabela = new Tabela();
        static Aluno objaluno = new Aluno();
        static Autor objautor = new Autor();
        static Editora objeditora = new Editora();
        static Livro objlivro = new Livro();
        static Emprestimo objemprestimo = new Emprestimo();
        static ItemEmprestimo objitememprestimo = new ItemEmprestimo();

        static List<Aluno> Alunos = new List<Aluno>();
        static List<Autor> Autores = new List<Autor>();
        static List<Editora> Editoras = new List<Editora>();
        static List<Livro> Livros = new List<Livro>();
        static List<Emprestimo> Emprestimos = new List<Emprestimo>();
        static List<ItemEmprestimo> ItensEmprestimos = new List<ItemEmprestimo>();



        static void Main(string[] args)
        {
            int codigo = 0;

            while (resposta != "9") //Menu principal
            {
                Console.Clear();
                Console.WriteLine(". . . . . . Biblioteca . . . . . .\n");
                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Autor");
                Console.WriteLine("3 - Editora");
                Console.WriteLine("4 - Livro");
                Console.WriteLine("5 - Emprestimo\n");
                Console.WriteLine("6 - Sair\n");
                Console.Write(">> ");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1": //Menu alunos
                        while (resposta != "5")
                        {
                            Console.Clear();
                            Console.WriteLine(". . . . . . Alunos . . . . . .\n");
                            Console.WriteLine("Escolha uma opção.");
                            Console.WriteLine("1 - Cadastrar");
                            Console.WriteLine("2 - Listar");
                            Console.WriteLine("3 - Alterar");
                            Console.WriteLine("4 - Excluir\n");
                            Console.WriteLine("5 - Voltar para o Menu anterior\n");
                            Console.Write(">> ");

                            resposta = Console.ReadLine();

                            switch (resposta)
                            {
                                case "1": //Cadastrar aluno
                                    Console.Clear();
                                    objaluno.InserirDados(ref objaluno);

                                    Alunos.Add(objaluno);

                                    Alunos = Alunos.OrderBy(aluno => aluno.Codigo).ToList();
                                    break;
                                case "2": //Listar alunos
                                    Console.Clear();
                                    tabela.Linha();
                                    tabela.Cabecalho("Código", "Nome", "Celular");
                                    tabela.Linha();
                                    foreach (Aluno alunos in Alunos)
                                    {
                                        tabela.Linha();
                                        tabela.Cabecalho($"{alunos.Codigo}", $"{alunos.Nome}", $"{alunos.Celular}");
                                    }
                                    tabela.Linha();
                                    Console.Write("Pressione qualquer tecla para continuar. . . ");

                                    Console.ReadKey();
                                    break;
                                case "3": //Alterar aluno
                                    Console.Clear();
                                    Console.Write("Insira o Código do Aluno que deseja Alterar: ");

                                    codigo = Convert.ToInt16(Console.ReadLine());

                                    var item = Alunos.First(aluno => aluno.Codigo == codigo);

                                    objaluno = item;

                                    Console.WriteLine("Para manter os valores originais, pressione <Enter>.");

                                    objaluno.InserirDados(ref objaluno);

                                    Alunos = Alunos.OrderBy(aluno => aluno.Codigo).ToList();
                                    break;
                                case "4": //Excluir aluno
                                    Console.Clear();
                                    Console.WriteLine("Informe o Código do Aluno para Excluir: ");

                                    codigo = Convert.ToInt32(Console.ReadLine());

                                    Alunos.RemoveAll(delegate (Aluno f) { return f.Codigo == codigo; });
                                    break;
                                case "5":
                                    break;
                                default:
                                    Console.WriteLine("Erro: a opção inserida não existe. ");
                                    Console.Write("Pressione qualquer tecla para continuar. . . ");

                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case "2": //Menu autores
                        Console.Clear();
                        Console.WriteLine(". . . . . . Autores . . . . . .\n");
                        Console.WriteLine("Escolha uma opção.");
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.WriteLine("5 - Voltar para o Menu anterior\n");
                        Console.Write(">> ");

                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar autor
                                Console.Clear();
                                objautor.InserirAutor(ref objautor);
                                
                                Autores.Add(objautor);

                                Autores = Autores.OrderBy(autor => autor.Codigo).ToList();
                                break;
                            case "2": //Listar autores
                                Console.Clear();
                                tabela.Linha();
                                tabela.Cabecalho("Código", "Nome", "Email");
                                foreach (Autor autores in Autores)
                                {
                                    tabela.Linha();
                                    tabela.Cabecalho($"{autores.Codigo}", $"{autores.Nome}", $"{autores.Email}");
                                }
                                tabela.Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": //Alterar autor
                                Console.Write("Insira o Código do Autor que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Autores.First(autor => autor.Codigo == codigo);
                                
                                objautor = item;
                                
                                objautor.InserirAutor(ref objautor);

                                Autores = Autores.OrderBy(autor => autor.Codigo).ToList();
                                break;
                            case "4": //Excluir autor
                                Console.Clear();
                                Console.WriteLine("Informe o Código do Autor que deseja Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Autores.RemoveAll(delegate (Autor f) { return f.Codigo == codigo; });
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "3": //Menu editoras
                        Console.Clear();
                        Console.WriteLine(". . . . . . Editoras . . . . . .\n");
                        Console.WriteLine("Escolha uma opção.");
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.WriteLine("5 - Voltar para o Menu anterior\n");
                        Console.Write(">> ");

                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar editora
                                Console.Clear();
                                objeditora.InserirEditora(ref objeditora);
                                
                                Editoras.Add(objeditora);

                                Editoras = Editoras.OrderBy(editora => editora.Codigo).ToList();
                                break;
                            case "2": //Listar editoras
                                Console.Clear();
                                tabela.Linha();
                                tabela.Cabecalho("Código", "Nome", "Email");
                                tabela.Linha();
                                foreach (Editora editoras in Editoras)
                                {
                                    tabela.Linha();
                                    tabela.Cabecalho($"{editoras.Codigo}", $"{editoras.Nome}", $"{editoras.Email}");
                                }
                                tabela.Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");

                                Console.ReadKey();
                                break;
                            case "3": //Alterar editora
                                Console.Write("Insira o Código da Editora que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Editoras.First(editora => editora.Codigo == codigo);
                                
                                objeditora = new Editora();
                                
                                objeditora = item;
                                
                                objeditora.InserirEditora(ref objeditora);

                                Editoras = Editoras.OrderBy(editora => editora.Codigo).ToList();
                                break;
                            case "4": //Excluir editora
                                Console.Clear();
                                Console.WriteLine("Informe o Código da Editora que deseja Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Editoras.RemoveAll(delegate (Editora f) { return f.Codigo == codigo; });
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "4": //Menu livros
                        Console.Clear();
                        Console.WriteLine(". . . . . . Alunos . . . . . .\n");
                        Console.WriteLine("Escolha uma opção.");
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.WriteLine("5 - Voltar para o Menu anterior\n");
                        Console.Write(">> ");

                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar livro
                                Console.Clear();
                                objlivro.InserirLivro(ref objlivro);
                                
                                Livros.Add(objlivro);

                                Livros = Livros.OrderBy(livro => livro.Codigo).ToList();
                                break;
                            case "2": //Listar livros
                                Console.Clear();
                                tabela.Linha();
                                tabela.Cabecalho("Código", "Título", "Autor");
                                tabela.Linha();
                                foreach (Livro livros in Livros)
                                {
                                    tabela.Linha();
                                    tabela.Cabecalho($"{livros.Codigo}", $"{livros.Titulo}", $"{livros.Autor}");
                                }
                                tabela.Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": // Alterar livro
                                Console.Write("Insira o Código para Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Livros.First(livro => livro.Codigo == codigo);
                                
                                objlivro = item;
                                
                                objlivro.InserirLivro(ref objlivro);

                                Livros = Livros.OrderBy(livro => livro.Codigo).ToList();
                                break;
                            case "4": //Excluir livro
                                Console.Clear();
                                Console.WriteLine("Informe o Código para Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Livros.RemoveAll(delegate (Livro f) { return f.Codigo == codigo; });
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "5": //Menu empréstimos
                        Console.Clear();
                        Console.WriteLine(". . . . . . Empréstimos . . . . . .\n");
                        Console.WriteLine("Escolha uma opção.");
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Renovar");
                        Console.WriteLine("4 - Alterar");
                        Console.WriteLine("5 - Excluir\n");
                        Console.WriteLine("6 - Voltar para o Menu anterior\n");
                        Console.Write(">> ");

                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Menu registrar empréstimo                                
                                Console.Clear();
                                tabela.Cabecalho("Código", "Nome");
                                foreach (Aluno aluno in Alunos)
                                {
                                    tabela.Cabecalho($"{aluno.Codigo}", $"{aluno.Nome}");
                                }

                                objemprestimo.InserirEmprestimo(ref objemprestimo);
                                
                                Console.Write("Informar o código do aluno: ");
                                
                                objaluno.Codigo = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nInforme os dados do emprestimo a ser cadastrado:\n");
                                Console.Write("Código do Empréstimo: ");
                                
                                objemprestimo.Codigo = Convert.ToInt32(Console.ReadLine());

                                //calcula automaticamente a data do empréstimo -> igual a data atual do sistema
                                objemprestimo.DataEmprestimo = DateTime.Today;
                                
                                Console.WriteLine("\nA data do empréstimo foi determinada automaticamente.");
                                Console.WriteLine("Para concordar tecle <Enter>. Para alterar informe a nova data.");
                                Console.Write("\nData do Empréstimo: " + objemprestimo.DataEmprestimo.ToString("dd/MM/yyyy") + " -> "); 
                                
                                string empNovaInf = Console.ReadLine();
                                
                                objemprestimo.DataEmprestimo = (empNovaInf != "") ? Convert.ToDateTime(empNovaInf) : objemprestimo.DataEmprestimo;

                                //calcula automaticamente a data de devolução (30 dias após o empréstimo)
                                objemprestimo.DataDevolucao = objemprestimo.DataEmprestimo.AddDays(30);
                                
                                Console.WriteLine("\nA data de devolução do empréstimo foi determinada automaticamente.");
                                Console.WriteLine("Para concordar tecle <Enter>. Para alterar informe a nova data.");
                                Console.Write("\nData da Devolução: " + objemprestimo.DataDevolucao.ToString("dd/MM/yyyy") + " -> ");
                                
                                empNovaInf = Console.ReadLine();
                                
                                objemprestimo.DataDevolucao = (empNovaInf != "") ? Convert.ToDateTime(empNovaInf) : objemprestimo.DataDevolucao;

                                Console.Write("\nObservações do Empréstimo: ");
                                
                                objemprestimo.Observacoes = Console.ReadLine();
                                break;
                            case "2": //Listar empréstimos
                                break;
                            case "3": //Alterar empréstimo
                                break;
                            case "4": //Excluir empréstimo
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "6":
                        Console.Write("Tem certeza que deseja sair? TODOS OS DADOS SERÃO PERDIDOS. Continuar? (S/N) ");

                        resposta = Console.ReadLine();

                        if (resposta == "S" || resposta == "s" || resposta == "Y" || resposta == "y")
                        {
                           return;
                        }
                        break;
                    default:
                        Console.WriteLine("Erro: a opção inserida não existe.");
                        break;
                }
                Console.Write("Pressione qualquer tecla para continuar. . . ");

                Console.ReadKey();
            }
        }
    }
}
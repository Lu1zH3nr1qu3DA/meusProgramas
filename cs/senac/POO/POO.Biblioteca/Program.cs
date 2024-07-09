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
        static void Main(string[] args)
        {
            string resposta = "";

            int codigo = 0;

            Tabela tabela = new Tabela();

            List<Aluno> Alunos = new List<Aluno>();
            List<Autor> Autores = new List<Autor>();
            List<Editora> Editoras = new List<Editora>();
            List<Livro> Livros = new List<Livro>();

            while (resposta != "9")
            {
                Console.Clear();
                Console.WriteLine(". . . . . . Biblioteca . . . . . .\n");
                Console.WriteLine("Escolha uma opção."); //Menu principal
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Autor");
                Console.WriteLine("3 - Editora");
                Console.WriteLine("4 - Livro");
                Console.WriteLine("5 - Emprestimo\n");
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
                                    Aluno objaluno = new Aluno();

                                    Console.Clear();
                                    objaluno.InserirDados(ref objaluno);

                                    Alunos.Add(objaluno);
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

                                    objaluno.InserirDados(ref objaluno);
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
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.Write(">> ");

                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar autor
                                Autor objautor = new Autor();

                                Console.Clear();
                                objautor.InserirAutor(ref objautor);
                                
                                Autores.Add(objautor);
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
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Autores.First(autor => autor.Codigo == codigo);
                                
                                objautor = item;
                                
                                objautor.InserirAutor(ref objautor);
                                break;
                            case "4": //Excluir autor
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Autores.RemoveAll(delegate (Autor f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "3": //Menu editoras
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.Write(">> ");
                        
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar editora
                                Editora objeditora = new Editora();
                        
                                Console.Clear();
                                objeditora.InserirEditora(ref objeditora);
                                
                                Editoras.Add(objeditora);
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
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Editoras.First(editora => editora.Codigo == codigo);
                                
                                objeditora = new Editora();
                                
                                objeditora = item;
                                
                                objeditora.InserirEditora(ref objeditora);
                                break;
                            case "4": //Excluir editora
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Editoras.RemoveAll(delegate (Editora f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "4": //Menu livros
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.Write(">> ");
                        
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Cadastrar livro
                                Livro objlivro = new Livro();
                                
                                Console.Clear();
                                objlivro.InserirLivro(ref objlivro);
                                
                                Livros.Add(objlivro);
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
                                break;
                            case "4": //Excluir livro
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                Livros.RemoveAll(delegate (Livro f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
                        }
                        break;
                    case "5": //Menu empréstimos
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir\n");
                        Console.Write(">> ");
                        
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1": //Menu registrar empréstimo
                                Emprestimo objemprestimo = new Emprestimo();
                                
                                List<Aluno> listaAluno = new List<Aluno>();
                                
                                Console.Clear();
                                tabela.Cabecalho("Código", "Nome");
                                foreach (Aluno aluno in listaAluno)
                                {
                                    Console.WriteLine($"{aluno.Codigo}", $"{aluno.Nome}");
                                }
                                objemprestimo.InserirEmprestimo(ref objemprestimo);
                                
                                Aluno objaluno = new Aluno();
                                
                                Console.Write("Informar o código do aluno: ");
                                
                                objaluno.Codigo = Convert.ToInt32(Console.ReadLine());
                                break;
                            case "2": //Listar empréstimos
                                break;
                            case "3": //Alterar empréstimo
                                break;
                            case "4": //Excluir empréstimo
                                break;
                            default:
                                Console.WriteLine("Erro: a opção inserida não existe.");
                                break;
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
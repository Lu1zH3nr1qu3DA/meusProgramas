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
        //Variáveis
        static string resposta = "";

        static int codigo = 0;

        //Objetos
        static Tabela tabela = new Tabela();
        static Aluno aluno = new Aluno();
        static Autor autor = new Autor();
        static Editora editora = new Editora();
        static Livro livro = new Livro();
        static Emprestimo emprestimo = new Emprestimo();
        static ItemEmprestimo itemEmprestimo = new ItemEmprestimo();

        //Listas
        static List<Aluno> alunos = new List<Aluno>();
        static List<Autor> autores = new List<Autor>();
        static List<Editora> editoras = new List<Editora>();
        static List<Livro> livros = new List<Livro>();
        static List<Emprestimo> emprestimos = new List<Emprestimo>();
        static List<ItemEmprestimo> itensEmprestimo = new List<ItemEmprestimo>();

        //Funções
        static void ListarAlunos()
        {
            tabela.Linha();
            tabela.Cabecalho("Código", "Nome", "Nascimento", "Celular");
            tabela.Linha();
            foreach (Aluno alunos in alunos)
            {
                tabela.Linha();
                tabela.Cabecalho($"{alunos.Codigo}", $"{alunos.Nome}", $"{alunos.Nascimento.Date}", $"{alunos.Celular}");
            }
            tabela.Linha();
        }

        static void ListarAutores()
        {
            tabela.Linha();
            tabela.Cabecalho("Código", "Nome", "Email");
            foreach (Autor autores in autores)
            {
                tabela.Linha();
                tabela.Cabecalho($"{autores.Codigo}", $"{autores.Nome}", $"{autores.Email}");
            }
            tabela.Linha();
        }

        static void ListarEditoras()
        {
            tabela.Linha();
            tabela.Cabecalho("Código", "Nome", "Email");
            tabela.Linha();
            foreach (Editora editoras in editoras)
            {
                tabela.Linha();
                tabela.Cabecalho($"{editoras.Codigo}", $"{editoras.Nome}", $"{editoras.Email}");
            }
            tabela.Linha();
        }

        static void ListarLivros()
        {
            tabela.Linha();
            tabela.Cabecalho("Código", "Título", "Autor");
            tabela.Linha();
            foreach (Livro livros in livros)
            {
                tabela.Linha();
                tabela.Cabecalho($"{livros.Codigo}", $"{livros.Titulo}", $"{livros.Autor}");
            }
            tabela.Linha();
        }

        static void ListarEmprestimos()
        {
            tabela.Linha();
            tabela.Cabecalho("Código", "Nome");
            tabela.Linha();
            foreach (Emprestimo emprestimo in emprestimos)
            {
                tabela.Linha();
                tabela.Cabecalho($"{emprestimo.Codigo}", $"{emprestimo.Observacoes}");
            }
            tabela.Linha();
        }

        static void Main(string[] args)
        {

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
                                    aluno.InserirDados(ref aluno);

                                    alunos.Add(aluno);

                                    alunos = alunos.OrderBy(aluno => aluno.Codigo).ToList();
                                    break;
                                case "2": //Listar alunos
                                    Console.Clear();
                                    ListarAlunos();
                                    Console.Write("Pressione qualquer tecla para continuar. . . ");

                                    Console.ReadKey();
                                    break;
                                case "3": //Alterar aluno
                                    Console.Clear();
                                    Console.Write("Insira o Código do Aluno que deseja Alterar: ");

                                    codigo = Convert.ToInt16(Console.ReadLine());

                                    var item = alunos.First(aluno => aluno.Codigo == codigo);

                                    aluno = item;

                                    Console.WriteLine("Para manter os valores originais, pressione <Enter>.");

                                    aluno.InserirDados(ref aluno);

                                    alunos = alunos.OrderBy(aluno => aluno.Codigo).ToList();
                                    break;
                                case "4": //Excluir aluno
                                    Console.Clear();
                                    Console.WriteLine("Informe o Código do Aluno para Excluir: ");

                                    codigo = Convert.ToInt32(Console.ReadLine());

                                    alunos.RemoveAll(delegate (Aluno f) { return f.Codigo == codigo; });
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
                                autor.InserirAutor(ref autor);
                                
                                autores.Add(autor);

                                autores = autores.OrderBy(obj => obj.Codigo).ToList();
                                break;
                            case "2": //Listar autores
                                Console.Clear();
                                ListarAutores();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": //Alterar autor
                                Console.Write("Insira o Código do Autor que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = autores.First(obj => obj.Codigo == codigo);
                                
                                autor = item;
                                
                                autor.InserirAutor(ref autor);

                                autores = autores.OrderBy(obj => obj.Codigo).ToList();
                                break;
                            case "4": //Excluir autor
                                Console.Clear();
                                Console.WriteLine("Informe o Código do Autor que deseja Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                autores.RemoveAll(delegate (Autor f) { return f.Codigo == codigo; });
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
                                Editora objeditora = new Editora();
                        
                                Console.Clear();
                                objeditora.InserirEditora(ref objeditora);
                                
                                editoras.Add(objeditora);

                                editoras = editoras.OrderBy(editora => editora.Codigo).ToList();
                                break;
                            case "2": //Listar editoras
                                Console.Clear();
                                ListarEditoras();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");

                                Console.ReadKey();
                                break;
                            case "3": //Alterar editora
                                Console.Write("Insira o Código da Editora que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = editoras.First(editora => editora.Codigo == codigo);
                                
                                objeditora = new Editora();
                                
                                objeditora = item;
                                
                                objeditora.InserirEditora(ref objeditora);

                                editoras = editoras.OrderBy(editora => editora.Codigo).ToList();
                                break;
                            case "4": //Excluir editora
                                Console.Clear();
                                Console.WriteLine("Informe o Código da Editora que deseja Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                editoras.RemoveAll(delegate (Editora f) { return f.Codigo == codigo; });
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
                                Livro objlivro = new Livro();
                                
                                Console.Clear();
                                objlivro.InserirLivro(ref objlivro);
                                
                                livros.Add(objlivro);

                                livros = livros.OrderBy(livro => livro.Codigo).ToList();
                                break;
                            case "2": //Listar livros
                                Console.Clear();
                                ListarLivros();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": // Alterar livro
                                Console.Write("Insira o Código para Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = livros.First(livro => livro.Codigo == codigo);
                                
                                objlivro = item;
                                
                                objlivro.InserirLivro(ref objlivro);

                                livros = livros.OrderBy(livro => livro.Codigo).ToList();
                                break;
                            case "4": //Excluir livro
                                Console.Clear();
                                Console.WriteLine("Informe o Código para Excluir: ");
                                
                                codigo = Convert.ToInt32(Console.ReadLine());
                                
                                livros.RemoveAll(delegate (Livro f) { return f.Codigo == codigo; });
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

                            //Menu registrar empréstimo

                            case "1":
                                Emprestimo objemprestimo = new Emprestimo();

                                List<Aluno> listaAluno = new List<Aluno>();

                                Console.Clear();
                                ListarAlunos();
                                objemprestimo.InserirEmprestimo(ref objemprestimo);

                                Aluno objaluno = new Aluno();

                                Console.Write("Informe o código do aluno que deseja realizar um empréstimo: ");

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
                                Console.Clear();
                                //lista os emprestimos cadastrados
                                Console.WriteLine("Empréstimos:\n");
                                //listagem dos emprestimos (cabecalho)
                                tabela.Linha();
                                tabela.Cabecalho("Aluno", "Empréstimo Nº", "Data", "Devolução", "Observações");
                                tabela.Linha();
                                Int32 empNro = 0; Int32 empNroItem = 0;
                                foreach (Emprestimo emprestimo in emprestimos)
                                {
                                    tabela.Linha();
                                    empNro = emprestimo.Codigo;
                                    //listagem dos emprestimos (conteúdo)

                                    tabela.Cabecalho($"{emprestimo.AlunoResponsavel}", $"{emprestimo.Codigo}", $"{emprestimo.DataEmprestimo.Date}", $"{emprestimo.DataDevolucao.Date}", $"{emprestimo.Observacoes}");
                                    tabela.Linha();
                                    tabela.Cabecalho("Livro", "Titulo", "Autor");
                                    foreach (ItemEmprestimo itemDoEmprestimo in itensEmprestimo)
                                    {
                                        empNroItem = itemDoEmprestimo.EmprestimoCodigo;
                                        foreach (Livro livroEmprestado in itemDoEmprestimo.LivrosEmprestados)
                                        {
                                            if (empNroItem == empNro)
                                            {
                                                tabela.Cabecalho($"{livroEmprestado.Codigo}", $"{livroEmprestado.Titulo}", $"{livroEmprestado.Autor}");
                                                tabela.Linha();
                                            }
                                        }
                                    }
                                }
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

                        resposta = Console.ReadLine().ToUpper();

                        if (resposta == "S" || resposta == "Y")
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
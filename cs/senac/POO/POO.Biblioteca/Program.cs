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

            int larguraTabela = 97;

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
                                    InserirAluno(ref objaluno);

                                    Alunos.Add(objaluno);
                                    break;
                                case "2": //Listar alunos
                                    Console.Clear();
                                    Linha();
                                    Cabecalho("Código", "Nome", "Celular");
                                    Linha();
                                    foreach (Aluno alunos in Alunos)
                                    {
                                        Linha();
                                        Cabecalho($"{alunos.Codigo}", $"{alunos.Nome}", $"{alunos.Celular}");
                                    }
                                    Linha();
                                    Console.Write("Pressione qualquer tecla para continuar. . . ");

                                    Console.ReadKey();
                                    break;
                                case "3": //Alterar aluno
                                    Console.Clear();
                                    Console.Write("Insira o Código do Aluno que deseja Alterar: ");

                                    codigo = Convert.ToInt16(Console.ReadLine());

                                    var item = Alunos.First(aluno => aluno.Codigo == codigo);

                                    objaluno = item;

                                    InserirAluno(ref objaluno);
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

                        void InserirAluno(ref Aluno objaluno)
                        {
                            Console.WriteLine("Informe os dados:");
                            Console.Write("Código: ");

                            objaluno.Codigo = Convert.ToInt16(Console.ReadLine());

                            Console.Write("Nome: ");

                            objaluno.Nome = Console.ReadLine();

                            Console.Write("Nascimento: ");

                            objaluno.Nascimento = Convert.ToDateTime(Console.ReadLine());

                            Console.Write("Endereço: ");

                            objaluno.Endereco = Console.ReadLine();

                            Console.Write("Número: ");

                            objaluno.Numero = Console.ReadLine();

                            Console.Write("Celular: ");

                            objaluno.Celular = Console.ReadLine();
                        }
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
                                InserirAutor(ref objautor);
                                
                                Autores.Add(objautor);
                                break;
                            case "2": //Listar autores
                                Console.Clear();
                                Linha();
                                Cabecalho("Código", "Nome", "Email");
                                foreach (Autor autores in Autores)
                                {
                                    Linha();
                                    Cabecalho($"{autores.Codigo}", $"{autores.Nome}", $"{autores.Email}");
                                }
                                Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": //Alterar autor
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Autores.First(autor => autor.Codigo == codigo);
                                
                                objautor = item;
                                
                                InserirAutor(ref objautor);
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
                        void InserirAutor(ref Autor objautor)
                        {
                            Console.WriteLine("Informe os dados:");
                            Console.Write("Código: ");
                            
                            objautor.Codigo = Convert.ToInt16(Console.ReadLine());
                            
                            Console.Write("Nome: ");
                            
                            objautor.Nome = Console.ReadLine();
                            
                            Console.Write("Nascimento: ");
                            
                            objautor.Nascimento = Convert.ToDateTime(Console.ReadLine());
                            
                            Console.Write("E-mail: ");
                            
                            objautor.Email = Console.ReadLine();
                            
                            Console.Write("Origem: ");
                            
                            objautor.Origem = Console.ReadLine();
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
                                InserirEditora(ref objeditora);
                                
                                Editoras.Add(objeditora);
                                break;
                            case "2": //Listar editoras
                                Console.Clear();
                                Linha();
                                Cabecalho("Código", "Nome", "Email");
                                Linha();
                                foreach (Editora editoras in Editoras)
                                {
                                    Linha();
                                    Cabecalho($"{editoras.Codigo}", $"{editoras.Nome}", $"{editoras.Email}");
                                }
                                Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");

                                Console.ReadKey();
                                break;
                            case "3": //Alterar editora
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Editoras.First(editora => editora.Codigo == codigo);
                                
                                objeditora = new Editora();
                                
                                objeditora = item;
                                
                                InserirEditora(ref objeditora);
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

                        void InserirEditora(ref Editora objeditora)
                        {
                            Console.WriteLine("Informe os dados:");
                            Console.Write("Código: ");
                            
                            objeditora.Codigo = Convert.ToInt16(Console.ReadLine());
                            
                            Console.Write("Nome: ");
                            
                            objeditora.Nome = Console.ReadLine();
                            
                            Console.Write("E-mail: ");
                            
                            objeditora.Email = Console.ReadLine();
                            
                            Console.Write("Telefone: ");
                            
                            objeditora.Telefone = Console.ReadLine();
                            
                            Console.Write("Endereço: ");
                            
                            objeditora.Endereco = Console.ReadLine();
                            
                            Console.Write("Cidade: ");
                            
                            objeditora.Cidade = Console.ReadLine();
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
                                InserirLivro(ref objlivro);
                                
                                Livros.Add(objlivro);
                                break;
                            case "2": //Listar livros
                                Console.Clear();
                                Linha();
                                Cabecalho("Código", "Título", "Autor");
                                Linha();
                                foreach (Livro livros in Livros)
                                {
                                    Linha();
                                    Cabecalho($"{livros.Codigo}", $"{livros.Titulo}", $"{livros.Autor}");
                                }
                                Linha();
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
                                
                                Console.ReadKey();
                                break;
                            case "3": // Alterar livro
                                Console.Write("Insira o Código para Alterar: ");
                                
                                codigo = Convert.ToInt16(Console.ReadLine());
                                
                                var item = Livros.First(livro => livro.Codigo == codigo);
                                
                                objlivro = item;
                                
                                InserirLivro(ref objlivro);
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
                        void InserirLivro(ref Livro objlivro)
                        {
                            Console.WriteLine("Informe os dados:");
                            Console.Write("Código: ");
                            
                            objlivro.Codigo = Convert.ToInt16(Console.ReadLine());
                            
                            Console.Write("Título: ");
                            
                            objlivro.Titulo = Console.ReadLine();
                            
                            Console.Write("Autor: ");
                            
                            objlivro.Autor = Console.ReadLine();
                            
                            Console.Write("Editora: ");
                            
                            objlivro.Editora = Console.ReadLine();
                            
                            Console.Write("Genero: ");
                            
                            objlivro.Genero = Console.ReadLine();
                            
                            Console.Write("Seção: ");
                            
                            objlivro.Secao = Console.ReadLine();
                            
                            Console.Write("ISBN: ");
                            
                            objlivro.ISBN = Console.ReadLine();
                            
                            Console.Write("Lançamento: ");
                            
                            objlivro.Lancamento = Convert.ToDateTime(Console.ReadLine());
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
                                Cabecalho("Código", "Nome");
                                foreach (Aluno aluno in listaAluno)
                                {
                                    Console.WriteLine($"{aluno.Codigo}", $"{aluno.Nome}");
                                }
                                InserirEmprestimo(ref objemprestimo);
                                
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
                        void InserirEmprestimo(ref Emprestimo objemprestimo)
                        {
                            Console.WriteLine("Informe os dados");
                            Console.Write("Codigo: ");
                            
                            objemprestimo.Codigo = Convert.ToInt32(Console.ReadLine());
                            
                            Console.Write("Empréstimo: ");
                            
                            objemprestimo.DataEmprestimo = Convert.ToDateTime(Console.ReadLine());
                            
                            Console.Write("Devolução: ");
                            
                            objemprestimo.DataDevolucao = Convert.ToDateTime(Console.ReadLine());
                            
                            Console.Write("Observações: ");
                            
                            objemprestimo.Observacoes = Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Erro: a opção inserida não existe.");
                        break;
                }
                Console.Write("Pressione qualquer tecla para continuar. . . ");

                Console.ReadKey();
            }

            //Métodos da tabela//
            void Linha() //Inserir linha separadora
            {
                Console.WriteLine(new string('-', larguraTabela));
            }
            void Cabecalho(params string[] colunas) //Inserir uma linha com conteúdo
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
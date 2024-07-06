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
            List<Aluno> Alunos = new List<Aluno>(); //Armazenar em memória
            List<Autor> Autores = new List<Autor>(); //Armazena o autor
            List<Editora> Editoras = new List<Editora>();  //Editora 
            List<Livro> Livros= new List<Livro>();  //Livro

            while(resposta != "9")
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção.");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Autor");
                Console.WriteLine("3 - Editora");
                Console.WriteLine("4 - Livro");
                Console.WriteLine("5 - Emprestimo\n");
                Console.Write(">> ");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                            Console.Clear();
                            Console.WriteLine("1 - Cadastrar");
                            Console.WriteLine("2 - Listar");
                            Console.WriteLine("3 - Alterar");
                            Console.WriteLine("4 - Excluir");
                            resposta = Console.ReadLine();
                        switch (resposta)
                        {
                            case "1":
                                Aluno objaluno = new Aluno();
                                Console.Clear();
                                InserirAluno(ref objaluno);
                                Alunos.Add(objaluno);
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Código \tNome \t\tCeluar");
                                foreach (Aluno alunos in Alunos)
                                {
                                    Console.WriteLine(alunos.Codigo + "\t" + alunos.Nome + "\t\t" + alunos.Celular);
                                }
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Clear();
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                codigo = Convert.ToInt16(Console.ReadLine());
                                var item = Alunos.First(aluno => aluno.Codigo == codigo);
                                objaluno = item;
                                InserirAluno(ref objaluno);
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                Alunos.RemoveAll(delegate (Aluno f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.Write("Erro: a opção inserida não existe.");
                                break;
                        }

                        void InserirAluno(ref Aluno objaluno)
                        {
                            Console.WriteLine("Informe os dados:");
                            Console.Write("Código: ");
                            objaluno.Codigo = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Nome: ");
                            objaluno.Nome = Console.ReadLine();
                            Console.Write("Nascimento: ");
                            objaluno.Nascimento = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Endereco: ");
                            objaluno.Endereco = Console.ReadLine();
                            Console.Write("Número: ");
                            objaluno.Numero = Console.ReadLine();
                            Console.Write("Celular: ");
                            objaluno.Celular = Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                Autor objautor = new Autor();
                                Console.Clear();
                                InserirAutor(ref objautor);
                                Autores.Add(objautor);
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Código \tNome \t\tEmail");
                                foreach (Autor autores in Autores)
                                {
                                    Console.WriteLine(autores.Codigo + "\t" + autores.Nome + "\t\t" + autores.Email);
                                }
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                codigo = Convert.ToInt16(Console.ReadLine());
                                var item = Autores.First(autor => autor.Codigo == codigo);
                                objautor = item;
                                InserirAutor(ref objautor);
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                Autores.RemoveAll(delegate (Autor f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.Write("Erro: a opção inserida não existe.");
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
                    case "3":
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                Editora objeditora = new Editora();
                                Console.Clear();
                                InserirEditora(ref objeditora);
                                Editoras.Add(objeditora);
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Código \tNome \t\tEmail");
                                foreach (Editora editoras in Editoras)
                                {
                                    Console.WriteLine(editoras.Codigo + "\t" + editoras.Nome + "\t\t" + editoras.Email);
                                }
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Write("Insira o Código do Aluno que deseja Alterar: ");
                                codigo = Convert.ToInt16(Console.ReadLine());
                                var item = Editoras.First(editora => editora.Codigo == codigo);
                                objeditora = new Editora();
                                objeditora = item;
                                InserirEditora(ref objeditora);
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Informe o código para excluir: ");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                Editoras.RemoveAll(delegate (Editora f) { return f.Codigo == codigo; });
                                break;
                            default:
                                Console.Write("Pressione qualquer tecla para continuar. . . ");
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
                    case "4":
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                Livro objlivro = new Livro();
                                Console.Clear();
                                InserirLivro(ref objlivro);
                                Livros.Add(objlivro);
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Código \tTítulo \t\tAutor");
                                foreach (Livro livros in Livros)
                                {
                                    Console.WriteLine(livros.Codigo + "\t" + livros.Titulo + "\t\t" + livros.Autor);
                                }
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Write("Insira o Código para Alterar: ");
                                codigo = Convert.ToInt16(Console.ReadLine());
                                var item = Livros.First(livro => livro.Codigo == codigo);
                                objlivro = item;
                                InserirLivro(ref objlivro);
                                break;
                            case "4":
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
                    case "5":
                        Console.Clear();
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Excluir");
                        resposta = Console.ReadLine();

                        switch (resposta)
                        {
                            case "1":
                                Emprestimo objemprestimo = new Emprestimo();
                                List<Aluno> listaAluno = new List<Aluno>();
                                Console.Clear();
                                foreach (Aluno aluno in listaAluno)
                                {
                                    Console.WriteLine($"{aluno.Codigo}\t{aluno.Nome}");
                                }
                                InserirEmprestimo(ref objemprestimo);
                                Aluno objaluno = new Aluno();
                                Console.Write("Informar o código do aluno: ");
                                objaluno.Codigo = Convert.ToInt32(Console.ReadLine());


                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            default:
                                Console.Write("Erro: a opção inserida não existe.");
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
                        Console.Write("Erro: a opção inserida não existe.");
                        break;
                }
                Console.Write("\n\nPressione qualquer tecla para continuar ou ESC para voltar. . . ");
                ConsoleKeyInfo voltarOuContinuar = Console.ReadKey();
                if (voltarOuContinuar.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
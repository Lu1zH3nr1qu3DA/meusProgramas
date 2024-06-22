namespace CadastroAlunosVetorRAM8
{
    internal class Program
    {
        static int nAlunos = 255;
        static string[] aluno = new string[nAlunos];
        static string[] email = new string[nAlunos];
        static string[] cidade = new string[nAlunos];
        static int[] cep = new int[nAlunos];
        static long[] cpf = new long[nAlunos];
        static int[] idade = new int[nAlunos];
        static int posUltimoAluno = 0;
        static int posInserirAluno = 0;
        static string resposta = "";

        static void Inserir()
        {
            Console.Clear();
            Console.Write($"\nInsira o nome do {posInserirAluno + 1}º Aluno: ");
            aluno[posInserirAluno] = Console.ReadLine()!;
            Console.Write($"Insira o email de {aluno[posInserirAluno]}: ");
            email[posInserirAluno] = Console.ReadLine()!;
            Console.Write($"Insira a idade de {aluno[posInserirAluno]}: ");
            idade[posInserirAluno] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Insira o CEP de {aluno[posInserirAluno]} (sem traço): ");
            cep[posInserirAluno] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Insira a cidade de {aluno[posInserirAluno]}: ");
            cidade[posInserirAluno] = Console.ReadLine()!;
            Console.Write($"Insira o CPF de {aluno[posInserirAluno]} (apenas números): ");
            cpf[posInserirAluno] = Convert.ToInt64(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            while (resposta != "5")
            {
                Console.Clear();
                Console.WriteLine(".......Cadastro de Alunos (CRUD).......");  //          CRUD: Create, Read, Update and Delete)
                Console.WriteLine("............Menu de Opções.............\n");
                Console.WriteLine("Digite uma opção.");
                Console.WriteLine("\n(1) - Listar Alunos\n");
                Console.WriteLine("(2) - Cadastrar um Aluno\n");
                Console.WriteLine("(3) - Alterar um Aluno\n");
                Console.WriteLine("(4) - Excluir um Aluno\n");
                Console.WriteLine("(5) - Sair\n");
                
                resposta = Console.ReadLine()!;

                switch (resposta)
                {
                    case "1":
                        if (aluno[0] == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum aluno foi inserido.");
                        }
                        else
                        {
                            Console.Clear();
                            for (int xnome = 0; xnome < posUltimoAluno; xnome++)
                            {
                                if (aluno[xnome] == null) { }
                                else
                                {
                                    Console.WriteLine($"Aluno nº{xnome + 1}:");
                                    Console.WriteLine($"Nome   - {aluno[xnome]}");
                                    Console.WriteLine($"Email  - {email[xnome]}");
                                    Console.WriteLine($"Idade  - {idade[xnome]}");
                                    Console.WriteLine($"CEP    - {cep[xnome]}");
                                    Console.WriteLine($"Cidade - {cidade[xnome]}");
                                    Console.WriteLine($"CPF    - {cpf[xnome]}");
                                    Console.WriteLine($"\n................................\n");
                                }
                            }
                        }
                        break;
                    case "2": 
                        Inserir();
                        posInserirAluno++;
                        posUltimoAluno++;
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Insira o número do aluno que deseja Alterar: ");
                        resposta = Console.ReadLine()!;
                        int alterar = Convert.ToInt32(resposta) - 1;
                        posInserirAluno = alterar;
                        Inserir();
                        posInserirAluno = posUltimoAluno;
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Insira o número do aluno que quer Excluir: ");
                        resposta = Console.ReadLine()!;
                        int excluir = Convert.ToInt32(resposta) - 1;
                        aluno[excluir] = null!;
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Erro: A opção inserida não existe.");
                        break;
                }
                Console.Write("\n\n\nPressione qualquer tecla para continuar. . . ");
                Console.ReadKey();
            }
        }
    }
}
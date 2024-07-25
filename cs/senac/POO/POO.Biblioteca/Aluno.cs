using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Celular { get; set; }

        public void InserirDados(ref Aluno objaluno)
        {
            Console.WriteLine("Informe os dados.\n");
            Console.Write("Código: ");

            string dado = Console.ReadLine();

            objaluno.Codigo = (dado == "") ? objaluno.Codigo : Convert.ToInt16(dado);

            Console.Write("Nome: ");

            dado = Console.ReadLine();

            objaluno.Nome = (dado == "") ? objaluno.Nome : dado;

            Console.Write("Data de Nascimento: ");

            dado = Console.ReadLine();

            objaluno.Nascimento = (dado == "") ? objaluno.Nascimento : Convert.ToDateTime(dado);

            Console.Write("Endereço: ");

            dado = Console.ReadLine();

            objaluno.Endereco = (dado == "") ? objaluno.Endereco : dado;

            Console.Write("Número: ");

            dado = Console.ReadLine();

            objaluno.Numero = (dado == "") ? objaluno.Numero : dado;

            Console.Write("Celular: ");

            dado = Console.ReadLine();

            objaluno.Celular = (dado == "") ? objaluno.Celular : dado;
        }
    }
}

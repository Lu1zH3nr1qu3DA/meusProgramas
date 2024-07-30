using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Emprestimo
    {
        public int Codigo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Observacoes { get; set; }

        public Aluno AlunoResponsavel { get; set; }

        public void InserirEmprestimo(ref Emprestimo objemprestimo)
        {
            Console.WriteLine("Informe os dados");
            Console.Write("Codigo: ");

            objemprestimo.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Data do Empréstimo: ");

            objemprestimo.DataEmprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Data da Devolução: ");

            objemprestimo.DataDevolucao = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Observações: ");

            objemprestimo.Observacoes = Console.ReadLine();
        }
    }
}
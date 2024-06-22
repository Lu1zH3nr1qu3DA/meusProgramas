using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CpfCnpj { get; set; }

        public void CalculaDias()
        {
            Console.WriteLine($"Dias vividos: {DateTime.Now.Subtract(this.Nascimento).Days}");
        }
    }
}

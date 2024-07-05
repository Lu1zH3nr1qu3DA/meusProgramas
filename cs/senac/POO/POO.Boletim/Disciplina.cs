using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOBoletim
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public int Faltas { get; set; }
        public double Media { get; set; }
        public string Situacao { get; set; }

        public void CalcSituacao()
        {
            this.Media = (this.Nota1 + this.Nota2) / 2;

            if (this.Faltas > 12 || this.Media < 7)
            {
                this.Situacao = "Reprovado";
            }
            else
            {
                this.Situacao = "Aprovado";
            }
        }
    }
}
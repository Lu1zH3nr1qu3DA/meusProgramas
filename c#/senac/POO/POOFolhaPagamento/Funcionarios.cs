using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFolhaPagamento
{
    internal class Funcionarios
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double ValInss { get; set; }
        public double ValIR { get; set; }
        public double ValorLiquido { get; set; }

        public void Inss() 
        {
            if (this.Salario <= 1412)
            {
                ValInss = Salario * (7.5 / 100);
            }
            else
            {
                if (this.Salario <= 2666.68)
                {
                    ValInss = Salario * (9 / 100);
                }
                else
                {
                    if (this.Salario <= 4000.03)
                    {
                        ValInss = Salario * (12 / 100);
                    }
                    else
                    {
                        if (this.Salario <= 7786.02)
                        {
                            ValInss = Salario * (14 / 100);
                        }
                    }
                }
            }
        }

        public void IR()
        {
            if (this.Salario <= 1412)
            {
                ValIR = Salario * (7.5 / 100);
            }
            else
            {
                if (this.Salario <= 2666.68)
                {
                    ValIR = Salario * (15 / 100);
                }
                else
                {
                    if (this.Salario <= 4000.03)
                    {
                        ValIR = Salario * (22.5 / 100);
                    }
                    else
                    {
                        if (this.Salario <= 7786.02)
                        {
                            ValIR = Salario * (27.5 / 100);
                        }
                    }
                }
            }
        }
    }
}
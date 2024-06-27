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
        public double ValLiquido { get; set; }

        public void Inss() 
        {
            if (this.Salario <= 1412)
            {
                this.ValInss = Salario * (7.5 / 100);
            }
            else
            {
                if (1412 < this.Salario && this.Salario <= 2666.68)
                {
                    this.ValInss = Salario * (9 / 100);
                }
                else
                {
                    if (2666.68 < this.Salario && this.Salario <= 4000.03)
                    {
                        this.ValInss = Salario * (12 / 100);
                    }
                    else
                    {
                        if (4000.03 < this.Salario && this.Salario <= 7786.02)
                        {
                            this.ValInss = Salario * (14 / 100);
                        }
                    }
                }
            }
        }

        public void IR()
        {
            if (this.Salario <= 1412)
            {
                this.ValIR = Salario * (7.5 / 100);
            }
            else
            {
                if (this.Salario <= 2666.68)
                {
                    this.ValIR = Salario * (15 / 100);
                }
                else
                {
                    if (this.Salario <= 4000.03)
                    {
                        this.ValIR = Salario * (22.5 / 100);
                    }
                    else
                    {
                        if (this.Salario <= 7786.02)
                        {
                            this.ValIR = Salario * (27.5 / 100);
                        }
                    }
                }
            }
        }

        public void VLiquido()
        {
            this.ValLiquido = this.Salario - this.ValInss - this.ValIR;
        }
    }
}
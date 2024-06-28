using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOFolhaPagamento
{
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double ValInss { get; set; }
        public double ValIR { get; set; }
        public double ValLiquido { get; set; }

        public void Inss()
        {

            if (this.Salario <= 1412.00)
            {
                this.ValInss = this.Salario * (7.50 / 100.00);
            }
            else
            {
                if (this.Salario <= 2666.68)
                {
                    this.ValInss = this.Salario * (9.00 / 100.00) - 21.18;
                }
                else
                {
                    if (this.Salario <= 4000.03)
                    {
                        this.ValInss = this.Salario * (12.00 / 100.00) - 101.18;
                    }
                    else
                    {
                        if (this.Salario <= 7786.02)
                        {
                            this.ValInss = this.Salario * (14.00 / 100.00) - 181.18;
                        }
                        else
                        {
                            if (this.Salario > 7786.02)
                            {
                                this.ValInss = 908.85;
                            }
                        }
                    }
                }
            }
        }

        public void IR()
        {
            if (this.Salario > 2259.20 && this.Salario <= 2826.65)
            {
                this.ValIR = this.Salario * (7.50 / 100.00) - 169.44;
            }
            else
            {
                if (this.Salario > 2826.65 && this.Salario <= 3751.05)
                {
                    this.ValIR = this.Salario * (15.00 / 100.00) - 381.44;
                }
                else
                {
                    if (this.Salario > 3751.05 && this.Salario <= 4664.68)
                    {
                        this.ValIR = this.Salario * (22.50 / 100.00) - 662.77;
                    }
                    else
                    {
                        if (this.Salario > 4664.68)
                        {
                            this.ValIR = this.Salario * (27.50 / 100.00) - 896.00;
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
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AtriburID()
        {
            this.Id = 1;
        }
        public void Inss()
        {
            if (this.Salario <= 1412)
            {
                this.ValInss = this.Salario * (7.5 / 100);
            }
            else
            {
                if (this.Salario <= 2666.68)
                {
                    this.ValInss = (this.Salario * (9 / 100) - 21.18);
                }
                else
                {
                    if (this.Salario <= 4000.03)
                    {
                        this.ValInss = (this.Salario * (12 / 100) - 101.18);
                    }
                    else
                    {
                        if (this.Salario <= 7786.02)
                        {
                            this.ValInss = (this.Salario * (14 / 100) - 181.18);
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
            if (this.Salario <= 1412)
            {
                this.ValIR = this.Salario * (7.5 / 100);
            }
            else
            {
                if (this.Salario > 1412 && this.Salario <= 2666.68)
                {
                    this.ValIR = this.Salario * (15 / 100);
                }
                else
                {
                    if (this.Salario > 2666.68 && this.Salario <= 4000.03)
                    {
                        this.ValIR = this.Salario * (22.5 / 100);
                    }
                    else
                    {
                        if (this.Salario > 4000.03)
                        {
                            this.ValIR = this.Salario * (27.5 / 100);
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
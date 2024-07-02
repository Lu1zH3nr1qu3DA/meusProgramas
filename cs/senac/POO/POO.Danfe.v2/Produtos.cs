using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO.Danfe
{
    public class Produtos
    {
        public int Item { get; set; }
        public string Nome { get; set; }
        public double ValUnitario { get; set; }
        public int Quantidade { get; set; }
        public double TotalUnitario { get; set; }

        public void CalcTotalUnitario()
        {
            this.TotalUnitario = this.Quantidade * this.ValUnitario;
        }
    }
}
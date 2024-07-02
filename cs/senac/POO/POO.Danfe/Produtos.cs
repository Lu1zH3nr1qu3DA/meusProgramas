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
        public double Subtotal { get; set; }
        public double Total { get; set; }

        public void CalcSubtotal()
        {
            this.Subtotal = this.Quantidade * this.ValUnitario;
        }

        public void CalcTotal()
        {
            
        }
    }
}
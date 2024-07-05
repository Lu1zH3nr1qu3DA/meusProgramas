using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObiblioteca
{
    public class Livro
    {
        public int Codigo { get; set; }
        public string Titulo { get; set;}
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public string Secao { get; set; }
        public string ISBN { get; set; }
        public DateTime Lancamento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaconsole
{
    internal class Tabela
    {
        public int larguraTabela = 97;
        public void Linha() //Inserir linha separadora
        {
            Console.WriteLine(new string('-', larguraTabela));
        }
        public void Cabecalho(params string[] colunas) //Inserir uma linha com conteúdo
        {
            int largura = (larguraTabela - colunas.Length) / colunas.Length;

            string row = "|";

            foreach (string coluna in colunas)
            {
                row += Centralizar(coluna, largura) + "|";
            }

            Console.WriteLine(row);
        }
        public string Centralizar(string texto, int largura)
        {
            texto = texto.Length > largura ? texto.Substring(0, largura - 3) + "..." : texto;

            if (string.IsNullOrEmpty(texto))
            {
                return new string(' ', largura);
            }
            else
            {
                return texto.PadRight(largura - (largura - texto.Length) / 2).PadLeft(largura);
            }
        }
    }
}
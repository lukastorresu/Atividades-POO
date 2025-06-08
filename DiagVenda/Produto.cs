using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
    }
}
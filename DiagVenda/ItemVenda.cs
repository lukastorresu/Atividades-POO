using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class ItemVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco => Produto.Preco;
        public double Subtotal => Quantidade >= 50 ? (Preco * Quantidade * 0.8) : (Preco * Quantidade);
    }
}
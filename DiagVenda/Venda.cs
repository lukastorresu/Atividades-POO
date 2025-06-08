using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public double Total => CalcularTotal();
        public Pagamento Pagamento { get; set; }

        private double CalcularTotal()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.Subtotal;
            }
            return total;
        }
    }
}
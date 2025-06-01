using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoPedido
{
    public class Pedido
    {
        private int numeroPedido;
        private List<(string Item, decimal Preco)> itens;
        private decimal valorTotal;

        public int NumeroPedido
        {
            get { return numeroPedido; }
            set
            {
                if (value > 0)
                {
                    numeroPedido = value;
                }
                else
                {
                    Console.WriteLine("Número do pedido deve ser positivo");
                }
            }
        }

        public decimal ValorTotal
        {
            get { return valorTotal; }
            private set { valorTotal = value; }
        }

        public Pedido(int numeroPedido)
        {
            itens = new List<(string, decimal)>();
            ValorTotal = 0;
            NumeroPedido = numeroPedido;
        }

        public void AdicionarItem(string item, decimal preco)
        {
            if (!string.IsNullOrWhiteSpace(item) && preco > 0)
            {
                itens.Add((item, preco));
                ValorTotal += preco;
            }
            else
            {
                Console.WriteLine("Item não adicionado: nome vazio ou preço inválido");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Pedido Nº: {NumeroPedido}");
            Console.WriteLine("Itens do pedido:");
            
            foreach (var item in itens)
            {
                Console.WriteLine($"- {item.Item}: R${item.Preco:F2}");
            }
            
            Console.WriteLine($"Total do pedido: R${ValorTotal:F2}");
            Console.WriteLine();
        }
    }
}

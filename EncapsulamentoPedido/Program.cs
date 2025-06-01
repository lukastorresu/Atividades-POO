using EncapsulamentoPedido;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Pedido p1 = new Pedido(1001);
        p1.AdicionarItem("Notebook Dell", 4500.00m);
        p1.AdicionarItem("Mouse sem fio", 120.50m);
        p1.AdicionarItem("Mochila para notebook", 199.90m);
        
        Pedido p2 = new Pedido(1002);
        p2.AdicionarItem("Teclado mecânico", 350.00m);
        p2.AdicionarItem("Monitor 24\"", 899.00m);
        p2.AdicionarItem("Suporte para monitor", 150.00m);
        
        Console.WriteLine("Detalhes dos Pedidos:");
        p1.ExibirDetalhes();
        p2.ExibirDetalhes();
    }
}
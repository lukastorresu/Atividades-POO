using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSP;

class Program
{
    static void RealizarSaque(IConta conta, decimal valor)
    {
        Console.WriteLine("Saldo Atual: " + conta.GetSaldo());
        conta.Sacar(valor);
        Console.WriteLine("Novo saldo: " + conta.GetSaldo() + "\n");
    }

    static void Main(string[] args)
    {
        ContaCorrente contaCorrente = new ContaCorrente(1000);
        Console.WriteLine("========Conta Corrente========");
        RealizarSaque(contaCorrente, 200); // vai sobrar 800
        RealizarSaque(contaCorrente, 900); // vai tentar sacar mais doq tem, vai dar insuficiente

        ContaPoupanca contaPoupanca = new ContaPoupanca(500);
        Console.WriteLine("========Conta Poupança=======");
        RealizarSaque(contaPoupanca, 100); // vai sobrar 400
        RealizarSaque(contaPoupanca, 500); // vai tentar sacar mais doq tem, vai dar insuficiente
    }
}
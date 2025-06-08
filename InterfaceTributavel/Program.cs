using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceTributavel;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente();
        cc.Saldo = 1000.00;

        SeguroVida sv = new SeguroVida();

        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

        Console.WriteLine($"Tributo Conta Corrente: R$ {cc.CalculaTributos():c}");
        Console.WriteLine($"Tributo Seguro de Vida: R$ {sv.CalculaTributos():c}");

        totalizador.Acumula(cc);
        totalizador.Acumula(sv);

        Console.WriteLine($"Total de tributos: R$ {totalizador.Total:c}");

        ContaCorrente cc2 = new ContaCorrente();
        cc2.Saldo = 5000.00;
        totalizador.Acumula(cc2);
        Console.WriteLine($"Novo total após segunda conta: R$ {totalizador.Total:c}");
    }
}
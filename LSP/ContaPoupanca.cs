using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
    public class ContaPoupanca : IConta
    {
        protected decimal saldo;

        public ContaPoupanca(decimal saldo)
        {
            this.saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Console.WriteLine("Tem saldo.");
                saldo -= valor;
            }
        }

        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
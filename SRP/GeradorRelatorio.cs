using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP
{
    public class GeradorRelatorio
    {
        public string GerarRelatorio(Conta conta)
        {
            return $"Titular: {conta.Titular} (Saldo: {conta.Saldo:C})\n";
        }
    }
}
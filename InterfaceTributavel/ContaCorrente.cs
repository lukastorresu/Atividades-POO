using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributos();
        }
    }
}
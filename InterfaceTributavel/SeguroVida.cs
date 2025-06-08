using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 75.00;
        }
    }
}
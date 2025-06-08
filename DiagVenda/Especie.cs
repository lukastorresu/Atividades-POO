using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco => Quantia - Total;
    }
}
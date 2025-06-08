using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public abstract class Pagamento
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }
    }
}
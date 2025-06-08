using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }
    }
}
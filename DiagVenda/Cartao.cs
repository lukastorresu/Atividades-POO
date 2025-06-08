using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagVenda
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }
    }
}
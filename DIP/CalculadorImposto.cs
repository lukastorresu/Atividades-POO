using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class CalculadorDeImposto
    {
        public decimal Para(NotaFiscal nf)
        {
            decimal imposto = nf.Valor * 0.10m;
            Console.WriteLine($"Calculado imposto de R$ {imposto} para nota fiscal de {nf.Destinatario}.");
            return imposto;
        }
    }
}
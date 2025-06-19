using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public interface ILeiDeEntrega
    {
        bool DeveEntregarUrgente(NotaFiscal nf);
    }
}
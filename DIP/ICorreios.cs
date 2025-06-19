using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public interface ICorreios
    {
        void EnviaPorSedex10(NotaFiscal nf);
        void EnviaPorSedexComum(NotaFiscal nf);
    }
}
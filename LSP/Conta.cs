using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
    public interface IConta
    {
        void Sacar(decimal valor);
        decimal GetSaldo();
    }
}
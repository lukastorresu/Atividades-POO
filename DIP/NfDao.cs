using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class NFDao
    {
        public void Persiste(NotaFiscal nf)
        {
            Console.WriteLine($"Armazenando nota fiscal para {nf.Destinatario} no banco de dados.");
        }
    }
}
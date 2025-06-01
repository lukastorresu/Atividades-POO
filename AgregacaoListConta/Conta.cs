using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoListConta
{
    public class Conta
    {
        public int Numero { get; set; }
        //A agregação acontecerá aqui
        public List<Cliente> VetTitulares { get; set; } //= new List<Cliente>();
        public double Saldo { get; set; }
        public void ExibirDetalhes(){
            Console.WriteLine($"Número  {Numero}  Saldo {Saldo:c}");
            foreach (Cliente c in VetTitulares)
                c.ExibirDetalhes();
        }
    }
}
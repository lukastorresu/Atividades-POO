using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao {get; set;}
        //objetoProduto.codigo, .nome, . preco
        public void CalcularComissao(double preco)
        {
            Comissao += preco * 2 / 100;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão {Comissao:c}");
        }
    }
}
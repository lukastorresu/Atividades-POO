using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Vendedor Vend { get; set; }
        public Comprador Comp { get; set; }
        public List<Produto> VetProduto { get; set; }
        public void AdicionarProduto(Produto objetoProduto)
        {
            VetProduto.Add(objetoProduto);
            Vend.CalcularComissao(objetoProduto.Preco);//double
            Comp.DescontarDaVerba(objetoProduto.Preco);            
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Vendedor comissão:");
            Vend.MostrarAtributos();
            Console.WriteLine("Comprador verba: ");
            Comp.MostrarAtributos();
            foreach(Produto p in VetProduto)
                p.MostrarAtributos();//Classe Produto
        }
    }
}
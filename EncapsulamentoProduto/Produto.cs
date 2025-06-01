using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto//pasta-using
{
    public class Produto
    {
        private int codigo;//atributo
        private string nome;//atributo
        private double preco;//atributo
        public int Codigo //propriedade Codigo
        {
            get { return codigo; }
            set { 
                if (value > 0)
                    codigo = value;
                else
                    Console.WriteLine("Código inválido!"); 
            }
        }
        public string Nome //propriedade Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        public double Preco //propriedade Produto
        {
            get { return preco; }
            set { preco = value; }
        }        
    }//class
}//namespace
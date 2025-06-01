using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        //estabelecendo a composição
        //essa é classe que tem o losango/diamante
        //a NotaFiscal é composta por ItemNotaFiscal
        public List<ItemNotaFiscal> VetItemNf { get; set; }
        public NotaFiscal(int numeroNf, string data)
        {// aqui é a representação da composição
            //
            NumeroNf = numeroNf;
            Data = data;
            VetItemNf = new List<ItemNotaFiscal>();
        }
        public void AdiconarItens(ItemNotaFiscal item)
        {
            VetItemNf.Add(item);
        }
        public void Mostrar()
        {
            Console.WriteLine("Número da Nota Fiscal:" + NumeroNf);
            Console.WriteLine("Data da compra: "+ Data);
            // var == ItemNotaFiscal
            foreach (var item in VetItemNf)
            {
                Console.WriteLine("Qtde: "+item.Qtde);   
            }
        }
        ~NotaFiscal()//destrutor
        {
            VetItemNf = null;
            Console.WriteLine("Destrutor Nota Fiscal");
        }
    }
}
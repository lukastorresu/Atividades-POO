using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente 
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }  
        public override void Mostrar()//polimorfismo
        {
            base.Mostrar();//apresentando Código e Nome
            Console.WriteLine("Cnpj: " + Cnpj);
        }  
        public override void Cadastrar(int codigo, string nome, int documento)
        {
            Codigo = codigo;
            Nome = nome;
            Cnpj = documento;
        }
        public override void VerificaIdade()
        {//polimorfismo
            if (Idade >= 40)
                Console.WriteLine("Cliente Jurídico");   
        }

    }
}
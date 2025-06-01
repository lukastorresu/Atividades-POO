using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }  
        public override void Mostrar()//polimorfismo
        {
            base.Mostrar();//apresentando Código e Nome
            Console.WriteLine("Rg: " + Rg);
        } 

        public override void Cadastrar(int codigo, string nome, int documento)
        {
            Codigo = codigo;
            Nome = nome;
            Rg = documento;
        }
        public override void VerificaIdade()
        {
            if (Idade > 0 && Idade < 40)
                Console.WriteLine("Cliente Físico");   
        }
    }
}
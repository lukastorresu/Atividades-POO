using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Mostrar()//polimorfismo
        { // método concreto
            Console.WriteLine("Código: " + Codigo + "\nNome: " + Nome);
        }
        public abstract void Cadastrar(int codigo, string nome, int documento);//documento representará
        //o rg ou o cnpj
        public abstract void VerificaIdade();
    }
}
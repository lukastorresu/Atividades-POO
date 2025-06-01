using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; } //Propriedade
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public bool Situacao { get; set; }
        public static int Contador { get; set; }
        public Conta() // new Conta();
        {//construtor padrão   
            Contador ++;         
        }
        public Conta(int numero){ //new Conta(11);
            //Propriedade/atributo    =   parâmetro
            Numero = numero;
            Contador ++;
        }
        public Conta(int numero, string nome){ //new Conta(11);
            //Propriedade/atributo    =   parâmetro
            Numero = numero;
            Titular = nome;
            Contador ++;
        }

        public void ExibirDetalhes(){
            Console.WriteLine($"Número  {Numero}  Titular {Titular} Saldo {Saldo:c} Situação {Situacao}");
        }
    }
}
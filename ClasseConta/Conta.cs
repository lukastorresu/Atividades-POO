using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos/funções
        public void Sacar(double valorSaque)
        {
            this.saldo = this.saldo - valorSaque;
            //saldo = saldo - valorSaque;
            //saldo -= valorSaque
        }
        public void Depositar(double valorDeposito)//parâmetro
        {
            saldo += valorDeposito;
        }  
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + this.numero +
                        "\tTitular: " + this.titular +
                        "\tSaldo: " + this.saldo);
        } 
        public void Transferir(double valorTransferencia,
                               Conta objetoDestino )
        {
            saldo = saldo - valorTransferencia;//eu
            objetoDestino.saldo = objetoDestino.saldo 
                               + valorTransferencia;//Eliana
        }     
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoVeiculo
{
    public class Veiculo
    {
        //marca, ano, modelo, quilometragem
        private int ano;
        public int Ano
        {
            get { return ano; }
            set { 
                if (value >= 1900 && ano <=  DateTime.Now.Year) 
                    ano = value; 
                else
                    Console.WriteLine("Ano inválido!");
            }
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        
        public double Quilometragem { get; set; }
        
    }
}
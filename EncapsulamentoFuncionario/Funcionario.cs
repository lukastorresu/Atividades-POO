using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaração de atributos encapsulados
        private int codigo;
        private string nome;
        private double salario;
        //delaração de métodos de encapsulamento
        public int Codigo{
            set {
                this.codigo = value; 
            }
            get{
                return this.codigo;
            }
        }
        public string Nome{
            set {
                this.nome = value; 
            }
            get{
                return this.nome;
            }
        }
        public double Salario {//criou a propriedade
            set {
                this.salario = value; // 1000
            }
            get{
                return this.salario;
            }
        }



        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
                            "\tNome: " + Nome +
                            "\tSalário: " + Salario);
        }
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
    }
}
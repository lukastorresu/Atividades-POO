using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;
        //delaração de métodos
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo +
                            "\tNome: " + nome +
                            "\tSalário: " + salario);
        }
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
    }
}
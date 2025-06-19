using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
   }
}
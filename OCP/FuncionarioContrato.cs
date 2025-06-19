using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class FuncionarioContrato : ICalculadoraSalarios
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            return funcionario.Salario;
        }
    }
}
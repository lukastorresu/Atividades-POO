using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP;

class Program
{
    static void Main()
    {
        var funcionario1 = new Funcionario("Lucas", 5000);
        var funcionario2 = new Funcionario("Nathalia", 4000);
        
        ICalculadoraSalarios calculadoraPermanente = new FuncionarioPermanente();
        ICalculadoraSalarios calculadoraContrato = new FuncionarioContrato();
        
        Console.WriteLine($"Salário de {funcionario1.Nome} (Permanente): {calculadoraPermanente.CalcularSalario(funcionario1)}");
        Console.WriteLine($"Salário de {funcionario1.Nome} (Contrato): {calculadoraContrato.CalcularSalario(funcionario1)}");
        Console.WriteLine($"Salário de {funcionario2.Nome} (Permanente): {calculadoraPermanente.CalcularSalario(funcionario2)}");
        Console.WriteLine($"Salário de {funcionario2.Nome} (Contrato): {calculadoraContrato.CalcularSalario(funcionario2)}");
    }
}
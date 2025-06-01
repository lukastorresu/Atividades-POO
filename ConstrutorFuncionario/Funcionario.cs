using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //declaração de atributo de forma 
        //ímplicita, por conta do encapsulamento
        //compacto-propriedade
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public static int Contador { get; private set; }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Matrícula {Matricula} \tNome {Nome} \tSalário {Salario:c}");
        }
        public Funcionario() //construtor padrão
        {           
            Contador ++; 
        }
        public Funcionario(int matricula)
        {
            Matricula = matricula;
            Contador ++; 
        }
        public Funcionario(int matricula, string nome, decimal salario)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            Contador ++; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> Dependentes { get; set; } = new List<Dependente>();
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void MostrarAtributos()
        {// método concreto
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário: {Salario:c}");
        }
        public int CalcularTotalDependente()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependentesMaioridade(int codigo)
        {
            Dependente? d = Dependentes.FirstOrDefault(d => d.Codigo == codigo);
            if (d != null && d.VerificarMaioridade())
            {
                Dependentes.Remove(d);
                Console.WriteLine($"\nDependente {d.Nome} foi removido.");
            }
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"\nDependentes de {Nome}:");
            foreach (var d in Dependentes)
            {
                Console.WriteLine(d);
            }
        }
    }
}
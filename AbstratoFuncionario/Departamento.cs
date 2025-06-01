using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }
        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                    Console.WriteLine("\nExclusão realizada com sucesso!");
                }
            }
        }
        public void ListarFuncionarios()
        {
            Console.WriteLine("\nDepartamento: " + Nome);
            foreach (var f in VetF)
            {
                f.MostrarAtributos();
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
            public void MostrarQtdeDependentesFuncionario()
        {
            foreach (Funcionario f in VetF)
            {
                Console.WriteLine($"\nO funcionário {f.Nome} tem {f.CalcularTotalDependente()} dependente(s).");
            }
        }
    }
}
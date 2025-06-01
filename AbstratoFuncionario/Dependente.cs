using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool VerificarMaioridade()
        {
            return Idade >= 18;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} \tNome: {Nome} \tIdade: {Idade}";
        }
    }
}
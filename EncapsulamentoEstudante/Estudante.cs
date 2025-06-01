using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string nome = "Sem nome";
        private double nota = 0;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
            }
        }
        public double Nota
        {
            get { return nota; }
            set
            {
                if (value < 0)
                {
                    nota = 0;
                }
                else if (value > 10)
                {
                    nota = 10;
                }
                else
                {
                    nota = value;
                }
            }
        }
        public Estudante(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }
        public bool EstaAprovado()
        {
            return Nota >= 6;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nota: {Nota}");
            Console.WriteLine($"Status: {(EstaAprovado() ? "Aprovado" : "Reprovado")}");
        }
    }
}
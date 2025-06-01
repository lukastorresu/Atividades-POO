using EncapsulamentoEstudante;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudante e1 = new Estudante("João Silva", 8.5);
        Estudante e2 = new Estudante("Maria Oliveira", 5.2);

        Console.WriteLine("=== Estudante 1 ===");
        e1.ExibirInformacoes();

        Console.WriteLine("\n=== Estudante 2 ===");
        e2.ExibirInformacoes();
    }
}
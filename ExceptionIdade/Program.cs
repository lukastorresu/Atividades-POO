using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExceptionIdade;

class Program
{
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException($"Idade inválida: {idade} anos. A idade mínima permitida é 18 anos.");
        }
        Console.WriteLine($"\n Idade válida: {idade} anos.");
    }

    static void Main()
    {
        try
        {
            VerificarIdade(20);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("\n Erro: " + ex.Message);
        }

        try
        {
            VerificarIdade(15);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("\n Erro: " + ex.Message);
        }
    }
}
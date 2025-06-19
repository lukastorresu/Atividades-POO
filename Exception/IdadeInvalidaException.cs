using System;

public class IdadeInvalidaException : Exception
{
    // Construtor padrão com valores default
    public IdadeInvalidaException() : base("Idade inválida: menor que 18 anos")
    {
    }

    // Construtor que aceita uma mensagem personalizada
    public IdadeInvalidaException(string mensagem) : base(mensagem)
    {
    }

    // Construtor que aceita uma mensagem e a exceção interna
    public IdadeInvalidaException(string mensagem, Exception innerException) : base(mensagem, innerException)
    {
    }
}
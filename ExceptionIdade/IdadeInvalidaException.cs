using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionIdade
{
    public class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException() : base("Idade inválida: menor que 18 anos")
        {
        }

        public IdadeInvalidaException(string mensagem) : base(mensagem)
        {
        }
    }
}
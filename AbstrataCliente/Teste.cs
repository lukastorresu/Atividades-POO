using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class Teste
    {   //relacionamento/associação de dependência,
        //por meio do parâmetro
        public void AvaliarIdade(Cliente objCliente)
        {
            objCliente.VerificaIdade();
        }
    }
}
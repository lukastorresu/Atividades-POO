using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SRP;
class Program
{
    static void Main(string[] args)
    {
        var conta = new Conta("Lucas Torres");

        conta.Deposito(1000);
        conta.Sacar(300);

        var validador = new ValidadorUsuarios();
        bool usuarioValido = validador.ValidarUsuario(conta, "Lucas Torres");
        Console.WriteLine($"Usuário válido: {usuarioValido} \n");


        var geradorRelatorio = new GeradorRelatorio();
        string relatorio = geradorRelatorio.GerarRelatorio(conta);
        Console.WriteLine(relatorio);

        conta.Sacar(800);
        Console.WriteLine("");
        Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));
        conta.Deposito(-100);
        Console.WriteLine("");
        Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));

        conta.Sacar(200);
        Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));
        conta.Deposito(100);
        Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));
    }
}
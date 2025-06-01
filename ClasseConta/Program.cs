using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de variável
        Conta objetoConta;
        //instaciação do objeto
        objetoConta = new Conta();
        //manipulação do objeto
        objetoConta.numero = 101;
        objetoConta.titular = "Fatec";
        objetoConta.saldo = 1000;
        objetoConta.Sacar(30);
        objetoConta.MostrarAtributos();

        //declarar e instanciar objeto
        Conta c1 = new Conta(); 
        c1.numero = 200;
        c1.titular = "Giovana";
        c1.saldo = 50;
        double valorSaque = 20;
        c1.Sacar(valorSaque);// valorSaque é um argumento
        c1.MostrarAtributos();
        Conta c2 = new Conta();
        c1.Transferir(10,c2);
        c1.MostrarAtributos();
        c2.MostrarAtributos();
        c2.Depositar(200);
        c2.titular = "Eliana";
        c2.numero = 201;
        c2.MostrarAtributos();
    }
}
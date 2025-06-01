using EncapsulamentoFuncionario;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //instânica de objeto
        Funcionario f1 = new Funcionario();
        //utilização dos atributos encapsulados
        //f1.codigo = 1; erro por codigo minúsculo é atributo privado
        f1.Salario = 1000;  // o método set é chamado
        //f1.SetSalario(1000);
        //if (f1.Salario > 2000) o método get é chamado
        Console.Write("Digite o código do funcionário: ");
        f1.Codigo = Convert.ToInt32(Console.ReadLine());//set
        Console.Write("Digite o nome do funcionário: ");
        f1.Nome = Console.ReadLine();  
        Console.WriteLine("Nome: " + f1.Nome);//o método get é chamado
        Console.WriteLine("Código: " + f1.Codigo);//get
        Console.WriteLine("Salário: " + f1.Salario); //get
        f1.CalcularAumento(5);
        f1.Mostrar();
    }
}
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.Write("Digite o ano de nascimento: ");
        int ano_nascimento = Convert.ToInt32(Console.ReadLine());
        int idade = 2025 - ano_nascimento;
        Console.WriteLine("Sua idade é " + idade + " anos");
        //Estrutura de decisão
        if (idade < 18)
            System.Console.WriteLine("Menor de idade");
        else if (idade == 90)
            System.Console.WriteLine("Pare de trabalhar");
        else 
            Console.WriteLine("Maior de idade");
        
        int estacao = 3;
        switch (estacao) 
        {   // if estação == 1
            case 1: Console.WriteLine("Verão");
                    break;
            case 2: Console.WriteLine("Outono");
                    break;
            default: Console.WriteLine("Estação inválida");
                     break;
        }
        
        //Estrutura de repetição
        int cont = 1;
        while (cont <= 10)
        {
            Console.WriteLine("5 x "+cont + " = " + 5*cont);
            cont +=  1;
        }
        for (int cont = 1; cont <= 10; cont++)
            Console.WriteLine("6 x "+cont + " = " + 6*cont);
        int cont = 1;
        do
        {
            Console.WriteLine("7 x "+cont + " = " + 7*cont);
            cont += 1;
        }while (cont <= 10);
        int cont = 10;
        while (cont > -4)
        {
            Console.WriteLine("8 x "+cont + " = " + 8*cont);
            cont -= 1;// cont = cont - 1;
        }
        for (int cont = 10; cont >= 1; cont --)
            Console.WriteLine("9 x "+cont + " = " + 9*cont);
        
        int cont = 10;
        do
        {
            Console.WriteLine("8 x "+cont + " = " + 8*cont);
            cont = cont - 1;
        } while (cont >= 1);
        
        for (int tab = 5; tab <= 8; tab ++)
            for (int cont = 1; cont <= 10; cont++)
               Console.WriteLine(tab+" x "+cont + " = " + tab*cont);
        */
        int[] vet1 = new int[5];
        int[] vet2 = {8,7,9,6,5};
        for (int i = 0; i < vet2.Length; i++)
            Console.WriteLine("Conteúdo: "+vet2[i] + "  índice: " +i);
        foreach (int v in vet2)
            Console.WriteLine(v);
            System.Console.WriteLine();
    }
}
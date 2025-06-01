using EncapsulamentoProduto; //namespace
internal class Program
{
    private static void Main(string[] args)
    {   //tipo
        //classe   objeto   alocação de memória   construtor
        Produto     p1 =       new                Produto(); 
        p1.Codigo = 1; 
        p1.Nome = "mouse"; //set
        Console.WriteLine("Nome do produto: " + p1.Nome);//get

        Produto p2 = new Produto();
        p2.Codigo = 2; //set
        p2.Nome = "teclado"; //set
        p2.Preco = 55.91; //set
        Console.WriteLine("Nome do produto: " + p2.Nome);//get
        //if (p2.Preco > 50)     get  

    }
}
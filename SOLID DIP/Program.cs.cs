// Definição da NotaFiscal (que seria normalmente em um arquivo separado, mas incluída aqui para manter os 7 arquivos)
public class NotaFiscal
{
    public decimal Valor { get; set; }
    public decimal Imposto { get; private set; }
    public string Destinatario { get; set; }
    public string Endereco { get; set; }

    public void SetImposto(decimal imposto) => Imposto = imposto;
}

// Implementações concretas das interfaces (normalmente em arquivos separados, mas incluídas aqui)
public class LeiDeEntregaImplementacao : ILeiDeEntrega
{
    public bool DeveEntregarUrgente(NotaFiscal nf) => nf.Valor > 1000;
}

public class CorreiosImplementacao : ICorreios
{
    public void EnviaPorSedex10(NotaFiscal nf) => 
        Console.WriteLine($"Enviando nota fiscal para {nf.Destinatario} via SEDEX 10");

    public void EnviaPorSedexComum(NotaFiscal nf) => 
        Console.WriteLine($"Enviando nota fiscal para {nf.Destinatario} via SEDEX Comum");
}

class Program
{
    static void Main()
    {
        var dao = new NFDao();
        var calculadorImposto = new CalculadorDeImposto();
        var leiEntrega = new LeiDeEntregaImplementacao();
        var correios = new CorreiosImplementacao();
        var entregador = new EntregadorDeNFs(correios, leiEntrega);
        
        var despachador = new DespachadorDeNotasFiscais(dao, calculadorImposto, entregador);

        // Teste com nota fiscal de baixo valor (SEDEX Comum)
        var nf1 = new NotaFiscal
        {
            Valor = 500,
            Destinatario = "Cliente A",
            Endereco = "Rua A, 123"
        };
        
        Console.WriteLine("Processando nota fiscal 1:");
        despachador.Processa(nf1);
        
        // Teste com nota fiscal de alto valor (SEDEX 10)
        var nf2 = new NotaFiscal
        {
            Valor = 1500,
            Destinatario = "Cliente B",
            Endereco = "Rua B, 456"
        };
        
        Console.WriteLine("\nProcessando nota fiscal 2:");
        despachador.Processa(nf2);
    }
}
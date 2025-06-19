using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIP;

public class NotaFiscal
{
    public decimal Valor { get; set; }
    public decimal Imposto { get; private set; }
    public string Destinatario { get; set; }
    public string Endereco { get; set; }

    public void SetImposto(decimal imposto) => Imposto = imposto;
}

public class LeiDeEntregaImplementacao : ILeiDeEntrega
{
    public bool DeveEntregarUrgente(NotaFiscal nf) => nf.Valor > 1000;
}

public class CorreiosImplementacao : ICorreios
{
    public void EnviaPorSedex10(NotaFiscal nf) =>
        Console.WriteLine($"Enviando nota fiscal para {nf.Destinatario} via SEDEX 10.");

    public void EnviaPorSedexComum(NotaFiscal nf) =>
        Console.WriteLine($"Enviando nota fiscal para {nf.Destinatario} via SEDEX Comum.");
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

        var nf1 = new NotaFiscal
        {
            Valor = 500,
            Destinatario = "Nathalia",
            Endereco = "Rua Joao Zanuto, 668"
        };

        Console.WriteLine("Processando nota fiscal 1:");
        despachador.Processa(nf1);

        var nf2 = new NotaFiscal
        {
            Valor = 1500,
            Destinatario = "Lucas",
            Endereco = "Av Manoel Goulart, 2400"
        };

        Console.WriteLine("\nProcessando nota fiscal 2:");
        despachador.Processa(nf2);
    }
}
public class CalculadorDeImposto
{
    public decimal Para(NotaFiscal nf)
    {
        decimal imposto = nf.Valor * 0.10m;
        Console.WriteLine($"Calculado imposto de {imposto} para nota fiscal de {nf.Destinatario}");
        return imposto;
    }
}
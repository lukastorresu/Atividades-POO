public class NFDao
{
    public void Persiste(NotaFiscal nf)
    {
        Console.WriteLine($"Persistindo nota fiscal para {nf.Destinatario} no banco de dados");
    }
}
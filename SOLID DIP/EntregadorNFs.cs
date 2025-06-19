public class EntregadorDeNFs
{
    private readonly ICorreios _correios;
    private readonly ILeiDeEntrega _lei;

    public EntregadorDeNFs(ICorreios correios, ILeiDeEntrega lei)
    {
        _correios = correios;
        _lei = lei;
    }

    public void Entregar(NotaFiscal nf)
    {
        if (_lei.DeveEntregarUrgente(nf))
            _correios.EnviaPorSedex10(nf);
        else
            _correios.EnviaPorSedexComum(nf);
    }
}
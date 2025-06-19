public class DespachadorDeNotasFiscais
{
    private readonly NFDao _dao;
    private readonly CalculadorDeImposto _impostos;
    private readonly EntregadorDeNFs _entregador;

    public DespachadorDeNotasFiscais(NFDao dao, CalculadorDeImposto impostos, EntregadorDeNFs entregador)
    {
        _dao = dao;
        _impostos = impostos;
        _entregador = entregador;
    }

    public void Processa(NotaFiscal nf)
    {
        var imposto = _impostos.Para(nf);
        nf.SetImposto(imposto);
        _entregador.Entregar(nf);
        _dao.Persiste(nf);
    }
}
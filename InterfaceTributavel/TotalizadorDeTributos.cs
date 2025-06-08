namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributos();
        }
    }
}
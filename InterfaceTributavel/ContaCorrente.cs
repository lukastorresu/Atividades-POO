namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
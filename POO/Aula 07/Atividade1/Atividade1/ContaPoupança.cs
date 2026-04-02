namespace Atividade1
{
    internal class ContaPoupança : Conta
    {
        private double taxa;

        public  double TaxaDeJuros
        {
            get { return taxa; }
            private set { taxa = value; }
        }

        public ContaPoupança(int numeroConta, string titularConta, double saldoConta, double taxaDeJuros) : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AtualizacaoDeSaldo()
        {
            Console.WriteLine($"Saldo conta poupança: {SaldoConta}");
        }

        public void Saque( double quantia)
        {
            SaldoConta -= quantia;
        }
    }


}

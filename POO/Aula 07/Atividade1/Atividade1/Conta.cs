namespace Atividade1
{
    internal class Conta
    {
		private int numero;
		private string titular;
		private double saldo;

		public double SaldoConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public string TitularConta
		{
			get { return titular; }
			set { titular = value; }
		}
		
		public int NumeroConta
		{
			get { return numero; }
			set { numero = value; }
		}

		public Conta(int numeroConta, string titularConta, double saldoConta)
		{
			numero = numeroConta;
			titular = titularConta;
			saldo = saldoConta;
		}

		public Conta(int numeroConta, string titularConta):this (numeroConta, titularConta, 0)
		{
			saldo = 0;
		}
        public void Saque(double quantia)
        {
            SaldoConta -= quantia;
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }
        public override string ToString()
        {
            return $"Dados do cliente: " + $"\n\t Numero da conta: {NumeroConta}" + $"\n\t Titular da conta: {TitularConta}" + $"\n\t Saldo da conta; {SaldoConta:C}";
        }
    }
}

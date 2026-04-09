namespace Master
{
    internal class ContaPJ : Conta
    {
        //Campos
		private double limite;
        
        //Propriedade
        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}

        //Construtor
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }

        //metodos
        public void Emprestimo(double quantia)
        {
            LimiteConta -= quantia;
            SaldoConta += quantia;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tLimite Conta:{limite:C}";
        }
	}
}

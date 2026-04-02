namespace Master
{
    internal class ContaPoupanca : Conta
    {
		//Campo
		private double rendimento;

        //Propriedade
        public double RendimentoConta
		{
			get { return rendimento; }
			set { rendimento = value; }
		}

		//Construtor
        public ContaPoupanca(int numeroConta, double saldoConta, Pessoa dadosCliente, double rendimento) : base(numeroConta, saldoConta, dadosCliente)
        {
			RendimentoConta = rendimento;
        }

		//Metodos
		public void Consulta()
		{
            Console.WriteLine($"Dados do cliente: \n" + $"\tNome: {DadosCliente}\n" + $"\tNumero: {NumeroConta}\n" + $"\tSaldo: {SaldoConta}");
		}

	}
}

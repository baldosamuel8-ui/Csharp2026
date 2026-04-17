namespace Locadora.Classes.Entidades
{
    internal class Fatura
    {
		//Campos
		private double taxa;
		private double totalPagamento;
		private double pagamentoBasico;

        //Propriedades
        public double PagamentoBasico
		{
			get { return pagamentoBasico; }
			set { pagamentoBasico = value; }
		}
		public double TotalPagamento	
		{
			get { return PagamentoBasico + Taxa; }
            set { PagamentoBasico = value; }
		}
		public double Taxa
		{
			get { return taxa; }
			set { taxa = value; }
		}
		
		//Construtor
        public Fatura(double pagamentoBasico, double totalPagamento, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            TotalPagamento = totalPagamento;
            Taxa = taxa;
        }

        //Metodos
        public override string ToString()
        {
            return "Pagamento básico: "
                + PagamentoBasico
                + "\nTaxa: "
                + Taxa
                + "\nTotal: "
                + TotalPagamento;
        }

    }
}

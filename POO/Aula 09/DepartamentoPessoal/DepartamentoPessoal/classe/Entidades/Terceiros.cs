namespace DepartamentoPessoal.classe.Entidades
{
    internal class Terceiros : Funcionarios
    {
		private double despesa;

        public   double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}
        public Terceiros(double valorHora, int jornadaTrabalho, string nomeColaborador,double despesa) : base(valorHora, jornadaTrabalho, nomeColaborador)
        {
            DespesaAdicional = despesa;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }


	}
}

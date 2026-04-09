namespace DepartamentoPessoal.classe.Entidades
{
    internal class Funcionarios
    {
		private string nome;
		private int jornada;
		private double valor;

		//Propriedades
        protected double ValorHora
		{
			get { return valor; }
			set { valor = value; }
		}

		protected int JornadaTrabalho
		{
			get { return jornada; }
			set { jornada = value; }
		}

		protected string NomeColaborador
		{
			get { return nome; }
			set { nome = value; }
		}

		//Construtor
        public Funcionarios(double valorHora, int jornadaTrabalho, string nomeColaborador)
        {
            ValorHora = valorHora;
            JornadaTrabalho = jornadaTrabalho;
            NomeColaborador = nomeColaborador;
        }

		//Metodos

		public virtual double Pagamento()
		{
			return ValorHora * JornadaTrabalho;
		}

        public override string ToString()
        {
			return $"{NomeColaborador}";
        }



	}
}

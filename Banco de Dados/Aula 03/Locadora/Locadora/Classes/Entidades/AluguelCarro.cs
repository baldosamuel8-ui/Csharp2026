namespace Locadora.Classes.Entidades
{
    internal class AluguelCarro
    {
		//Campo
		private DateTime inicio;
		private DateTime fim;
		private Veiculo Aveiculo;

		public Veiculo AVeiculo 
		{
			get { return Aveiculo; }
			set { Aveiculo = value; }
		}


		//Propriedade
		public DateTime Fim
		{
			get { return fim; }
			set { fim = value; }
		}
		public DateTime Inicio
		{
			get { return inicio; }
			set { inicio = value; }
		}

	}
}

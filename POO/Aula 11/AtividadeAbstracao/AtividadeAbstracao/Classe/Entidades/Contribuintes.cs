using AtividadeAbstracao.Classe.Contratos;

namespace AtividadeAbstracao.Classe.Entidades
{
     abstract internal class Contribuintes : Iimposto
    {
		//Campos
		private string nome;
		private double rendaanual;

        //Propriedades
        public double RendaAnual
		{
			get { return rendaanual; }
			set { rendaanual = value; }
		}
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		//Construtor
        protected Contribuintes(double rendaAnual, string nome)
        {
            RendaAnual = rendaAnual;
            Nome = nome;
        }

		//Metodos
		public abstract double Imposto();
		
	}
}

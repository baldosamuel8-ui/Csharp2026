namespace AtividadeAbstracao.Classe.Entidades
{
    internal class Pessoafisica : Contribuintes
    {
		//Campos
		private double gsaude;

        //Propriedades
        public double GastoComSaude
		{
			get { return gsaude; }
			set { gsaude = value * 0.5; }
		}
        
        //Construtor
        public Pessoafisica(double rendaAnual, string nome, double gsaude) : base(rendaAnual, nome)
        {
            GastoComSaude = gsaude;
        }
        
        //Metodos
        public override double Imposto()
        {
            double impostoBase;
            if (RendaAnual < 20000.00)
            {
                impostoBase = RendaAnual * 0.15;
            }
            else
            {
                impostoBase = RendaAnual * 0.25;
            }

            double imposto = impostoBase - gsaude;
            if (imposto < 0) imposto = 0.0;
            return imposto;
        }
    }
}

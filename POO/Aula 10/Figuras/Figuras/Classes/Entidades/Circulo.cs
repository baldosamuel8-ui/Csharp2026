using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Circulo : Forma
    {
		//Campo
		private double raio;

        public Circulo(Cor corDaForma, double raio) : base(corDaForma)
        {
            Raio = raio;
        }

        //Propriedade
        public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}

        //Metodo
        public override double Area()
        {
            return Raio * Raio * 3.14;
        }

	}
}

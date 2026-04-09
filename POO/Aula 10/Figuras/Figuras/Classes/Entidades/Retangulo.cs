using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//campos
		private double largura;
		private double altura;

        //Propriedades
        protected double Altura
		{
			set { altura = value; }
			get { return largura; }
		}
		protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
		
		//Construtor
        public Retangulo(Cor corDaForma,double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }

        /// <summary>
        /// Calcula a area da forma usando as dimensões atuais.
        /// </summary>
        /// <returns></returns>O valor da area calculada com base na largura e altura do retangulo.
        //Metodo
        public override double Area() => Largura * Altura;


    }
}

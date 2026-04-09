
using Figuras.Classes.Contratos;
using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    /// <summary>
    /// Cores disponiveis Vermelho, Azul e Amarelo
    /// </summary>
    
    abstract internal class Forma : IArea
    {
        //Campo
        private Cor cor;

        //Propriedade
        protected Cor CorDaForma
        {
            get { return cor; }
            set { cor = value; }
        }
        //Construtor
        public Forma(Cor corDaForma)
        {
            CorDaForma = corDaForma;
        }

        //Metodo
        abstract public double Area();
        

    }
}

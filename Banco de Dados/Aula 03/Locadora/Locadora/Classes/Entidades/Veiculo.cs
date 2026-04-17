namespace Locadora.Classes.Entidades
{
    internal class Veiculo
    {
        //Campos
		private string modelo;

        //Propriedades
        public string Modelo	
		{
			get { return modelo; }
			set { modelo = value; }
		}
        
        //Construtor
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }


	}
}

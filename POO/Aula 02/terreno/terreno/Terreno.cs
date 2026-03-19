
namespace terreno
{
    public class Terreno
    {
        public double largura, comprimento, valor;

        //Construtor
        public Terreno(double largura, double comprimento, double valor)
        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }
        public double Area()
        {
            return largura * comprimento;
        }
        public double Preco()
        {
            return Area() * valor;
        }
        public void Saida()
        {
            Console.WriteLine($"Area do Terreno = {Area()}");
            Console.WriteLine($"Preço do Terreno = {Preco()}");
        }
    }

}

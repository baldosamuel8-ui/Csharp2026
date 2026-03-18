
namespace RetanguloComPOO
{
    internal class Retangulo
    {
        public double altura;
        public double largura;

        public double Area()
        {
            double area = largura * altura;
            return area;
        }
        public double Perimetro()
        {
            double perimetro = (largura + altura) * 2;
            return perimetro;
        }
        public double Diagonal()
        {
            double diagonal = (Math.Sqrt(largura*largura)+(altura*altura));
            return diagonal;
        }
    }

}

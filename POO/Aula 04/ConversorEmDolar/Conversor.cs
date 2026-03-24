
namespace ConversorEmDolar
{
    internal static class Conversor
    {
        public static double IOF = 0.06;


        public static double Converter(double cotacao, double qtd)
        {
            return (cotacao * qtd * 0.06) + (cotacao * qtd);
        }
    }
}

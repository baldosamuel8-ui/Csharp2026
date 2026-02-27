using static System.Console;
//declaração de Funções\\
static double delta(double a, double b, double c)
{
     return (b*b) - (4 * a * c);
}
static void saida(double x1, double x2)
{
    WriteLine($"X1 = {x1}\nX2 ={x2}");
}
static void raizes(double a, double b, double delta )
{
    double x1 = (-b - Math.Sqrt(delta))/(2*a);
    double x2 = (-b + Math.Sqrt(delta))/(2*a);
    saida(x1, x2);
}
//declaração de variaveis\\
double a, b, c, delta1;
const string TEXTO = "Digite o Valor de ";
//entrada de dados\\
Write(TEXTO + "A: ");
a = double.Parse(ReadLine());
Write(TEXTO + "B: ");
b = double.Parse(ReadLine());
Write(TEXTO + "C: ");
c = double.Parse(ReadLine());
//processamento de dados\\
delta1 = delta(a, b, c);
//Estrutura de Controle de If e else\\
if (delta1 < 0)
{
    WriteLine("Raizes Impossiveis");
}
else if (delta1 == 0)
{
    raizes(a, b, delta1);
}
else
{
    raizes(a, b, delta1);
}
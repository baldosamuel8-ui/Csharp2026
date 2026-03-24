using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 01";

double raio;
const double PI = 3.14;

Write("Entra com valor do Raio da Circuferencia: ");
ForegroundColor = Red;  //Muda Cor do Cara que Digita
raio = double.Parse(ReadLine());
ResetColor();

//Saida de dados
WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");
//Calculo da Circuferencia

double Circunferencia(double r)
{
    return 2 * PI * r;
}
//Calcular o Volume
double Volume(double r)
{
    return (4/3)* PI * r;
}
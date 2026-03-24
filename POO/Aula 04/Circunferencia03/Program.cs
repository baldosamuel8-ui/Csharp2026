using static System.Console;
using static System.ConsoleColor;
using Circunferencia03;

Title = "Calculadora 03";

Write("Digite o raio da circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();

WriteLine($"Circunferencia: {(raio)}");
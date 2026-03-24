using static System.Console;
using static System.ConsoleColor;
using Circunferencia02;

Write("Digite o raio da Circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();

Circunferencia c1 = new Circunferencia(raio);

WriteLine($"Circunferencia: {c1.circunferencia():F2}");
WriteLine($"Volume: {c1.Volume():F2}");
WriteLine($"PI: {c1.Pi()}");

ReadKey();
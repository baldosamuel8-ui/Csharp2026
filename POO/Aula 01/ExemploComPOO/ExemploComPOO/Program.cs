using ExemploComPOO;
using static System.Console;
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

//Entrada de dados
WriteLine("Digite as medidas do Triangulo X: ");
Write("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as Medidas do Triangulo Y");
Write("Digite a medida A: ");
y.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
y.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
y.ladoC = double.Parse(ReadLine());

WriteLine($"A area do Triangulo X é de {x.Area():F}");
WriteLine($"A area do Triangulo Y é de {y.Area():F}");

ReadKey();
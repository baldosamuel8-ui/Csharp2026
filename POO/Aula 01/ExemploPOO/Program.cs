using static System.Console;
//Entrada de dados
WriteLine("Digite as medidas do Triangulo X");
Write("Digite o valor de A: ");
double ax = double.Parse(Console.ReadLine());
Write("Digite o valor de B:");
double bx = double.Parse(Console.ReadLine());
Write("Digite o valor de C:");
double cx = double.Parse(Console.ReadLine());

WriteLine("Digite as medidas do Triangulo Y");
Write("Digite o valor de A: ");
double ay = double.Parse(Console.ReadLine());
Write("Digite o valor de B:");
double by = double.Parse(Console.ReadLine());
Write("Digite o valor de C:");
double cy = double.Parse(Console.ReadLine());

//Processamento de Dados

double px = (ax + bx + cx) / 2;
double py = (ay + cy + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saida de dados
WriteLine($"A Area do Triangulo X é de {areax:N}");
WriteLine($"A Area do Triangulo Y é de {areay:N}");

if (areax > areay)
{
    Console.WriteLine("Maior area e do Triangulo X");

}
else if (areay > areax)
{
    Console.WriteLine("Maior area e do Triangulo Y");
}
else
{
    Console.WriteLine("Os Triangulos de areas iguais");
}
ReadKey();
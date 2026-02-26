using static System.Console;

double a, b, c, p, area, areaT;

WriteLine("Digite o Primeiro valor A: ");
a = double.Parse(ReadLine());
WriteLine("Digite o Primeiro valor B: ");
b = double.Parse(ReadLine());
WriteLine("Digite o Primeiro valor C: ");
c = double.Parse(ReadLine());


if (a+b>c & a+c>b & b+c>a)
{
    p = (a+b+c)/2;
    area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    WriteLine("Triangulo Válido!");
    WriteLine($"A area do Seu Triangulo é {area:F2}");
}
else
{
    areaT = ((a+b)*c)/2;
    WriteLine("Triangulo invalido!");
    WriteLine($"Porém será um Trapézio\nA area do seu Trapézio é {areaT:F2}");
}
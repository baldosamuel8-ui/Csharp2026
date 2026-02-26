using static System.Console;

double a, b, c, x1, x2, delta;

WriteLine("Coeficiente A: ");
a = double.Parse(ReadLine());
WriteLine("Coeficiente B: ");
b = double.Parse(ReadLine());
WriteLine("Coeficiente C: ");
c = double.Parse(ReadLine());

delta = (b*b) - (4 * a * c);

if (delta<0)
{
    WriteLine("Raizeis Impossiveis");
}
else if (delta == 0)
{
    x1 = b/ (2*a);
    x2 = x1;
    WriteLine($"X1 = {x1}\nX2 = {x2}");
}
else
{
    x1 = (-b - Math.Sqrt(delta))/(2*a);
    x2 = (-b + Math.Sqrt(delta))/(2*a);
    WriteLine($"X1 = {x1}\nX2 = {x2}");
}
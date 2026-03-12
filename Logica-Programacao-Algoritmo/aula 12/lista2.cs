using static System.Console;

int n;
List<double> numeros = new List<double>();

System.Console.WriteLine("Quantos numeros você vai digitar?: ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write("Digite um numero: ");
    numeros.Add(double.Parse(ReadLine()));
}
;
Write("Valores = ");
for (int i = 0; i < n; i++)
{
    Write($" {numeros[i]}");
}

Write($"\nSoma = {numeros.Sum()}\n");
Write($"Media = {numeros.Average()}\n");
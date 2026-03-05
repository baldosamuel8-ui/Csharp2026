using static System.Console;
using static System.Linq.Enumerable;

int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, alturas = 0;

try{
    System.Console.WriteLine("Digite o número de visitantes: ");
    visitantes = int.Parse(ReadLine());
    System.Console.WriteLine("Digite a altura Maxima: ");
    altura_max = double.Parse(ReadLine());
    System.Console.WriteLine("Digite a altura minima:");
    altura_min = double.Parse(ReadLine());

    foreach (int i in Range (0, visitantes))
    {
        System.Console.WriteLine($"Digite a altura da pessoa n°{i+1}: ");
        alturas = int.Parse(ReadLine());
        if ((alturas >= altura_min) & (alturas <= altura_max))
        {
            contagem++;
            System.Console.WriteLine("Pessoa pode entrar no parque");
        }
    }
    System.Console.WriteLine($"O numero de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
    System.Console.WriteLine($"Digite valores válidos ERRO:{ex.Message}");
}
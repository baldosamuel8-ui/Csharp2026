using static System.Console;
using RetanguloComPOO;
try{
    Retangulo x = new Retangulo();

    Console.Write("Digite a altura do Retangulo: ");
    x.altura = double.Parse(ReadLine());
    Console.Write("Digite a largura do Retangulo: ");
    x.largura = double.Parse(ReadLine());
    WriteLine();

    WriteLine($"A Area desse Retangulo é: {x.Area()}");
    WriteLine($"O Perimetro desse Retangulo é: {x.Perimetro()}");
    WriteLine($"A Diagonal desse Retangulo é: {x.Diagonal()}");
    ReadKey();
}
catch (Exception ex)
{
    WriteLine($"Digite um Valor valido! ERRO:{ex.Message}");
}
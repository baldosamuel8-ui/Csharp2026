using static System.Console;

int codigo, quantidade;

Write("Digite o codigo do Produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade: ");
quantidade = int.Parse(ReadLine());
switch(codigo)
{
    case 1:
        WriteLine($"o valor total e de: {quantidade * 5.00} ");
        break;
    case 2:
        WriteLine($"o Valor total é de; {quantidade * 4.50}");
        break;
    case 3:
        WriteLine($"O Valor total é de: {quantidade * 3.75}");
        break;
    case 4:
        WriteLine($"o Valor total é de: {quantidade * 8.99}");
        break;
    case 5:
        WriteLine($"O Valor total é de: {quantidade * 11.33}");
        break;
}
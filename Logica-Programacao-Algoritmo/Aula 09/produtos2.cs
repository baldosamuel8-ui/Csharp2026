using static System.Console;

static void Total(int qtd, double valor)
{
    WriteLine($"o valor total e de R$:{qtd * valor}");
}

int codigo, quantidade;

try{
    Write("Digite o codigo do Produto: ");
    codigo = int.Parse(ReadLine());
    Write("Digite a quantidade: ");
    quantidade = int.Parse(ReadLine());
    switch(codigo)
    {
        case 1:
        Total(quantidade, 5.00);
            //WriteLine($"o valor total e de: {quantidade * 5.00} ");
            break;
        case 2:
        Total(quantidade, 4.50);
            //WriteLine($"o Valor total é de; {quantidade * 4.50}");
            break;
        case 3:
        Total(quantidade, 3.75);
            //WriteLine($"O Valor total é de: {quantidade * 3.75}");
            break;
        case 4:
        Total(quantidade, 8.99);
            //WriteLine($"o Valor total é de: {quantidade * 8.99}");
            break;
        case 5:
        Total(quantidade, 11.33);
            //WriteLine($"O Valor total é de: {quantidade * 11.33}");
            break;
        default:
            WriteLine("Codigo do Produto não cadastrado");
            break;
    }
}
catch (Exception ex)
{
    WriteLine($"Digite valores Válidos, erro: {ex.Message}");
}
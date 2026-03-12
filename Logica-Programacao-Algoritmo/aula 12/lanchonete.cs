using static System.Console;

try{

    System.Console.WriteLine("Cardapio:");
    System.Console.WriteLine("Produto 1:5.00\nProduto 2:3.50\nProduto 3:4.80\nProduto 4:8.90\nProduto 5:7.32\n");
    Dictionary<int, double> produto = new Dictionary<int, double>()
    {
        {1, 5.00},
        {2, 3.50},
        {3, 4.80},
        {4, 8.90},
        {5, 7.32}
    };

    System.Console.WriteLine("Digite o codigo do Produto: ");
    int codigo = int.Parse(ReadLine());
    System.Console.WriteLine("Digite a quantidade que você deseja comprar: ");
    int quantidade = int.Parse(ReadLine());

    double valor = quantidade*produto[codigo];

    Write($"O valor total: {valor:F2}");
}
catch (Exception ex)
{
    System.Console.WriteLine($"Ocorreu um ERRO:{ex.Message}");
}
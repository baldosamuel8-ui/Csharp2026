using static System.Console;
using exemplo01;

Console.WriteLine("Entre com os dados do Produto: ");
Write("Nome: ");
string nome = ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade: ");
int qtd = int.Parse(ReadLine());

Produto p = new Produto(nome, preco, qtd);

WriteLine($"Dados do Produto: {p.Dados_do_Produto()}");
Write($"Digite  a quantidade de produtos a ser adiconado no estoque: ");
qtd = int.Parse(ReadLine());
p.Adicionar_Produtos(qtd);

WriteLine($"Dados atualizados: {p.Dados_do_Produto()}");

Write("Digite a quantidade de produtos a ser removida do estoque: ");
qtd = int.Parse(ReadLine());
Write($"Dados atualizados: {p.Dados_do_Produto()}");
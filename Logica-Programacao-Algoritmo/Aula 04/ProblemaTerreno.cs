//Problema Terreno

//Entrada de dados
using static System.Console ;
double largura, comprimento, valor, area, preco;
//Declaração de variaveis
Write("Digite a Largura do Terreno: ");
largura = double.Parse(ReadLine());
Write("Digite o Comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
Write("Digite o valor do m2: ");
valor = double.Parse(ReadLine());
//Processamento de Dados
area = largura * comprimento;;
preco = area * valor;
//Saida de Dados
WriteLine($"A Area do Terreno é de {area} e o Preço do Terreno é de R${preco}");
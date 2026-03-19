using static System.Console;
using terreno;
 
Write("Digite a largura do Terreno: ");
double largura = double.Parse(ReadLine());
Write("Digite o Comprimento do Terreno: ");
double comprimento = double.Parse(ReadLine());
Write("Digite o Valor por metro quadrado: ");
double valor = double.Parse(ReadLine());

Terreno t = new Terreno(largura, comprimento, valor);

t.Saida();

ReadKey();
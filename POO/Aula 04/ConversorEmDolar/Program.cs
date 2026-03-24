using static System.Console;
using static ConversorEmDolar.Conversor;
using static System.ConsoleColor;

Write("Qual e a cotação do Dolar?: ");
double cotacao = double.Parse(ReadLine());
Write("Quantos dólares você vai comprar?: ");
double qtd = double.Parse(ReadLine());

Write($"Valor a ser pago em reais = {Converter(cotacao, qtd)}");
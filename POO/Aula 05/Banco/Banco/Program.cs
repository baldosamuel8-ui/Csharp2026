using static System.Console;
using Banco;
using static System.Globalization.CultureInfo;

try {

    Title = "Abertura de conta";
    Conta conta;

    WriteLine("Abertuta de conta - Nika Investment");
    Write("Entre com um número de conta: ");
    int numero = int.Parse(ReadLine());
    Write("Entre com o nome do Titular: ");
    string nome = ReadLine();
    Write("Deseja fazer deposito inicial (s/n): ");
    char resposta = char.Parse(ReadLine().ToLower());

    if ((resposta) == 's')
    {
        Write("Entre com valor de depósito inicial: R$ ");
        double deposito = double.Parse(ReadLine());

        conta = new Conta(numero, nome, deposito);
    }
    else
    {
        conta = new Conta(numero, nome); 
    }

    conta.Dados();
    WriteLine("Entre com um valor para depósito: R$ ");
    double quantia = double.Parse(ReadLine());
    conta.Deposito(quantia);
    WriteLine("Entre com um valor para saque: R$ ");
    quantia = double.Parse(ReadLine());
    conta.Saque(quantia);

    ReadKey();
}
catch(Exception)
{
    WriteLine("Escreva um valor Valido!");
}
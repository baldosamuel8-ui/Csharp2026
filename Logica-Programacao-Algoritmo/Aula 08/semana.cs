//o usuario vai digitar um valor de 1 a 7 e esse codigo é para mostrar o dia da semana corresponde ao número digitado pelo usario

using static System.Console;

int valor;

WriteLine("Digite um número de 1 a 7: ");
valor = int.Parse(ReadLine());
if (valor == 1)
{
    Write("Domingo");
}
else if (valor == 2)
{
    Write("Segunda-Feira");
}
else if (valor == 3)
{
    Write("Terça-Feira");
}
else if (valor == 3)
{
    Write("Quarta-Feira");
}
else if (valor == 5)
{
    Write("Quinta-Feira");
}
else if (valor == 6)
{
    Write("Sexta-Feira");
}
else if (valor == 7)
{
    Write("Sábado");
}
else
{
    WriteLine("Número Fora do Intervalo");
}
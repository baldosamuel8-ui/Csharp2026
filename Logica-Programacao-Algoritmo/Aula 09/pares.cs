using static System.Console;

int numero, valor;

try
{
    WriteLine("Quantos números você vai Digitar?: ");
    numero = int.Parse(ReadLine());
    //Teste de valores Negativos, Positivos e Nulos
    for (int i = 0; i < numero; i++)
    {
        WriteLine("Digite um número: ");
        valor = int.Parse(ReadLine());
        if ( valor < 0)
        {
            WriteLine("Este número é Negativo ");
        }
        else if (valor > 0)
        {
            WriteLine("Este número é Positivo ");
        }
        else
        {
            WriteLine("Este número é Nulo ");
        }

        if ((valor%2) == 0)
        {
            WriteLine("Este múmero é Par");
        }
        else if ((valor%2) != 0)
        {
            WriteLine("Este número é Impar");
        }
    }
}
catch(Exception ex)
{
    WriteLine("Valor invalido, erro =", ex.Message);
}
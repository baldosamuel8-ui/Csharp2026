using static System.Console;
using static System.Linq.Enumerable;
int n;

try{
    Write("Quantos números você vai digitar? ");
    n = int.Parse(ReadLine());

    if (n < 0)
    {
        WriteLine("Valor invalido, digite valores positivos!");
        WriteLine("Tente novamente");
    }
    else if (n > 10)
    {
        WriteLine("Maximo de valores para digitar igual a 10");
        WriteLine("Tente novamente");
    }
    else
    {
        //declaração do vetor
        int [] numeros = new int [n];
        for (int i = 0; i < numeros.Length; i++)
        {
            Write($"Digite o {i+1}° numero: ");
            numeros[i] = int.Parse(ReadLine());
        }

        WriteLine("NUMEROS NEGATIVOS: ");
        foreach (int item in Range(0, numeros.Length))
        {
            if (numeros[item]<0)
            {
                WriteLine(numeros[item]);
            }
        }
    }
}
catch (Exception ex)
{
    Write($"Digite valores Validos, ERRO:{ex.Message}");
}
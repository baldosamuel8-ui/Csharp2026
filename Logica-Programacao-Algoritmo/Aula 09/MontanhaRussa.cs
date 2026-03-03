using static System.Console;

int npessoas, altura_pessoa;

Write("Digite o número de altura das pessoas: ");
npessoas = int.Parse(ReadLine());

for (int i = 0; i < npessoas; i++)
{
    Write($"Digite a altura da pessoa número {i+1}:");
    altura_pessoa = int.Parse(ReadLine());
    if (altura_pessoa < 140)
    {
        WriteLine("Você e muito baixo(a)");
    }
    else if (altura_pessoa > 160)
    {
        WriteLine("Você e muito alto(a)");
    }
    else
    {
        WriteLine("você está na Altura Ideal!");
    }
}
using static System.Console;
try{
    double nota1, nota2, resultado;
    WriteLine("Digite a Primeira Nota: ");
    nota1 = double.Parse(ReadLine());
    WriteLine("Digite a Segunda Nota: ");
    nota2 = double.Parse(ReadLine());

    resultado = nota1 + nota2;
    if (resultado >= 60 )
    {
        WriteLine($"Sua Nota Final foi {resultado:F2}");
        WriteLine("Aprovado");
    }
    else
    {
        WriteLine($"Sua Nota Final foi {resultado:F2}");
        WriteLine("Reprovado!");
    }
}
catch(Exception)
{
    WriteLine("Digite a Nota com Números Por Favor!");
}


using static System.Console;
try{
    System.Console.WriteLine("Digite o Primeiro Valor: ");
    int v1 = int.Parse(ReadLine());
    System.Console.WriteLine("Digite o Segundo Valor: ");
    int v2 = int.Parse(ReadLine());
    System.Console.WriteLine("Digite o Terceiro Valor: ");
    int v3 = int.Parse(ReadLine());

    bool comparacao1 = v1 == v3;
    System.Console.WriteLine($"O Primeiro valor é igual ao Terceiro valor?R:{comparacao1}\n");
    bool comparacao2 = v2 != v1;
    System.Console.WriteLine($"O Segundo valor é diferente do Primeiro valor?R:{comparacao2}\n");
    bool comparacao3 = v2 > v3;
    System.Console.WriteLine($"O Segundo valor e maior que o Terceiro valor?R:{comparacao3}\n");
    bool comparacao4 = v1 <= v3;
    System.Console.WriteLine($"O Primeiro valor é menor ou igual que o Terceiro valor?R:{comparacao4}\n");

    bool resultado1 = comparacao1 & comparacao3;
    System.Console.WriteLine($"Se a Primeira pergunta e a Terceira pergunta são True?R:{resultado1}");
    bool resultado2 = comparacao2 | comparacao4;
    System.Console.WriteLine($"Se a Segunda pergunta e a Quarta pergunta pelo menos uma e True?R:{resultado2}");
    bool resultado3 = !comparacao1;
    System.Console.WriteLine($"Se a negação da Primeira pergunta é True?R:{resultado3}");
}
catch(Exception)
{
    System.Console.WriteLine("Para de ser neandertal, e coloca um Numero Inteiro!");
}
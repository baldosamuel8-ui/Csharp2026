using static System.Console;
using atividade01;

Nota x = new Nota();
Write("Nome do Aluno: ");
x.nome = ReadLine();
WriteLine("Digite as 3 Notas: ");
x.nota1 = double.Parse(ReadLine());
x.nota2 = double.Parse(ReadLine());
x.nota3 = double.Parse(ReadLine());

x.Notas();
Console.WriteLine($"A nota Final do Aluno:{x.Notas()}");
x.ReprovadoOuAprovado();
using static System.Console;
using atividade02;

Salario s = new Salario();
Console.WriteLine("Digite o nome do Funcionario: ");
s.nome = ReadLine();
Console.WriteLine("Digite o salario do Funcionario: ");
s.SalarioLiquido = double.Parse(ReadLine());
Console.WriteLine("Digite o valor do Imposto ao Salario: ");
s.imposto = double.Parse(ReadLine());
s.DadosImposto();
s.ResultadoSalario();
Console.WriteLine("Digite a porcentagem do aumento do salario:  ");
s.AumentoporPorcentagem = double.Parse(ReadLine());
s.Resultado();
s.Saida();
ReadKey();
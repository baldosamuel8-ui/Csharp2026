using DepartamentoPessoal.classe.Entidades;
using static System.Console;
List<Funcionarios> colaboradores = new();

Write("Quantos funcionarios ira cadastrar: ");
int n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    WriteLine($"Colaborador n°{i + 1}");
    Write("O funcionário é terceirizado (s/n): ");
    char e = char.Parse(ReadLine().ToLower());
    if (e == 'n')
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        colaboradores.Add(new Funcionarios(v, h, nome));
    }
    else
    {
        Write("Nome: ");
        string nome = ReadLine();
        Write("Horas trabalhadas: ");
        int h = int.Parse(ReadLine());
        Write("Valor da hora: ");
        double v = double.Parse(ReadLine());
        Write("Depesa adicional: R$ ");
        double d = double.Parse(ReadLine());
        colaboradores.Add(new Terceiros(v, h, nome, d));
    }


}

WriteLine(" - Pagamentos - ");
foreach (var colab in colaboradores)
{
    WriteLine(colab.ToString());
}

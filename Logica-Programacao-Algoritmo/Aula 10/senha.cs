using static System.Console;

const int SENHAFIXA = 2002;
int senha, contagem = 0;

Write("Digite a Senha;");
senha = int.Parse(ReadLine());

while (senha != SENHAFIXA)
{
    if (contagem >= 3)
    {
        WriteLine("Acesso Bloqueado!");
        break;
    }
    contagem++;
    Write("Senha incorreta, digite novamente: ");
    senha = int.Parse(ReadLine());
}
if (contagem < 3)
{
    WriteLine("Acesso Permitido!");
}
else
{
    WriteLine($"Número de tentativas excedidos, aguarde 30 segundos");
}

using static System.Console;

int n = 0;
do
{
    WriteLine(n);
    n++;
    Task.Delay(1000).Wait();

}while (n < 5);


n = 0;
while (n < 5)
{
    WriteLine(n);
    n++;
    Task.Delay(1000).Wait();
}
WriteLine("Fim do Programa");
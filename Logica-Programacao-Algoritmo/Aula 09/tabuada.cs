using static System.Console;

int num;

num = int.Parse(ReadLine());

for (int i=0; i < 100; i++)
{
    WriteLine($"{num} x {i+1} = {num * (i+1)}");

}
using static System.Console;

int [,] matrix = new int [3,3];

//entrada de dados, inserir valores na matrix

for (int i = 0; 0 < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"Digite o valor p/ a posição [{i},{j}]: ");
        matrix[i, j] = int.Parse(ReadLine());
    }
}

WriteLine("Matrix preenchida: ");
for (int i = 0; 0 < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write(matrix[i, j] + "\t");
    }
    WriteLine();
}
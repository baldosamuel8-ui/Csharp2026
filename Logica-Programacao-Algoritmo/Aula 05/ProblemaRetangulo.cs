
using static System.Console;

double Base, altura, area, perimetro, diagonal;

WriteLine("Digite a base do Retangulo: ");
    Base = double.Parse(ReadLine());
WriteLine("Digite a Altura do Retangulo: \n");
    altura = double.Parse(ReadLine());

area =  Base * altura;
perimetro = 2*Base + 2*altura;
diagonal = Math.Sqrt((Base*Base)+(altura*altura));

    WriteLine($"A Área desse Retangulo é:{area}");
    WriteLine($"O Perimetro desse Retangulo é:{perimetro}");
    WriteLine($"A Diagonal desse Retangulo é:{diagonal}");
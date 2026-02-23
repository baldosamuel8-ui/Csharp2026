using static System.Console;
//Declaração de Variaveis
double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;
//Entrada de dados
Write("Digite a Medida A: ");
    a = double.Parse(ReadLine());
Write("Digite a medida B: ");
     b = double.Parse(ReadLine());
Write("Digite a medida C: ");
     c = double.Parse(ReadLine());
//processamento de Dados
areaQuadrado = a * a;
areaTriangulo = (a*b)/2;
areaTrapezio = ((a+b) * c)/2;
//Saida de Dados
WriteLine($"Area do Quadrado = {areaQuadrado:F4}");
WriteLine($"Area do Triangulo = {areaTriangulo:4F}");
WriteLine($"Area do Trapezio = {areaTrapezio:F4}");
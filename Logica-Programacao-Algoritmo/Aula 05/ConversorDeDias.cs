using static System.Console;

int diasdigitados, anos, meses6, meses, semanas;

System.Console.WriteLine("Digite o numeros de Dias: ");
diasdigitados = int.Parse(ReadLine());
System.Console.WriteLine("Convertendo...");

anos = diasdigitados/365;
meses6 = diasdigitados/182;
meses = diasdigitados/30;
semanas = diasdigitados/7;


System.Console.WriteLine($"{anos} Ano(s)");
System.Console.WriteLine($"{meses6} Semestre(s)");
System.Console.WriteLine($"{meses} Mese(s)");
System.Console.WriteLine($"{semanas} Semana(s)");
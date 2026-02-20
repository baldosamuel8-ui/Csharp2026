using static System.Console;

double precoU, quantidade, dinheirorecebido, troco;

System.Console.WriteLine("Preço Unitario dos produto:");
precoU = double.Parse(ReadLine());
System.Console.WriteLine("Quantidade comprada: ");
quantidade = double.Parse(ReadLine());
System.Console.WriteLine("Dinheiro Recebido: ");
dinheirorecebido = double.Parse(ReadLine());

troco = dinheirorecebido-(precoU*quantidade);

System.Console.WriteLine($"O seu Troco é R${troco}");
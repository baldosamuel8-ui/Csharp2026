using Master;

Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupança);
Console.WriteLine(Tipo.ContaPj);

Conta conta = new Conta(12345, 1500.56, new Pessoa("Clodoaldo", 12345));

var a = conta.ToString();
Console.WriteLine(a);

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("Cesar", 56956773864), 20000);

var b = pj.ToString();
Console.WriteLine(b);

ContaPoupanca pp = new ContaPoupanca(77777, 12000, new Pessoa("Lu", 54882772661), 20);

pp.Consulta();


Console.ReadKey();
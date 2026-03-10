string [] nomes = {"João", "Maria", "Pedro", "Ana", "Lucas"};
int [] numeros = new int [5];

System.Console.WriteLine(nomes[2]);
numeros [0] = 10;
numeros [1] = 11;
System.Console.WriteLine(numeros [1]);
numeros [2] = 0;
numeros [3] = 5;
numeros [4] = 7;
numeros [5] = 9;
int tamanho = numeros.length;//tamanho do vetor
System.Console.WriteLine(tamanho);
numeros.GetType();//tipo do vetor
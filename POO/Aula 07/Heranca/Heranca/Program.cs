using static System.Console;
using Heranca;


PessoaJuridica senai = new PessoaJuridica("SESI", 365498 , 12000.00);
PessoaFisica cesar = new PessoaFisica("Samuel", 546987);

Console.WriteLine(cesar);//Imprimir somente o obj
Console.WriteLine(cesar.ToString());//imprimir e converte o obj p/string

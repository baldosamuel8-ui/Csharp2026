using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;
using static System.Console;
using var context = new BancoContexto();

//Verifica se o DataBase(DB) existe e cria se necessário
//Cria as tabelas baseadas na entidades configuradas
context.Database.EnsureCreated();

//Menu do Programa
WriteLine("=== Sistema Bancario ===");
WriteLine("\n---MENU PRINCIPAl---");
WriteLine("1 - Cadastrar nova conta");
WriteLine("2 - Consultar conta existente");
WriteLine("3 - Sair\n");
Write("Escolha uma opção: ");

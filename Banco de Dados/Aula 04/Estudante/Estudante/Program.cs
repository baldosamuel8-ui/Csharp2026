using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Clodoaldo", 12345, "Java");
context.Alunos.Add(pessoa1); 
context.SaveChanges();

var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();
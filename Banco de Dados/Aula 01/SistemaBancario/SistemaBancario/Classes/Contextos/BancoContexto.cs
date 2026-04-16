using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos
{
    internal class BancoContexto : DbContext
    {
        /// <summary>
        /// DBset Representa a tabela de contas bancarias no banco de dados
        /// </summary>
        
        public DbSet <Banco> Contas { get; set; }

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite for a lightweight file-based database so the app doesn't depend on LocalDB
            optionsBuilder.UseSqlite("Data Source=BancoDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity=>
            {
                entity.HasKey(e=>e.Id);
                entity.Property(e=>e.NumeroConta).IsRequired();
                entity.Property(e=>e.Titular).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");
            }
                 
            );
        }
    }
}

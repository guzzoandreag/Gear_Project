using Microsoft.EntityFrameworkCore;
using Gear_API.Models;

namespace Gear_API.Data
{
    public class DataContext : DbContext
    {
        // Conexao com SQLServer local
        private const string ConnectionString = @"Server=LOCALHOST\NESKI;Database=dbGear;User Id=sa;Password=Neski5500*;";

        // Conexao com SQLServer em tempo de desenvolvimento quando executado em Docker.
        //private const string ConnectionString = "Server=LOCALHOST,1401;Database=dbGear;User Id=sa;Password=Gear5038;";

        // Conexao com SQLServer em tempo de execucao quando executado em Docker.
        //private const string ConnectionString = "Server=172.17.0.2,1433;Database=dbGear;User Id=sa;Password=Gear5038;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString
                , options => options.EnableRetryOnFailure());
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações do field.
            //modelBuilder.Entity<Users>()
            //    .Property(u => u.Use_email)
            //        .HasMaxLength(30)
            //        .IsRequired();

            // Add dados ao executar a migration.
            //modelBuilder.Entity<Users>()
            //    .HasData(
            //        new Users {Use_code = 0,
            //                   Use_name = "André Guzzo",
            //                   Use_email = "guzzoandre.ag@outlook.com",
            //                   Usu_password = "99345038"}
            //    );
        }

        public DbSet<Produto_00> Produtos_00 { get; set; }
        public DbSet<Estoque_00> Estoque_00 { get; set; }
        public DbSet<Deposito_00> Deposito_00 { get; set; }
    }
}

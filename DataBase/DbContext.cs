using Microsoft.EntityFrameworkCore;
using TesteDotNetInfinity.Models;

namespace TesteDotNetInfinity.Database
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options)
        {
        }

        public DbSet<CadastroFrete> Fretes { get; set; }

        public DbSet<CadastroVeiculos> Veiculos { get; set; }

        public DbSet<ListadeEntregas> Entregas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TesteDotNetInfinity;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

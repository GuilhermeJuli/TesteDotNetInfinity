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

        public DbSet<CadastroTerceiro> Terceiros { get; set; }

        public DbSet<Entrega> Entregas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

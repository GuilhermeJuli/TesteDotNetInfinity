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

        public DbSet<CadastroFrete> CadastroFrete { get; set; }
        public DbSet<CadastroVeiculos> CadastroVeiculos { get; set; }
        public DbSet<CadastroUsuarios> CadastroUsuarios { get; set; }
        public DbSet<ListadeEntregas> ListadeEntregas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CadastroFrete>()
        .HasOne(f => f.Destino)
        .WithMany() 
        .HasForeignKey(f => f.VeiculoId) 
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<CadastroUsuarios>()
        .HasOne(u => u.Perfil)
        .WithMany() 
        .HasForeignKey(u => u.Id) 
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<CadastroVeiculos>()
        .HasOne(v => v.Modelo)
        .WithMany() 
        .HasForeignKey(v => v.Id) 
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<ListadeEntregas>()
        .HasOne(l => l.Peso)
        .WithMany() 
        .HasForeignKey(l => l.Id) 
        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

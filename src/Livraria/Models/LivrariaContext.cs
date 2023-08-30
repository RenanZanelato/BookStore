using Microsoft.EntityFrameworkCore;

namespace Livraria.Models
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        // Outros DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().ToTable("autores");
            modelBuilder.Entity<Categoria>().ToTable("categorias");
            // Configurações para outras entidades
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Livraria.Domain.Entity;

namespace Livraria.Infrastructure.Data;

public class LivrariaContext : DbContext
{
    public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
    {
    }

    public DbSet<Autor> Autores { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Livro> Livros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>().ToTable("autores");
        modelBuilder.Entity<Categoria>().ToTable("categorias");
        modelBuilder.Entity<Livro>().ToTable("livros");
    }
}
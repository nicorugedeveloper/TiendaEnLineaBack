namespace DefaultNamespace;

using Microsoft.EntityFrameworkCore;
using Core.Entities;  

public class AppDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<ProductoDeseado> ProductosDeseados { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }  

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Categoria)
            .WithMany(c => c.Productos)
            .HasForeignKey(p => p.CategoriaId);
        
        modelBuilder.Entity<ProductoDeseado>()
            .HasOne(pd => pd.Producto)
            .WithMany()
            .HasForeignKey(pd => pd.ProductoId);
        
    }
}

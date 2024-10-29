using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Videojuego> Videojuegos { get; set; }
    public DbSet<Plataforma> Plataformas { get; set; }
    public DbSet<Personaje> Personajes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

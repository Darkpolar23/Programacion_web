
using Microsoft.EntityFrameworkCore;

public class SerieContext : DbContext
{
    public DbSet<SeriePeliculaLibro> SeriePeliculalibros { get; set; }
    public DbSet<Personaje> Personajes { get; set; } 

    public SerieContext(DbContextOptions<SerieContext> options)
        : base(options) { }
}
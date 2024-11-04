using Microsoft.EntityFrameworkCore;

//utilizamos entityFramework para crear los Dbset que nos ayudaran a crear las base de datos
public class RegistrosVisita : DbContext
{
    public DbSet<RegistroVisita> RegistroVisitas { get; set; }

    public RegistrosVisita(DbContextOptions<RegistrosVisita> options)
        : base(options) { }
}

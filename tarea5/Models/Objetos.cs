public class Videojuego
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Desarrollador { get; set; } = "";
    public string Genero { get; set; } = "";
    public DateTime FechaLanzamiento { get; set; }
    public string ImagenPortada { get; set; } = "";
    public string Descripcion { get; set; } = "";

    public int PlataformaId { get; set; }
    public Plataforma? Plataforma { get; set; } 

    public List<Personaje> Personajes { get; set; } = new List<Personaje>();
}

public class Plataforma
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public bool Activa { get; set; }
}

public class Personaje
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Alias { get; set; } = "";
    public string Rol { get; set; } = "";
    public string HabilidadEspecial { get; set; } = "";
    public string ArmaFavorita { get; set; } = "";
    public int NivelPoder { get; set; }
    public string ImagenPersonaje { get; set; } = "";

    public int VideojuegoId { get; set; }
    public Videojuego? Videojuego { get; set; }
}

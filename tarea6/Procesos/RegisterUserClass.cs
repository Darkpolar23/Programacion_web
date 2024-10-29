//se manejan las clases, se trata junto a con ManejadorUser ya que alli se crean el codigo de la api

class Usuario
{
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public string? Clave { get; set; }
}

class DatosLogin
{
    public string? Cedula { get; set; }
    public string? Clave { get; set; }
}


class Incidencia
{
    public string? Pasaporte { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? WhatsApp { get; set; }
    public string? FechaNacimiento { get; set; }
    public double? Latitud { get; set; }
    public double? Longitud { get; set; }
    public string? CodigoAgente { get; set; }
}


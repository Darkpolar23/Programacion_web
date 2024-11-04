using System.ComponentModel.DataAnnotations;

//Datos a tener encuenta
/*Teléfono, Nombre, Apellido, Correo electrónico*/

//modelo para crear las base de datos y el DataAnnotations 
//para colocar los limites a los futuros campos
public class RegistroVisita
{

    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Teléfono es requerido")]
    [MinLength(10, ErrorMessage = "El campo Teléfono debe tener al menos 10 caracteres")]
    public string? Teléfono { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido")]
    [MinLength(3, ErrorMessage = "El campo Nombre debe tener al menos 5 caracteres")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El campo Apellido es requerido")]
    [MinLength(4, ErrorMessage = "El campo Apellido debe tener al menos 7 caracteres")]
    public string? Apellido { get; set; }

    [Required(ErrorMessage = "El campo Correo Electrónico es requerido")]
    [MinLength(15, ErrorMessage = "El campo Correo Electrónico debe tener al menos 15 caracteres")]
    public string? CorreoElectrónico { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;

public class Tardanza
{
    // matrícula, nombre, apellido, curso y motivo, fecha, 
    //Jose colon peña 2023-1137

    public string Id { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Matricula es requerido")]
    [MinLength(10, ErrorMessage = "El campo Matricula debe tener al menos 9 caracteres")]
    public string Matricula { get; set; } = "";

    [Required(ErrorMessage = "El campo Apellido es requerido")]
    [MinLength(3, ErrorMessage = "El campo Apellido debe tener al menos 3 caracteres")]
    public string Nombre { get; set; }  = "";

    [Required(ErrorMessage = "El campo Apellido es requerido")]
    [MinLength(3, ErrorMessage = "El campo Apellido debe tener al menos 3 caracteres")]
    public string Apellido { get; set; }  = "";

    [Required(ErrorMessage = "El campo Curso es requerido")]
    [MinLength(3, ErrorMessage = "El campo Curso debe tener al menos 3 caracteres")]
    public string Curso { get; set; }  = "";

    [Required(ErrorMessage = "El campo Motivo es requerido")]
    [MinLength(10, ErrorMessage = "El campo motivo debe tener al menos 10 caracteres")]
    public string Motivo { get; set; } = "";

}

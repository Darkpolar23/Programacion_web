using System;
using System.ComponentModel.DataAnnotations;


class Reporte
{
    public string Id { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Descripción es requerido")]
    [MinLength(10, ErrorMessage = "La descripción debe tener al menos 10 caracteres")]
    public string Descripcion { get; set; } = "";

    [Required(ErrorMessage = "El campo Costo Estimado es requerido")]
    [Range(0, double.MaxValue, ErrorMessage = "El costo estimado debe ser mayor 0")]
    public double CostoEstimado { get; set; } = 0;

    [Required(ErrorMessage = "El campo Muertos es requerido")]
    [Range(0, int.MaxValue, ErrorMessage = "El número de muertos debe ser mayor 0")]
    public int Muertos { get; set; } = 0;

    [Required(ErrorMessage = "El campo Heridos es requerido")]
    [Range(0, int.MaxValue, ErrorMessage = "El número de heridos debe ser mayor 0")]
    public int Heridos { get; set; } = 0;

    [Required(ErrorMessage = "El campo Vehículos Involucrados es requerido")]
    [Range(0, int.MaxValue, ErrorMessage = "El número de vehículos involucrados debe ser mayor 0")]
    public int VehículosInvolucrados { get; set; } = 0;
}

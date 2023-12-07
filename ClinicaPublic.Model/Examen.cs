using System.ComponentModel.DataAnnotations;

public class Examen
{
    [Key]
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public DateTime? FechaRegistro { get; set; }
}

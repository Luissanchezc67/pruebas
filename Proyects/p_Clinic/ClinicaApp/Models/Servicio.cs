namespace ClinicaApp.Models
{public class Servicio
{
    public int IdServicio { get; set; }
    public string Nombre { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public decimal Precio { get; set; }
    public string Estado { get; set; } = null!;

    // Relaciones
    public ICollection<Cita> Citas { get; set; } = null!;
}}
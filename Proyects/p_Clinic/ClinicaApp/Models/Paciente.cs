namespace ClinicaApp.Models
{public class Paciente
{
    public int IdPaciente { get; set; }
    public string Nombre { get; set; } = null!;
    public string Direccion { get; set; } = null!;
    public string Telefono { get; set; } = null!;
    public string NroDoc { get; set; } = null!;
    public string TipoDoc { get; set; } = null!;
    public DateTime FechaNac { get; set; }
    public string Antecedentes { get; set; } = null!;
    public string Estado { get; set; } = null!;

    // Relaciones
    public ICollection<Cita> Citas { get; set; } = null!;
    
}}
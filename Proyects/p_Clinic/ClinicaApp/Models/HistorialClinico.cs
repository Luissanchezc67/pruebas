namespace ClinicaApp.Models
{
public class HistorialClinico
{
    public int IdHistorial { get; set; }
    public int IdPaciente { get; set; }
    public int IdDoctor { get; set; }
    public string Diagnostico { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public DateTime FechaCreacion { get; set; }

    // Relaciones
    public Paciente Paciente { get; set; } = null!;
    public Doctor Doctor { get; set; } = null!;
}
}

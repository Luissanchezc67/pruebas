namespace ClinicaApp.Models
{
public class HistorialClinico
{
    public int HistorialClinicoId { get; set; }
    public int PacienteId { get; set; }
    public int DoctorId { get; set; }
    public string Diagnostico { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public DateTime FechaCreacion { get; set; }

    // Relaciones
    public Paciente Paciente { get; set; } = null!;
    public Doctor Doctor { get; set; } = null!;
}
}

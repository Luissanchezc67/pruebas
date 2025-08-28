namespace ClinicaApp.Models{
    public class Doctor
{
    public int DoctorId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Especialidad { get; set; } = null!;
    public string Telefono { get; set; } = null!;
    public string Estado { get; set; } = null!;

    // Relaciones
    public ICollection<Cita> Citas { get; set; } = null!;
}
}
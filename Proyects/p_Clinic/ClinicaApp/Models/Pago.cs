namespace ClinicaApp.Models
{public class Pago
{
    public int IdPago { get; set; }
    public int IdPaciente { get; set; }
    public Paciente Paciente { get; set; } = null!;
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public string MetodoPago { get; set; } = null!;
    public string Estado { get; set; } = null!;

    // Relaciones
    //public int IdCita { get; set; }
    // public Cita Cita { get; set; } = null!;
}}
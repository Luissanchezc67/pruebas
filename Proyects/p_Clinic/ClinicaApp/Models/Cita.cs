namespace ClinicaApp.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; } // Cambiado a TimeSpan para representar solo la hora
        public string Estado { get; set; } = null!;
        public string Motivo { get; set; } = null!;

        // Claves foráneas
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }

        // Relaciones
        public Paciente Paciente { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}
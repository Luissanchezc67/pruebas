namespace ClinicaApp.Models
{
    public class Cita
    {
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; } // Cambiado a TimeSpan para representar solo la hora
        public string Estado { get; set; } = null!;
        public string Motivo { get; set; } = null!;

        // Claves foráneas
        public int PacienteId { get; set; } 
        public int DoctorId { get; set; }

        // Relaciones
        public Paciente Paciente { get; set; } = new List<Paciente>();
        public Doctor Doctor { get; set; } = new List<Doctor>();
       
    }
}
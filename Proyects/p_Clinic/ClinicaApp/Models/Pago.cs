namespace ClinicaApp.Models
{public class Pago
    {
        public int PagoId { get; set; }
        

        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; } = null!;
        public string Estado { get; set; } = null!;


        public int PacienteId { get; set; }

        // Relaciones
        public Paciente Paciente { get; set; } = null!;

        //public int IdCita { get; set; }
        // public Cita Cita { get; set; } = null!;
    }
}
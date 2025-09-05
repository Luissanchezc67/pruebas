using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        // Ejemplo: Admin, Doctor, Recepcionista
        public string Rol { get; set; }
    }
}

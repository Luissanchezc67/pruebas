using Microsoft.EntityFrameworkCore;
using ClinicaApp.Models;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Doctor> Doctores { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<HistorialClinico> Historiales { get; set; }
}

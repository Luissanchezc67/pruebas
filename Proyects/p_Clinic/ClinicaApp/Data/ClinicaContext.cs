using Microsoft.EntityFrameworkCore;
using ClinicaApp.Models;


public class ClinicaContext : DbContext
{
    public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options) {}

    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Paciente> Pacientes { get; set; } = null!;
    public DbSet<Doctor> Doctores { get; set; } = null!;
    public DbSet<Cita> Citas { get; set; } = null!;
    public DbSet<Servicio> Servicios { get; set; } = null!;
    public DbSet<Pago> Pagos { get; set; } = null!;
    public DbSet<HistorialClinico> Historiales { get; set; } = null!;
}

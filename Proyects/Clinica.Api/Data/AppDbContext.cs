using Clinica.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Aquí registramos nuestras tablas
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Paciente> Pacientes => Set<Paciente>();
    public DbSet<Doctor> Doctores => Set<Doctor>();
    public DbSet<Servicio> Servicios => Set<Servicio>();
    public DbSet<Cita> Citas => Set<Cita>();
    public DbSet<HistoriaClinica> HistoriasClinicas => Set<HistoriaClinica>();
    public DbSet<Pago> Pagos => Set<Pago>();
    public DbSet<PagoDetalle> PagoDetalles => Set<PagoDetalle>();
}

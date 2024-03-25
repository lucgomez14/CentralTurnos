using CentralTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace CentralTurnos.Data
{
    public class DBTurnosContext : DbContext
    {
        public DBTurnosContext(DbContextOptions<DBTurnosContext> options) : base(options)
        { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}

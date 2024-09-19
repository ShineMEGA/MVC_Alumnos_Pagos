using Microsoft.EntityFrameworkCore;
using AlumnosPagosApp.Models;

namespace AlumnosPagosApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets (Tablas)
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Alumno>()
        //        .HasMany(a => a.Pagos)
        //        .WithOne(p => p.Alumno)
        //        .HasForeignKey(p => p.AlumnoID);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Clinic.Data.Persistent.Ef.Context
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ClinicApp_DB;User Id=sa;Password=12345678@;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Reception> Reception { get; set; }
        public DbSet<PatientInfo> PatientInfo { get; set; }
        public DbSet<PatientReport> PatientReport { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}

using DrMediScanV5.Models.Data;
using DrMediScanV6.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DrMediScanV6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Appointment> Appointment { get; set; } = default;
        public DbSet<Review> Review { get; set; } = default;
        public DbSet<Clinic> Clinic { get; set; } = default;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Clinic>().HasData(
                new Clinic { Id = 1, ClinicName = "Jeff's Scan World", AvailableDate = DateTime.Parse("2023-10-25 12:30:00"), AverageRate = 8, IfAvailable = true },
                new Clinic { Id = 2, ClinicName = "MediScan Family Clinic", AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 9, IfAvailable = true },
                new Clinic { Id = 3, ClinicName = "Louis Clinic", AvailableDate = DateTime.Parse("2023-10-27 9:30:00"), AverageRate = 6, IfAvailable = true },
                new Clinic { Id = 4, ClinicName = "FamilyWarming Clinic", AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 7, IfAvailable = true },
                new Clinic { Id = 5, ClinicName = "Monash Private Clinic", AvailableDate = DateTime.Parse("2023-10-27 14:00:00"), AverageRate = 9, IfAvailable = true }
            );
        }

    }
}
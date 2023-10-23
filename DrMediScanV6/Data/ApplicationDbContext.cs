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
                new Clinic { Id = 1, ClinicName = "Jeff's Scan World", AvailableDate = DateTime.Parse("2023-10-25 12:30:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 2, ClinicName = "MediScan Family Clinic", AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 3, ClinicName = "Louis Clinic", AvailableDate = DateTime.Parse("2023-10-27 9:30:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 4, ClinicName = "FamilyWarming Clinic", AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 5, ClinicName = "Monash Private Clinic", AvailableDate = DateTime.Parse("2023-10-27 14:00:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 6, ClinicName = "Carlton MRI/CT Clinic", AvailableDate = DateTime.Parse("2023-10-27 15:00:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 7, ClinicName = "NeuroFocus Imaging Clinic", AvailableDate = DateTime.Parse("2023-11-02 9:30:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 8, ClinicName = "InnerView Radiology Services", AvailableDate = DateTime.Parse("2023-11-02 14:45:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 9, ClinicName = "ProScan MRI Clinic", AvailableDate = DateTime.Parse("2023-11-03 10:00:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 10, ClinicName = "InnerDetail MRI Solutions", AvailableDate = DateTime.Parse("2023-11-03 9:00:00"), AverageRate = 0, IfAvailable = true }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    UserName = "abelpan2022@gmail.com",
                    PatientFirstName = "abel",
                    PatientLastName = "pan",
                    PatientPhoneNo = "0412321234",
                    ClinicId = 1,
                    ClinicName = "Jeff's Scan World",
                    AppointmentTime = DateTime.Now.AddDays(-1),
                    IfCompleted = true
                },
                new Appointment
                {
                    Id = 2,
                    UserName = "abelpan2022@gmail.com",
                    PatientFirstName = "abel",
                    PatientLastName = "pan",
                    PatientPhoneNo = "0412321234",
                    ClinicId = 1,
                    ClinicName = "Jeff's Scan World",
                    AppointmentTime = DateTime.Now.AddDays(-2),
                    IfCompleted = true
                }
            );
            

        /*modelBuilder.Entity<Review>().Property(r => r.Score).HasPrecision(6, 2);
        modelBuilder.Entity<Clinic>().Property(r => r.AverageRate).HasPrecision(6, 2);
        modelBuilder.Entity<SelectedClinic>().Property(r => r.AverageRate).HasPrecision(6, 2);*/


    }

    }
}
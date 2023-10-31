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
                new Clinic { Id = 1, ClinicName = "Jeff's Scan World", Latitude = -37.8136, Longitude = 145.11462, AvailableDate = DateTime.Parse("2023-10-25 12:30:00"), AverageRate = 0, IfAvailable = true },
                new Clinic { Id = 2, ClinicName = "MediScan Family Clinic", Latitude = -37.9090, Longitude = 145.1133, AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 7.6, IfAvailable = true },
                new Clinic { Id = 3, ClinicName = "Louis Clinic", Latitude = -37.90385043378162, Longitude = 145.1069008377784, AvailableDate = DateTime.Parse("2023-10-27 9:30:00"), AverageRate = 7.7, IfAvailable = true },
                new Clinic { Id = 4, ClinicName = "FamilyWarming Clinic", Latitude = -37.851512248323765, Longitude = 145.00678905311517, AvailableDate = DateTime.Parse("2023-10-31 10:15:00"), AverageRate = 9.2, IfAvailable = true },
                new Clinic { Id = 5, ClinicName = "Monash Private Clinic", Latitude = -37.920757140325136, Longitude = 145.12112606415644, AvailableDate = DateTime.Parse("2023-10-27 14:00:00"), AverageRate = 6.3, IfAvailable = true },
                new Clinic { Id = 6, ClinicName = "Carlton MRI/CT Clinic", Latitude = -37.957125510635, Longitude = 145.07206709932336, AvailableDate = DateTime.Parse("2023-10-27 15:00:00"), AverageRate = 7.3, IfAvailable = true },
                new Clinic {Id = 7, ClinicName = "NeuroFocus Imaging Clinic", Latitude = -37.833702881337224, Longitude = 144.95433065062537, AvailableDate = DateTime.Parse("2023-11-02 9:30:00"), AverageRate = 5.8, IfAvailable = true },
                new Clinic {Id = 8, ClinicName = "InnerView Radiology Services", Latitude = -37.823538839677184, Longitude = 145.03830568676884, AvailableDate = DateTime.Parse("2023-11-02 14:45:00"), AverageRate = 8.5, IfAvailable = true },
                new Clinic {Id = 9, ClinicName = "ProScan MRI Clinic", Latitude = -37.87665564471766, Longitude = 145.12110690339233, AvailableDate = DateTime.Parse("2023-11-03 10:00:00"), AverageRate = 6.6, IfAvailable = true },
                new Clinic {Id = 10, ClinicName = "InnerDetail MRI Solutions", Latitude = -37.952469226632616, Longitude = 145.15023333415897, AvailableDate = DateTime.Parse("2023-11-03 9:00:00"), AverageRate = 7.0, IfAvailable = true }
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
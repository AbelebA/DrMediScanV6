﻿// <auto-generated />
using System;
using DrMediScanV6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231031042952_deletefortest36")]
    partial class deletefortest36
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DrMediScanV6.Models.Data.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IfCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("PatientFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Appointment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentTime = new DateTime(2023, 10, 30, 15, 29, 52, 682, DateTimeKind.Local).AddTicks(2141),
                            ClinicId = 1,
                            ClinicName = "Jeff's Scan World",
                            IfCompleted = true,
                            PatientFirstName = "abel",
                            PatientLastName = "pan",
                            PatientPhoneNo = "0412321234",
                            UserName = "abelpan2022@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2023, 10, 29, 15, 29, 52, 682, DateTimeKind.Local).AddTicks(2185),
                            ClinicId = 1,
                            ClinicName = "Jeff's Scan World",
                            IfCompleted = true,
                            PatientFirstName = "abel",
                            PatientLastName = "pan",
                            PatientPhoneNo = "0412321234",
                            UserName = "abelpan2022@gmail.com"
                        });
                });

            modelBuilder.Entity("DrMediScanV6.Models.Data.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AvailableDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("AverageRate")
                        .HasColumnType("float");

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IfAvailable")
                        .HasColumnType("bit");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Clinic");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableDate = new DateTime(2023, 10, 25, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 0.0,
                            ClinicName = "Jeff's Scan World",
                            IfAvailable = true,
                            Latitude = -37.813600000000001,
                            Longitude = 145.11462
                        },
                        new
                        {
                            Id = 2,
                            AvailableDate = new DateTime(2023, 10, 31, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 7.5999999999999996,
                            ClinicName = "MediScan Family Clinic",
                            IfAvailable = true,
                            Latitude = -37.908999999999999,
                            Longitude = 145.11330000000001
                        },
                        new
                        {
                            Id = 3,
                            AvailableDate = new DateTime(2023, 10, 27, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 7.7000000000000002,
                            ClinicName = "Louis Clinic",
                            IfAvailable = true,
                            Latitude = -37.903850433781621,
                            Longitude = 145.1069008377784
                        },
                        new
                        {
                            Id = 4,
                            AvailableDate = new DateTime(2023, 10, 31, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 9.1999999999999993,
                            ClinicName = "FamilyWarming Clinic",
                            IfAvailable = true,
                            Latitude = -37.851512248323765,
                            Longitude = 145.00678905311517
                        },
                        new
                        {
                            Id = 5,
                            AvailableDate = new DateTime(2023, 10, 27, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 6.2999999999999998,
                            ClinicName = "Monash Private Clinic",
                            IfAvailable = true,
                            Latitude = -37.920757140325136,
                            Longitude = 145.12112606415644
                        },
                        new
                        {
                            Id = 6,
                            AvailableDate = new DateTime(2023, 10, 27, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 7.2999999999999998,
                            ClinicName = "Carlton MRI/CT Clinic",
                            IfAvailable = true,
                            Latitude = -37.957125510635002,
                            Longitude = 145.07206709932336
                        },
                        new
                        {
                            Id = 7,
                            AvailableDate = new DateTime(2023, 11, 2, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 5.7999999999999998,
                            ClinicName = "NeuroFocus Imaging Clinic",
                            IfAvailable = true,
                            Latitude = -37.833702881337224,
                            Longitude = 144.95433065062537
                        },
                        new
                        {
                            Id = 8,
                            AvailableDate = new DateTime(2023, 11, 2, 14, 45, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 8.5,
                            ClinicName = "InnerView Radiology Services",
                            IfAvailable = true,
                            Latitude = -37.823538839677184,
                            Longitude = 145.03830568676884
                        },
                        new
                        {
                            Id = 9,
                            AvailableDate = new DateTime(2023, 11, 3, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 6.5999999999999996,
                            ClinicName = "ProScan MRI Clinic",
                            IfAvailable = true,
                            Latitude = -37.876655644717658,
                            Longitude = 145.12110690339233
                        },
                        new
                        {
                            Id = 10,
                            AvailableDate = new DateTime(2023, 11, 3, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            AverageRate = 7.0,
                            ClinicName = "InnerDetail MRI Solutions",
                            IfAvailable = true,
                            Latitude = -37.952469226632616,
                            Longitude = 145.15023333415897
                        });
                });

            modelBuilder.Entity("DrMediScanV6.Models.Data.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

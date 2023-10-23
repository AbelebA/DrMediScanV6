using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AppointmentTime", "ClinicId", "ClinicName", "IfCompleted", "PatientFirstName", "PatientLastName", "PatientPhoneNo", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 22, 16, 45, 12, 159, DateTimeKind.Local).AddTicks(3699), 1, "Jeff's Scan World", true, "abel", "pan", "0412321234", "abelpan2022@gmail.com" },
                    { 2, new DateTime(2023, 10, 21, 16, 45, 12, 159, DateTimeKind.Local).AddTicks(3761), 1, "Jeff's Scan World", true, "abel", "pan", "0412321234", "abelpan2022@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AppointmentTime", "ClinicId", "ClinicName", "IfCompleted", "PatientFirstName", "PatientLastName", "PatientPhoneNo", "UserName" },
                values: new object[] { 99, new DateTime(2023, 10, 22, 16, 42, 12, 996, DateTimeKind.Local).AddTicks(8254), 1, "Jeff's Scan World", true, "abel", "pan", "0412321234", "abelpan2022@gmail.com" });
        }
    }
}

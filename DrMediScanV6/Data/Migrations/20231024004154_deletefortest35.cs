using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 23, 11, 41, 53, 971, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 11, 41, 53, 971, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 23, 0, 57, 58, 818, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 0, 57, 58, 818, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 8.0);
        }
    }
}

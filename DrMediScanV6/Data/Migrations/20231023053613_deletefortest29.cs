using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 99,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 16, 36, 13, 5, DateTimeKind.Local).AddTicks(568));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 99,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 16, 32, 54, 346, DateTimeKind.Local).AddTicks(6087));
        }
    }
}

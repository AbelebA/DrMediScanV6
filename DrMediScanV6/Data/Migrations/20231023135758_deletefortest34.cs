using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3,
                column: "AverageRate",
                value: 7.7000000000000002);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 23, 19, 45, 776, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 21, 23, 19, 45, 776, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRate",
                value: 0.0);
        }
    }
}

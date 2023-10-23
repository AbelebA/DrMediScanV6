using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "AppointmentTime", "ClinicId", "ClinicName", "IfCompleted", "PatientFirstName", "PatientLastName", "PatientPhoneNo", "UserName" },
                values: new object[] { 99, new DateTime(2023, 10, 22, 16, 32, 54, 346, DateTimeKind.Local).AddTicks(6087), 1, "Jeff's Scan World", true, "abel", "pan", "0412321234", "abelpan2022@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                column: "AverageRate",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableDate", "AverageRate" },
                values: new object[] { new DateTime(2023, 11, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                column: "AverageRate",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRate",
                value: 6.2000000000000002);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                column: "AverageRate",
                value: 7.4000000000000004);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                column: "AverageRate",
                value: 9.8000000000000007);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                column: "AverageRate",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                column: "AverageRate",
                value: 6.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                column: "AverageRate",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                column: "AverageRate",
                value: 4.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableDate", "AverageRate" },
                values: new object[] { new DateTime(2023, 10, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 7.5 });
        }
    }
}

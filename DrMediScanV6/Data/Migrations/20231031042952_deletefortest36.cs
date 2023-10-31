using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Clinic",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Clinic",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 30, 15, 29, 52, 682, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 29, 15, 29, 52, 682, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.813600000000001, 145.11462 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.908999999999999, 145.11330000000001 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.903850433781621, 145.1069008377784 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.851512248323765, 145.00678905311517 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.920757140325136, 145.12112606415644 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.957125510635002, 145.07206709932336 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.833702881337224, 144.95433065062537 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.823538839677184, 145.03830568676884 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.876655644717658, 145.12110690339233 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { -37.952469226632616, 145.15023333415897 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Clinic");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Clinic");

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
        }
    }
}

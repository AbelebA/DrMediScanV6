using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clinic");

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
                keyValue: 1,
                column: "AverageRate",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                column: "AverageRate",
                value: 7.5999999999999996);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                column: "AverageRate",
                value: 9.1999999999999993);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                column: "AverageRate",
                value: 6.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                column: "AverageRate",
                value: 7.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                column: "AverageRate",
                value: 5.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                column: "AverageRate",
                value: 8.5);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                column: "AverageRate",
                value: 6.5999999999999996);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                column: "AverageRate",
                value: 7.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clinic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 22, 22, 36, 41, 250, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentTime",
                value: new DateTime(2023, 10, 21, 22, 36, 41, 250, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "Address",
                value: null);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AverageRate" },
                values: new object[] { null, 0.0 });
        }
    }
}

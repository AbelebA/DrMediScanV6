using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClincId",
                table: "Review");

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Review",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ClincName",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AverageRate",
                table: "Clinic",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 8m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                column: "AverageRate",
                value: 9m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRate",
                value: 6m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                column: "AverageRate",
                value: 7m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                column: "AverageRate",
                value: 9m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                column: "AverageRate",
                value: 7m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                column: "AverageRate",
                value: 6m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                column: "AverageRate",
                value: 5m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableDate", "AverageRate" },
                values: new object[] { new DateTime(2023, 11, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 4m });

            migrationBuilder.InsertData(
                table: "Clinic",
                columns: new[] { "Id", "AvailableDate", "AverageRate", "ClinicName", "IfAvailable" },
                values: new object[] { 10, new DateTime(2023, 10, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 7m, "InnerDetail MRI Solutions", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ClincName",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Review",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "ClincId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AverageRate",
                table: "Clinic",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 1,
                column: "AverageRate",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 2,
                column: "AverageRate",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRate",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 4,
                column: "AverageRate",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 5,
                column: "AverageRate",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6,
                column: "AverageRate",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7,
                column: "AverageRate",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8,
                column: "AverageRate",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableDate", "AverageRate" },
                values: new object[] { new DateTime(2023, 10, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 4 });
        }
    }
}

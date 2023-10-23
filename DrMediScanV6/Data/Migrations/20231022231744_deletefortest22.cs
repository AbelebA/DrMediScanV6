using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clinic",
                columns: new[] { "Id", "AvailableDate", "AverageRate", "ClinicName", "IfAvailable" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 10, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 7, "Carlton MRI/CT Clinic", true },
                    { 7, new DateTime(2023, 11, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 6, "NeuroFocus Imaging Clinic", true },
                    { 8, new DateTime(2023, 11, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 5, "InnerView Radiology Services", true },
                    { 9, new DateTime(2023, 10, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, "ProScan MRI Clinic", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}

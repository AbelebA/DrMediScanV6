using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Review",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "AverageRate",
                table: "Clinic",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                column: "AverageRate",
                value: 7.5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Review",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "AverageRate",
                table: "Clinic",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
                column: "AverageRate",
                value: 4m);

            migrationBuilder.UpdateData(
                table: "Clinic",
                keyColumn: "Id",
                keyValue: 10,
                column: "AverageRate",
                value: 7m);
        }
    }
}

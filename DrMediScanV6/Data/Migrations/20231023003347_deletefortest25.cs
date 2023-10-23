using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrMediScanV6.Data.Migrations
{
    /// <inheritdoc />
    public partial class deletefortest25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClincName",
                table: "Review",
                newName: "ClinicName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClinicName",
                table: "Review",
                newName: "ClincName");
        }
    }
}

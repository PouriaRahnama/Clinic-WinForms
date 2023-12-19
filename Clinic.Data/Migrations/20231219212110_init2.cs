using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientReport",
                table: "PatientReport");

            migrationBuilder.DropIndex(
                name: "IX_PatientReport_ReceptionId",
                table: "PatientReport");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PatientReport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientReport",
                table: "PatientReport",
                column: "ReceptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientReport",
                table: "PatientReport");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PatientReport",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientReport",
                table: "PatientReport",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PatientReport_ReceptionId",
                table: "PatientReport",
                column: "ReceptionId",
                unique: true);
        }
    }
}

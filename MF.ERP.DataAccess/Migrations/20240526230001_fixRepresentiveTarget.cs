using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.ERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixRepresentiveTarget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TartgetTypeId",
                table: "RepresintiveTarges");

            migrationBuilder.RenameColumn(
                name: "TartgetTypeId",
                table: "RepresintiveTarges",
                newName: "TargetTypeId");

            migrationBuilder.RenameColumn(
                name: "StartTartgetTime",
                table: "RepresintiveTarges",
                newName: "StartTargetTime");

            migrationBuilder.RenameColumn(
                name: "EndTartgetTime",
                table: "RepresintiveTarges",
                newName: "EndTargetTime");

            migrationBuilder.RenameIndex(
                name: "IX_RepresintiveTarges_TartgetTypeId",
                table: "RepresintiveTarges",
                newName: "IX_RepresintiveTarges_TargetTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TargetTypeId",
                table: "RepresintiveTarges",
                column: "TargetTypeId",
                principalTable: "TargetTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TargetTypeId",
                table: "RepresintiveTarges");

            migrationBuilder.RenameColumn(
                name: "TargetTypeId",
                table: "RepresintiveTarges",
                newName: "TartgetTypeId");

            migrationBuilder.RenameColumn(
                name: "StartTargetTime",
                table: "RepresintiveTarges",
                newName: "StartTartgetTime");

            migrationBuilder.RenameColumn(
                name: "EndTargetTime",
                table: "RepresintiveTarges",
                newName: "EndTartgetTime");

            migrationBuilder.RenameIndex(
                name: "IX_RepresintiveTarges_TargetTypeId",
                table: "RepresintiveTarges",
                newName: "IX_RepresintiveTarges_TartgetTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TartgetTypeId",
                table: "RepresintiveTarges",
                column: "TartgetTypeId",
                principalTable: "TargetTypes",
                principalColumn: "Id");
        }
    }
}

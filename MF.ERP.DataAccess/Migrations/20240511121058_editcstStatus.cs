using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.ERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class editcstStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Status_StatusId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_StatusId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "LastStatusId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LastStatusId",
                table: "Customers",
                column: "LastStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerStatus_LastStatusId",
                table: "Customers",
                column: "LastStatusId",
                principalTable: "CustomerStatus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerStatus_LastStatusId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_LastStatusId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastStatusId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StatusId",
                table: "Customers",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Status_StatusId",
                table: "Customers",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

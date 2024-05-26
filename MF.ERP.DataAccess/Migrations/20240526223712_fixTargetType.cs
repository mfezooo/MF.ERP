using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.ERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixTargetType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepresintiveTarges_TartgetTyps_TartgetTypeId",
                table: "RepresintiveTarges");

            migrationBuilder.DropTable(
                name: "TartgetTyps");

            migrationBuilder.CreateTable(
                name: "TargetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifyCount = table.Column<int>(type: "int", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TartgetTypeId",
                table: "RepresintiveTarges",
                column: "TartgetTypeId",
                principalTable: "TargetTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepresintiveTarges_TargetTypes_TartgetTypeId",
                table: "RepresintiveTarges");

            migrationBuilder.DropTable(
                name: "TargetTypes");

            migrationBuilder.CreateTable(
                name: "TartgetTyps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifyCount = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TartgetTyps", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RepresintiveTarges_TartgetTyps_TartgetTypeId",
                table: "RepresintiveTarges",
                column: "TartgetTypeId",
                principalTable: "TartgetTyps",
                principalColumn: "Id");
        }
    }
}

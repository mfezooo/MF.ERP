using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MF.ERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class areaGov : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Governmens_GovernmentId",
                table: "Areas");

            migrationBuilder.DropTable(
                name: "TeamAres");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TeamTarges");

            migrationBuilder.AlterColumn<int>(
                name: "GovernmentId",
                table: "Areas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IndustryId",
                table: "Questions",
                column: "IndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Governmens_GovernmentId",
                table: "Areas",
                column: "GovernmentId",
                principalTable: "Governmens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Industries_IndustryId",
                table: "Questions",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Governmens_GovernmentId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Industries_IndustryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_IndustryId",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "GovernmentId",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TeamTarges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TartgetTypeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountAtEndOfDuration = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTartgetTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifyCount = table.Column<int>(type: "int", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    StartTartgetTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTarges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamTarges_TartgetTyps_TartgetTypeId",
                        column: x => x.TartgetTypeId,
                        principalTable: "TartgetTyps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TartgetTypeId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifyCount = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    TartgetTypeId = table.Column<int>(type: "int", nullable: true),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_TeamTarges_TartgetTypeId1",
                        column: x => x.TartgetTypeId1,
                        principalTable: "TeamTarges",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamAres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifyCount = table.Column<int>(type: "int", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamAres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamAres_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamAres_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamAres_AreaId",
                table: "TeamAres",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamAres_TeamId",
                table: "TeamAres",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TartgetTypeId1",
                table: "Teams",
                column: "TartgetTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamTarges_TartgetTypeId",
                table: "TeamTarges",
                column: "TartgetTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Governmens_GovernmentId",
                table: "Areas",
                column: "GovernmentId",
                principalTable: "Governmens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

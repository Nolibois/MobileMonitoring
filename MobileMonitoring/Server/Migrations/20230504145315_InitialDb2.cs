using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobileMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThresholdId",
                table: "Tiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Threshold",
                columns: table => new
                {
                    IdThreshold = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThresholdWarnings = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threshold", x => x.IdThreshold);
                });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 4, 16, 53, 15, 697, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.InsertData(
                table: "ModulesDynamics",
                columns: new[] { "IdModule", "Name" },
                values: new object[] { 4, "General Ledger" });

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 1,
                column: "CompanyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 2,
                column: "CompanyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 3,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 4,
                column: "NbSequence",
                value: "USMF-8249758");

            migrationBuilder.InsertData(
                table: "Threshold",
                columns: new[] { "IdThreshold", "ThresholdWarnings" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 0 },
                    { 3, 0 },
                    { 4, 0 },
                    { 5, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "IdTile",
                keyValue: 1,
                column: "ThresholdId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "IdTile",
                keyValue: 2,
                column: "ThresholdId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "IdTile",
                keyValue: 3,
                column: "ThresholdId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "IdTile",
                keyValue: 4,
                column: "ThresholdId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tiles",
                keyColumn: "IdTile",
                keyValue: 5,
                column: "ThresholdId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Tiles_ThresholdId",
                table: "Tiles",
                column: "ThresholdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tiles_Threshold_ThresholdId",
                table: "Tiles",
                column: "ThresholdId",
                principalTable: "Threshold",
                principalColumn: "IdThreshold",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tiles_Threshold_ThresholdId",
                table: "Tiles");

            migrationBuilder.DropTable(
                name: "Threshold");

            migrationBuilder.DropIndex(
                name: "IX_Tiles_ThresholdId",
                table: "Tiles");

            migrationBuilder.DeleteData(
                table: "ModulesDynamics",
                keyColumn: "IdModule",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ThresholdId",
                table: "Tiles");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 19, 43, 10, 283, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 1,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 2,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 3,
                column: "CompanyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "NumberSequences",
                keyColumn: "IdNumberSequence",
                keyValue: 4,
                column: "NbSequence",
                value: "UMF-8249758");
        }
    }
}

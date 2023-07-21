using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class addHandleTableDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Handles",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdCleanup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Handles_Cleanups_IdCleanup",
                        column: x => x.IdCleanup,
                        principalTable: "Cleanups",
                        principalColumn: "IdCleanup");
                    table.ForeignKey(
                        name: "FK_Handles_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                });

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 7, 20, 20, 7, 52, 354, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.CreateIndex(
                name: "IX_Handles_IdCleanup",
                table: "Handles",
                column: "IdCleanup");

            migrationBuilder.CreateIndex(
                name: "IX_Handles_IdUser",
                table: "Handles",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Handles");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 17, 14, 11, 52, 345, DateTimeKind.Local).AddTicks(8711));
        }
    }
}

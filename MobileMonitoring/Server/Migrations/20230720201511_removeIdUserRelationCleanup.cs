using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class removeIdUserRelationCleanup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 7, 20, 22, 15, 11, 6, DateTimeKind.Local).AddTicks(5072));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "IdEmail",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 7, 20, 20, 7, 52, 354, DateTimeKind.Local).AddTicks(9690));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobileMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlertTypes",
                columns: table => new
                {
                    IdAlertType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertTypes", x => x.IdAlertType);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    IdCompany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.IdCompany);
                });

            migrationBuilder.CreateTable(
                name: "EmailStatuses",
                columns: table => new
                {
                    IdEmailStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailStatuses", x => x.IdEmailStatus);
                });

            migrationBuilder.CreateTable(
                name: "ModulesDynamics",
                columns: table => new
                {
                    IdModule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesDynamics", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "NumberSequences",
                columns: table => new
                {
                    IdNumberSequence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    NbSequence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InUse = table.Column<bool>(type: "bit", nullable: false),
                    Remaining = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberSequences", x => x.IdNumberSequence);
                    table.ForeignKey(
                        name: "FK_NumberSequences_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DynamicsId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tiles",
                columns: table => new
                {
                    IdTile = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<double>(type: "float", nullable: true),
                    Alert = table.Column<bool>(type: "bit", nullable: false),
                    ModuleDynamicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiles", x => x.IdTile);
                    table.ForeignKey(
                        name: "FK_Tiles_ModulesDynamics_ModuleDynamicsId",
                        column: x => x.ModuleDynamicsId,
                        principalTable: "ModulesDynamics",
                        principalColumn: "IdModule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    IdEmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSenderId = table.Column<int>(type: "int", nullable: false),
                    UserReceiverId = table.Column<int>(type: "int", nullable: false),
                    EmailStatusId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.IdEmail);
                    table.ForeignKey(
                        name: "FK_Emails_EmailStatuses_EmailStatusId",
                        column: x => x.EmailStatusId,
                        principalTable: "EmailStatuses",
                        principalColumn: "IdEmailStatus");
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserReceiverId",
                        column: x => x.UserReceiverId,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserSenderId",
                        column: x => x.UserSenderId,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateTable(
                name: "Cleanups",
                columns: table => new
                {
                    IdCleanup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TileId = table.Column<int>(type: "int", nullable: false),
                    AlertTypeId = table.Column<int>(type: "int", nullable: false),
                    CleanupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlertCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cleanups", x => x.IdCleanup);
                    table.ForeignKey(
                        name: "FK_Cleanups_AlertTypes_AlertTypeId",
                        column: x => x.AlertTypeId,
                        principalTable: "AlertTypes",
                        principalColumn: "IdAlertType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cleanups_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "IdTile",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cleanups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AlertTypes",
                columns: new[] { "IdAlertType", "Name" },
                values: new object[,]
                {
                    { 1, "Notifications" },
                    { 2, "Batch history custom" },
                    { 3, "Batch database" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "IdCompany", "Name" },
                values: new object[,]
                {
                    { 1, "FR01" },
                    { 2, "DAT" },
                    { 3, "USMF" }
                });

            migrationBuilder.InsertData(
                table: "EmailStatuses",
                columns: new[] { "IdEmailStatus", "Name" },
                values: new object[,]
                {
                    { 1, "Send" },
                    { 2, "Pending" },
                    { 3, "Unsend" }
                });

            migrationBuilder.InsertData(
                table: "ModulesDynamics",
                columns: new[] { "IdModule", "Name" },
                values: new object[,]
                {
                    { 1, "System administration" },
                    { 2, "Unsent emails" },
                    { 3, "Due Number sequences" }
                });

            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "IdNumberSequence", "CompanyId", "InUse", "NbSequence", "Remaining" },
                values: new object[,]
                {
                    { 1, 1, false, "DAT-0000001", 100 },
                    { 2, 1, true, "DAT-4585654", 51 },
                    { 3, 2, true, "FRSI-74023465", 75 },
                    { 4, 3, true, "UMF-8249758", 8 }
                });

            migrationBuilder.InsertData(
                table: "Tiles",
                columns: new[] { "IdTile", "Alert", "ModuleDynamicsId", "Name", "Number" },
                values: new object[,]
                {
                    { 1, false, 1, "Notifications cleanup", 15.0 },
                    { 2, true, 1, "Cleanup batch history custom", 25.0 },
                    { 3, false, 1, "Database Cleanup", 735.60000000000002 },
                    { 4, true, 2, "Unsent emails", 452.0 },
                    { 5, false, 3, "Due Number sequences", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "CompanyId", "DynamicsId", "FullName" },
                values: new object[,]
                {
                    { 1, 1, 6452154, "Gwendoline Pimprenelle" },
                    { 2, 1, 2156485, "Pablo De La Rosa" },
                    { 3, 3, 9876543, "Bob the sponge" }
                });

            migrationBuilder.InsertData(
                table: "Cleanups",
                columns: new[] { "IdCleanup", "AlertCreationDate", "AlertTypeId", "CleanupDate", "TileId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 8, 4, 0, 56, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 10, 5, 11, 24, 15, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2014, 3, 28, 9, 42, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 4, 14, 1, 12, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, new DateTime(2017, 6, 7, 12, 56, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 12, 31, 11, 55, 15, 0, DateTimeKind.Unspecified), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "IdEmail", "CreationDate", "EmailStatusId", "Subject", "UserReceiverId", "UserSenderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 15, 19, 43, 10, 283, DateTimeKind.Local).AddTicks(3720), 1, "Review task KJB000012", 2, 1 },
                    { 2, new DateTime(2018, 12, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "FR:Review task KJB000012", 1, 2 },
                    { 3, new DateTime(2019, 2, 17, 20, 15, 43, 0, DateTimeKind.Unspecified), 3, "What's taht Task KJB000012 ??", 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cleanups_AlertTypeId",
                table: "Cleanups",
                column: "AlertTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cleanups_TileId",
                table: "Cleanups",
                column: "TileId");

            migrationBuilder.CreateIndex(
                name: "IX_Cleanups_UserId",
                table: "Cleanups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmailStatusId",
                table: "Emails",
                column: "EmailStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserReceiverId",
                table: "Emails",
                column: "UserReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserSenderId",
                table: "Emails",
                column: "UserSenderId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberSequences_CompanyId",
                table: "NumberSequences",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiles_ModuleDynamicsId",
                table: "Tiles",
                column: "ModuleDynamicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cleanups");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "NumberSequences");

            migrationBuilder.DropTable(
                name: "AlertTypes");

            migrationBuilder.DropTable(
                name: "Tiles");

            migrationBuilder.DropTable(
                name: "EmailStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ModulesDynamics");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}

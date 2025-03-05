using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lupy.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Pilot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLINIC",
                columns: table => new
                {
                    ID_CLINIC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(25)", unicode: false, maxLength: 25, nullable: false),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLINIC", x => x.ID_CLINIC);
                });

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VACCINE",
                columns: table => new
                {
                    ID_VACCINE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EXPIRATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_CLINIC = table.Column<int>(type: "int", nullable: false),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VACCINE", x => x.ID_VACCINE);
                    table.ForeignKey(
                        name: "FK_VACCINE_CLINIC",
                        column: x => x.ID_CLINIC,
                        principalTable: "CLINIC",
                        principalColumn: "ID_CLINIC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    ID_USER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CELLPHONE = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ID_ROLE = table.Column<int>(type: "int", nullable: false),
                    CLINIC_ID = table.Column<int>(type: "int", nullable: false),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.ID_USER);
                    table.ForeignKey(
                        name: "FK_USERS_CLINIC_CLINIC_ID",
                        column: x => x.CLINIC_ID,
                        principalTable: "CLINIC",
                        principalColumn: "ID_CLINIC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USERS_ROLES_ID_ROLE",
                        column: x => x.ID_ROLE,
                        principalTable: "ROLES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PET",
                columns: table => new
                {
                    ID_PET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    ID_TUTOR = table.Column<int>(type: "int", nullable: false),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PET", x => x.ID_PET);
                    table.ForeignKey(
                        name: "FK_PET_USERS_ID_TUTOR",
                        column: x => x.ID_TUTOR,
                        principalTable: "USERS",
                        principalColumn: "ID_USER",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VACCINE_PET",
                columns: table => new
                {
                    ID_VACCINE_PET = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_VACCINE = table.Column<int>(type: "int", nullable: false),
                    ID_CLINIC = table.Column<int>(type: "int", nullable: false),
                    ID_PET = table.Column<int>(type: "int", nullable: false),
                    CREATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CREATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICATION_USER = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MODIFICATION_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VACCINE_PET", x => x.ID_VACCINE_PET);
                    table.ForeignKey(
                        name: "FK_VACCINEPET_PET",
                        column: x => x.ID_PET,
                        principalTable: "PET",
                        principalColumn: "ID_PET",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VACCINEPET_VACCINE",
                        column: x => x.ID_VACCINE,
                        principalTable: "VACCINE",
                        principalColumn: "ID_VACCINE");
                    table.ForeignKey(
                        name: "FK_VACCINE_PET_CLINIC",
                        column: x => x.ID_CLINIC,
                        principalTable: "CLINIC",
                        principalColumn: "ID_CLINIC");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PET_ID_TUTOR",
                table: "PET",
                column: "ID_TUTOR");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_CLINIC_ID",
                table: "USERS",
                column: "CLINIC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_ID_ROLE",
                table: "USERS",
                column: "ID_ROLE");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINE_ID_CLINIC",
                table: "VACCINE",
                column: "ID_CLINIC");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINE_PET_ID_CLINIC",
                table: "VACCINE_PET",
                column: "ID_CLINIC");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINE_PET_ID_PET",
                table: "VACCINE_PET",
                column: "ID_PET");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINE_PET_ID_VACCINE",
                table: "VACCINE_PET",
                column: "ID_VACCINE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VACCINE_PET");

            migrationBuilder.DropTable(
                name: "PET");

            migrationBuilder.DropTable(
                name: "VACCINE");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "CLINIC");

            migrationBuilder.DropTable(
                name: "ROLES");
        }
    }
}

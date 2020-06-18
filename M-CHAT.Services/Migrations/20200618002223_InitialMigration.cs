using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M_CHAT.Services.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentrosE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CentroEID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CuentaID = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    TutorID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Contrasenia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ninios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAT = table.Column<DateTime>(nullable: false),
                    UpdatedAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NinioID = table.Column<int>(nullable: false),
                    Nom_Comp = table.Column<string>(nullable: true),
                    CURP = table.Column<string>(nullable: true),
                    Fecha_nac = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    TutorID = table.Column<int>(nullable: false),
                    CentroEID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ninios_CentrosE_CentroEID",
                        column: x => x.CentroEID,
                        principalTable: "CentrosE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ninios_Tutores_TutorID",
                        column: x => x.TutorID,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ninios_CentroEID",
                table: "Ninios",
                column: "CentroEID");

            migrationBuilder.CreateIndex(
                name: "IX_Ninios_TutorID",
                table: "Ninios",
                column: "TutorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Ninios");

            migrationBuilder.DropTable(
                name: "CentrosE");

            migrationBuilder.DropTable(
                name: "Tutores");
        }
    }
}

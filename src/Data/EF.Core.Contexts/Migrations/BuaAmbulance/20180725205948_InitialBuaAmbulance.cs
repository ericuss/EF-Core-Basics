using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    public partial class InitialBuaAmbulance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambulances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whiners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AmbulanceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whiners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Whiners_Ambulances_AmbulanceId",
                        column: x => x.AmbulanceId,
                        principalTable: "Ambulances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Whiners_AmbulanceId",
                table: "Whiners",
                column: "AmbulanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Whiners");

            migrationBuilder.DropTable(
                name: "Ambulances");
        }
    }
}

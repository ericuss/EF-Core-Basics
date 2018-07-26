using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    public partial class add_family_to_whiners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "Whiners",
                nullable: false,
                defaultValue: "Moofia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "Ambulances",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 26, 16, 59, 47, 625, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 26, 12, 16, 55, 283, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 653, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("a09c1e14-d823-4281-926d-345299696beb"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 653, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("00d703f6-3b3e-450b-83c4-77f21d73bac4"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("29f56d90-852f-4a49-85d3-519924f12864"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("2b1b55de-8147-4863-b73b-069258142c1f"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("3ac3818f-22b3-4fb6-a5f3-4c5f5cb32fcf"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("3c2b99e2-94d0-422a-a15b-a86f05c1ced2"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("6ca9d288-d561-47bb-8ba3-f4c7a0edb519"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("76cfbb29-3f9f-4901-8da8-a107687664c1"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("a59795de-4df2-4914-b7f4-fcaf5893aae7"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("b43b48a1-6a01-4c00-b04e-f0768f108c34"),
                column: "Family",
                value: "Moofia");

            migrationBuilder.UpdateData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("dc2f768d-8eb9-4b3e-917b-b5384f86e8b2"),
                column: "Family",
                value: "Moofia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Family",
                table: "Whiners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "Ambulances",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 26, 12, 16, 55, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 26, 16, 59, 47, 625, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 311, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("a09c1e14-d823-4281-926d-345299696beb"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 311, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 16, 55, 312, DateTimeKind.Local));
        }
    }
}

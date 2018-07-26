using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    public partial class fix_id_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "Ambulances",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 26, 12, 16, 55, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 26, 12, 10, 6, 22, DateTimeKind.Local));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "Ambulances",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 26, 12, 10, 6, 22, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2018, 7, 26, 12, 16, 55, 283, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 53, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("a09c1e14-d823-4281-926d-345299696beb"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 53, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"),
                column: "EntryDate",
                value: new DateTime(2018, 7, 26, 12, 10, 6, 56, DateTimeKind.Local));
        }
    }
}

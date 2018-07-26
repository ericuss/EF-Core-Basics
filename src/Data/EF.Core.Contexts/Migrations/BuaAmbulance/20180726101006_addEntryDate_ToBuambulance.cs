using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    public partial class addEntryDate_ToBuambulance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("11610d8e-9f79-45d7-9cfc-fc80e2d44eaf"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("37c13f0a-db03-4732-a740-c5f57241482f"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("6f1c9fd1-b47c-4df3-af1b-d6a16541475f"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("717c411c-05a8-4bef-8537-f2d666349e56"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("9cee4b48-c425-438e-bde6-04db490dad3b"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("bdbfb19e-5719-4e38-b287-2117227e33da"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("c7c83b08-dc7e-4cc7-beaf-83f4d4ae8bb0"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("d2060902-12c1-49e5-be5a-fda55ad4a53a"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("da38fb3f-bbb6-4701-b50e-0a05de626fe1"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("e600cd73-a28d-4561-9f65-88c1d1d22ebb"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EntryDate",
                table: "Ambulances",
                nullable: false,
                defaultValue: new DateTime(2018, 7, 26, 12, 10, 6, 22, DateTimeKind.Local));

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

            migrationBuilder.InsertData(
                table: "Whiners",
                columns: new[] { "Id", "AmbulanceId", "Name" },
                values: new object[,]
                {
                    { new Guid("29f56d90-852f-4a49-85d3-519924f12864"), new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"), "Half & Half" },
                    { new Guid("a59795de-4df2-4914-b7f4-fcaf5893aae7"), new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"), "Leche" },
                    { new Guid("3ac3818f-22b3-4fb6-a5f3-4c5f5cb32fcf"), new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"), "Soya" },
                    { new Guid("3c2b99e2-94d0-422a-a15b-a86f05c1ced2"), new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"), "Choco" },
                    { new Guid("b43b48a1-6a01-4c00-b04e-f0768f108c34"), new Guid("a09c1e14-d823-4281-926d-345299696beb"), "Mozzarella" },
                    { new Guid("dc2f768d-8eb9-4b3e-917b-b5384f86e8b2"), new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"), "Latte" },
                    { new Guid("00d703f6-3b3e-450b-83c4-77f21d73bac4"), new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"), "Bulletto" },
                    { new Guid("6ca9d288-d561-47bb-8ba3-f4c7a0edb519"), new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), "Mou Mou" },
                    { new Guid("76cfbb29-3f9f-4901-8da8-a107687664c1"), new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"), "Strawberry Milk" },
                    { new Guid("2b1b55de-8147-4863-b73b-069258142c1f"), new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), "Miruku" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("00d703f6-3b3e-450b-83c4-77f21d73bac4"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("29f56d90-852f-4a49-85d3-519924f12864"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("2b1b55de-8147-4863-b73b-069258142c1f"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("3ac3818f-22b3-4fb6-a5f3-4c5f5cb32fcf"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("3c2b99e2-94d0-422a-a15b-a86f05c1ced2"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("6ca9d288-d561-47bb-8ba3-f4c7a0edb519"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("76cfbb29-3f9f-4901-8da8-a107687664c1"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("a59795de-4df2-4914-b7f4-fcaf5893aae7"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("b43b48a1-6a01-4c00-b04e-f0768f108c34"));

            migrationBuilder.DeleteData(
                table: "Whiners",
                keyColumn: "Id",
                keyValue: new Guid("dc2f768d-8eb9-4b3e-917b-b5384f86e8b2"));

            migrationBuilder.DropColumn(
                name: "EntryDate",
                table: "Ambulances");

            migrationBuilder.InsertData(
                table: "Whiners",
                columns: new[] { "Id", "AmbulanceId", "Name" },
                values: new object[,]
                {
                    { new Guid("e600cd73-a28d-4561-9f65-88c1d1d22ebb"), new Guid("a09c1e14-d823-4281-926d-345299696beb"), "Mozzarella" },
                    { new Guid("d2060902-12c1-49e5-be5a-fda55ad4a53a"), new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"), "Bulletto" },
                    { new Guid("6f1c9fd1-b47c-4df3-af1b-d6a16541475f"), new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"), "Latte" },
                    { new Guid("da38fb3f-bbb6-4701-b50e-0a05de626fe1"), new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"), "Strawberry Milk" },
                    { new Guid("717c411c-05a8-4bef-8537-f2d666349e56"), new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"), "Choco" },
                    { new Guid("bdbfb19e-5719-4e38-b287-2117227e33da"), new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"), "Soya" },
                    { new Guid("c7c83b08-dc7e-4cc7-beaf-83f4d4ae8bb0"), new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"), "Leche" },
                    { new Guid("37c13f0a-db03-4732-a740-c5f57241482f"), new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"), "Half & Half" },
                    { new Guid("11610d8e-9f79-45d7-9cfc-fc80e2d44eaf"), new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), "Mou Mou" },
                    { new Guid("9cee4b48-c425-438e-bde6-04db490dad3b"), new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), "Miruku" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    public partial class addingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ambulances",
                column: "Id",
                values: new object[]
                {
                    new Guid("a09c1e14-d823-4281-926d-345299696beb"),
                    new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"),
                    new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"),
                    new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"),
                    new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"),
                    new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"),
                    new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"),
                    new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"),
                    new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7")
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("a09c1e14-d823-4281-926d-345299696beb"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"));

            migrationBuilder.DeleteData(
                table: "Ambulances",
                keyColumn: "Id",
                keyValue: new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"));
        }
    }
}

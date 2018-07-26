﻿// <auto-generated />
using System;
using EF.Core.Contexts.Contexts;
using EF.Core.Entities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.Core.Contexts.Migrations.BuaAmbulance
{
    [DbContext(typeof(BuaAmbulanceContext))]
    partial class BuaAmbulanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Core.Entities.BuaAmbulance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 7, 26, 16, 59, 47, 625, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.ToTable("Ambulances");

                    b.HasData(
                        new { Id = new Guid("a09c1e14-d823-4281-926d-345299696beb"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 653, DateTimeKind.Local) },
                        new { Id = new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 653, DateTimeKind.Local) },
                        new { Id = new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) },
                        new { Id = new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), EntryDate = new DateTime(2018, 7, 26, 16, 59, 47, 654, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("EF.Core.Entities.Whiner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AmbulanceId");

                    b.Property<string>("Family")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Moofia");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AmbulanceId");

                    b.ToTable("Whiners");

                    b.HasData(
                        new { Id = new Guid("b43b48a1-6a01-4c00-b04e-f0768f108c34"), AmbulanceId = new Guid("a09c1e14-d823-4281-926d-345299696beb"), Family = "Moofia", Name = "Mozzarella" },
                        new { Id = new Guid("00d703f6-3b3e-450b-83c4-77f21d73bac4"), AmbulanceId = new Guid("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"), Family = "Moofia", Name = "Bulletto" },
                        new { Id = new Guid("dc2f768d-8eb9-4b3e-917b-b5384f86e8b2"), AmbulanceId = new Guid("7dc436a5-29b9-475d-a394-f97a691f74f3"), Family = "Moofia", Name = "Latte" },
                        new { Id = new Guid("76cfbb29-3f9f-4901-8da8-a107687664c1"), AmbulanceId = new Guid("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"), Family = "Moofia", Name = "Strawberry Milk" },
                        new { Id = new Guid("3c2b99e2-94d0-422a-a15b-a86f05c1ced2"), AmbulanceId = new Guid("4da90981-6a19-48a1-a6d0-c1f413dc748d"), Family = "Moofia", Name = "Choco" },
                        new { Id = new Guid("3ac3818f-22b3-4fb6-a5f3-4c5f5cb32fcf"), AmbulanceId = new Guid("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"), Family = "Moofia", Name = "Soya" },
                        new { Id = new Guid("a59795de-4df2-4914-b7f4-fcaf5893aae7"), AmbulanceId = new Guid("dc8fabd1-09b6-427f-8454-2066a70d2828"), Family = "Moofia", Name = "Leche" },
                        new { Id = new Guid("29f56d90-852f-4a49-85d3-519924f12864"), AmbulanceId = new Guid("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"), Family = "Moofia", Name = "Half & Half" },
                        new { Id = new Guid("6ca9d288-d561-47bb-8ba3-f4c7a0edb519"), AmbulanceId = new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), Family = "Moofia", Name = "Mou Mou" },
                        new { Id = new Guid("2b1b55de-8147-4863-b73b-069258142c1f"), AmbulanceId = new Guid("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), Family = "Moofia", Name = "Miruku" }
                    );
                });

            modelBuilder.Entity("EF.Core.Entities.Whiner", b =>
                {
                    b.HasOne("EF.Core.Entities.BuaAmbulance", "Ambulance")
                        .WithMany("Whiners")
                        .HasForeignKey("AmbulanceId");
                });
#pragma warning restore 612, 618
        }
    }
}

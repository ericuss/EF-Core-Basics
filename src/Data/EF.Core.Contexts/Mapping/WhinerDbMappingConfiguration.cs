namespace EF.Core.Contexts.Mapping
{
    using EF.Core.Contexts.contexts.Core;
    using EF.Core.Entities;
    using EF.Core.Entities.Helpers;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using System;

    [BuaAmbulanceContext]
    public class WhinerDbMappingConfiguration : EntityMappingConfiguration<Whiner>
    {
        public override void Map(EntityTypeBuilder<Whiner> entity)
        {
            entity.ToTable("Whiners");
            entity.HasKey(x => x.Id);
            entity.Property("Family")
                    .HasConversion(new ValueConverter<TokidokiFamily, string>(
                        v => v.ToString(),
                        v => (TokidokiFamily)Enum.Parse(typeof(TokidokiFamily), v))
                    ).HasDefaultValue(TokidokiFamily.Moofia);
        }
        public override void SeedData(EntityTypeBuilder<Whiner> entity, IHostingEnvironment env)
        {

            entity.HasData(
                new { Id = Guid.Parse("b43b48a1-6a01-4c00-b04e-f0768f108c34"), AmbulanceId = Guid.Parse("a09c1e14-d823-4281-926d-345299696beb"), Name = "Mozzarella", Family = TokidokiFamily.Moofia },
                new { Id = Guid.Parse("00d703f6-3b3e-450b-83c4-77f21d73bac4"), AmbulanceId = Guid.Parse("7fa0d8be-83b2-45fa-b3ce-e40b6195beaa"), Name = "Bulletto", Family = TokidokiFamily.Moofia }
                );

            if (env.IsDevelopment())
            {
                entity.HasData(
                   new { Id = Guid.Parse("dc2f768d-8eb9-4b3e-917b-b5384f86e8b2"), AmbulanceId = Guid.Parse("7dc436a5-29b9-475d-a394-f97a691f74f3"), Name = "Latte", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("76cfbb29-3f9f-4901-8da8-a107687664c1"), AmbulanceId = Guid.Parse("e4fb1be6-4ba7-40c7-beef-e2b8c32751b6"), Name = "Strawberry Milk", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("3c2b99e2-94d0-422a-a15b-a86f05c1ced2"), AmbulanceId = Guid.Parse("4da90981-6a19-48a1-a6d0-c1f413dc748d"), Name = "Choco", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("3ac3818f-22b3-4fb6-a5f3-4c5f5cb32fcf"), AmbulanceId = Guid.Parse("1849dfa8-9fac-4b0c-a63f-e3198935dc7b"), Name = "Soya", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("a59795de-4df2-4914-b7f4-fcaf5893aae7"), AmbulanceId = Guid.Parse("dc8fabd1-09b6-427f-8454-2066a70d2828"), Name = "Leche", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("29f56d90-852f-4a49-85d3-519924f12864"), AmbulanceId = Guid.Parse("c66f9fae-ea7c-43cf-b5bf-54f9164489f8"), Name = "Half & Half", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("6ca9d288-d561-47bb-8ba3-f4c7a0edb519"), AmbulanceId = Guid.Parse("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), Name = "Mou Mou", Family = TokidokiFamily.Moofia },
                   new { Id = Guid.Parse("2b1b55de-8147-4863-b73b-069258142c1f"), AmbulanceId = Guid.Parse("f5950a6f-a698-4393-a9a5-5441cd03b1f7"), Name = "Miruku", Family = TokidokiFamily.Moofia }
                );
            }
        }
    }
}
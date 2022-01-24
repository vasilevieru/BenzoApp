using BenzoApp.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenzoApp.Infrastructure.Configurations;

internal class FuelStationConfiguration : EntityConfiguration<FuelStation>
{
    public override void Configure(EntityTypeBuilder<FuelStation> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasData(
            new()
            {
                Name = "Rompetrol",
            },
            new()
            {
                Name = "Petrom",
            },
            new()
            {
                Name = "Bemol",
            },
            new()
            {
                Name = "Tirex",
            },
            new()
            {
                Name = "Fox",
            },
            new()
            {
                Name = "Lukoil",
            },
            new()
            {
                Name = "Now",
            },
            new()
            {
                Name = "Avante",
            },
            new()
            {
                Name = "Vento",
            }
        );
    }
}

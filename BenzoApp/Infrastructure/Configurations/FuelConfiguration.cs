using BenzoApp.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenzoApp.Infrastructure.Configurations;

internal class FuelConfiguration : EntityConfiguration<Fuel>
{
    public override void Configure(EntityTypeBuilder<Fuel> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasAlternateKey(x => x.Name);

        builder.HasData(
            new Fuel
            {
                Name = "Benzina Standart 95"
            },
            new Fuel
            {
                Name = "Benzina Standart 95 Efix"
            },
            new Fuel
            {
                Name = "Benzina Efix S 98"
            },
            new Fuel
            {
                Name = "Benzina Efix S 98"
            },
            new Fuel
            {
                Name = "Benzina Premium 98"
            },
            new Fuel
            {
                Name = "Benzina Extra 99"
            },
            new Fuel
            {
                Name = "Motorina Euro 5"
            },
            new Fuel
            {
                Name = "Motorina Efix S 55"
            },
            new Fuel
            {
                Name = "Motorina Efix"
            },
            new Fuel
            {
                Name = "Motorina Extra"
            },
            new Fuel
            {
                Name = "Motorina ECTO"
            },
            new Fuel
            {
                Name = "GPL"
            }
        );
    }
}

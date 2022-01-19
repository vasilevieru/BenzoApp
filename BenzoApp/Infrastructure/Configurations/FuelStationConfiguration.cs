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
    }
}

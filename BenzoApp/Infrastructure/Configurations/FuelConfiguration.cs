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
    }
}

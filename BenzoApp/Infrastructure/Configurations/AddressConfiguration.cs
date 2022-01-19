using BenzoApp.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenzoApp.Infrastructure.Configurations;

internal class AddressConfiguration : EntityConfiguration<Address>
{
    public override void Configure(EntityTypeBuilder<Address> builder)
    {
        base.Configure(builder);

        builder.Property(a => a.City)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(a => a.Country)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(a => a.Street)
           .HasMaxLength(200)
           .IsRequired();

        builder.HasOne(x => x.FuelStation)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.FuelStationId);
    }
}

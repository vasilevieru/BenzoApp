using BenzoApp.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenzoApp.Infrastructure.Configurations;

internal class LogoConfiguration : EntityConfiguration<Logo>
{
    public override void Configure(EntityTypeBuilder<Logo> builder)
    {
        base.Configure(builder);

        builder.Property(f => f.Type)
                .HasMaxLength(20)
                .IsRequired();

        builder.Property(x => x.Path)
            .IsRequired();

        builder.HasIndex(x => x.Path)
            .IsUnique();

        builder.HasOne(x => x.FuelStation)
            .WithOne(x => x.Logo)
            .HasForeignKey<FuelStation>(x => x.LogoId);
    }
}

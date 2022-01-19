using BenzoApp.Models;

using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace BenzoApp.Infrastructure;

public class BenzoContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<FuelStation> FuelStations { get; set; }

    public DbSet<Fuel> Fuels { get; set; }

    public DbSet<FuelHistory> FuelHistories { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Logo> Logos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !string.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null &&
                          type.BaseType.IsGenericType &&
                          type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

        foreach (var type in typesToRegister)
        {
            dynamic configurationInstance = Activator.CreateInstance(type);
            modelBuilder.ApplyConfiguration(configurationInstance);
        }
    }
}
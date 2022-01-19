namespace BenzoApp.Models;

public class Address : BaseEntity
{
    public string Country { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public int FuelStationId { get; set; }

    public FuelStation FuelStation { get; set; }
}

namespace BenzoApp.Models;

public class FuelHistory : BaseEntity
{
    public int FuelId { get; set; }

    public float Price { get; set; }

    public int FuelStationId { get; set; }

    public DateTime PriceDate { get; set; }
}

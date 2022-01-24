namespace BenzoApp.Models;

public class Fuel : BaseEntity
{
    public string Name { get; set; }
    
    public List<FuelStation> FuelStations { get; set; }
}

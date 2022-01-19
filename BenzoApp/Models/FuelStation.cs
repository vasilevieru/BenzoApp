namespace BenzoApp.Models;

public class FuelStation : BaseEntity
{
    public string Name { get; set; }

    public List<Address> Addresses { get; set; }

    public int LogoId { get; set; }

    public Logo Logo { get; set; }
}

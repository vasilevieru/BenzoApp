namespace BenzoApp.Dtos;

public class FuelStationDto : BaseEntityDto
{
    public string Name { get; set; }

    public List<AddressDto> Addresses { get; set; }

    public LogoDto Logo { get; set; }
}

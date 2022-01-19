using BenzoApp.Dtos;

namespace BenzoApp.Services
{
    public interface IFuelStationService
    {
        Task<List<FuelStationDto>> GetAllFuelStations();
    }
}

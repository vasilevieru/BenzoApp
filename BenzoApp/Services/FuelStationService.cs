using AutoMapper;

using BenzoApp.Dtos;
using BenzoApp.Infrastructure;

using Microsoft.EntityFrameworkCore;

namespace BenzoApp.Services
{
    public class FuelStationService : IFuelStationService
    {
        readonly BenzoContext _benzoContext;
        readonly IMapper _mapper;

        public FuelStationService(BenzoContext benzoContext, IMapper mapper)
        {
            _benzoContext = benzoContext;
            _mapper = mapper;
        }

        public async Task<List<FuelStationDto>> GetAllFuelStations()
        {
            var fuelStations = await _benzoContext.FuelStations.Include(x => x.Logo)
                .ToListAsync();

            return _mapper.Map<List<FuelStationDto>>(fuelStations);
        }
    }
}

using AutoMapper;

using BenzoApp.Dtos;
using BenzoApp.Models;

namespace BenzoApp.Profiles;

public class FuelStationProfile : Profile
{
    public FuelStationProfile()
    {
        CreateMap<FuelStation, FuelStationDto>().ReverseMap();
    }
}

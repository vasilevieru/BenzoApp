using AutoMapper;

using BenzoApp.Dtos;
using BenzoApp.Models;

namespace BenzoApp.Profiles;

public class FuelProfile : Profile
{
    public FuelProfile()
    {
        CreateMap<Fuel, FuelDto>().ReverseMap();
    }
}

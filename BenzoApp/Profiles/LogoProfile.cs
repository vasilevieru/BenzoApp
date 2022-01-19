using AutoMapper;

using BenzoApp.Dtos;
using BenzoApp.Models;

namespace BenzoApp.Profiles;

public class LogoProfile : Profile
{
    public LogoProfile()
    {
        CreateMap<Logo, LogoDto>().ReverseMap();
    }
}

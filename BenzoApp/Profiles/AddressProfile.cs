using AutoMapper;

using BenzoApp.Dtos;
using BenzoApp.Models;

namespace BenzoApp.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}

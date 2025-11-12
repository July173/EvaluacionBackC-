using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class AdoptionProfile : Profile
    {
        public AdoptionProfile()
        {
            CreateMap<Adoption, AdoptionDto>().ReverseMap();
        }
    }
}

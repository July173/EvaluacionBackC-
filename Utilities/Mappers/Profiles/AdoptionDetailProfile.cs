using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class AdoptionDetailProfile : Profile
    {
        public AdoptionDetailProfile()
        {
            CreateMap<AdoptionDetail, AdoptionDetailDto>().ReverseMap();
        }
    }
}

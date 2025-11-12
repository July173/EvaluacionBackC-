using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class OrphanageProfile : Profile
    {
        public OrphanageProfile()
        {
            CreateMap<Orphanage, OrphanageDto>().ReverseMap();
        }
    }
}

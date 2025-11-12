using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class ChildOrphanageProfile : Profile
    {
        public ChildOrphanageProfile()
        {
            CreateMap<ChildOrphanage, ChildOrphanageDto>().ReverseMap();
        }
    }
}

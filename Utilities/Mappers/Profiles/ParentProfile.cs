using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class ParentProfile : Profile
    {
        public ParentProfile()
        {
            CreateMap<Parent, ParentDto>().ReverseMap();
        }
    }
}

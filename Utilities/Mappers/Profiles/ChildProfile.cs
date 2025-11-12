using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class ChildProfile : Profile
    {
        public ChildProfile()
        {
            CreateMap<Child, ChildDto>().ReverseMap();
        }
    }
}

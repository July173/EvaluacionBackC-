using AutoMapper;
using Entity.Dto;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class SocialWorkerProfile : Profile
    {
        public SocialWorkerProfile()
        {
            CreateMap<SocialWorker, SocialWorkerDto>().ReverseMap();
        }
    }
}

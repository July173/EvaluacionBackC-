using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class AdoptionBusiness : BaseBusiness<Adoption, AdoptionDto>, IAdoptionBusiness
    {
        public AdoptionBusiness(IAdoptionData data, IMapper mapper, ILogger<AdoptionBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

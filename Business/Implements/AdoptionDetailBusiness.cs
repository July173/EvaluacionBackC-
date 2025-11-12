using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class AdoptionDetailBusiness : BaseBusiness<AdoptionDetail, AdoptionDetailDto>, IAdoptionDetailBusiness
    {
        public AdoptionDetailBusiness(IAdoptionDetailData data, IMapper mapper, ILogger<AdoptionDetailBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

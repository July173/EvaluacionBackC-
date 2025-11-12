using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class SocialWorkerBusiness : BaseBusiness<SocialWorker, SocialWorkerDto>, ISocialWorkerBusiness
    {
        public SocialWorkerBusiness(ISocialWorkerData data, IMapper mapper, ILogger<SocialWorkerBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

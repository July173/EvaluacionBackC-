using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class OrphanageBusiness : BaseBusiness<Orphanage, OrphanageDto>, IOrphanageBusiness
    {
        public OrphanageBusiness(IOrphanageData data, IMapper mapper, ILogger<OrphanageBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

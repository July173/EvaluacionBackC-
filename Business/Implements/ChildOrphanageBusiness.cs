using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class ChildOrphanageBusiness : BaseBusiness<ChildOrphanage, ChildOrphanageDto>, IChildOrphanageBusiness
    {
        public ChildOrphanageBusiness(IChildOrphanageData data, IMapper mapper, ILogger<ChildOrphanageBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

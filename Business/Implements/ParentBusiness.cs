using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class ParentBusiness : BaseBusiness<Parent, ParentDto>, IParentBusiness
    {
        public ParentBusiness(IParentData data, IMapper mapper, ILogger<ParentBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

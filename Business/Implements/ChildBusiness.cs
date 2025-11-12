using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business.Implements
{
    public class ChildBusiness : BaseBusiness<Child, ChildDto>, IChildBusiness
    {
        public ChildBusiness(IChildData data, IMapper mapper, ILogger<ChildBusiness> logger)
            : base(data, mapper, logger) { }
    }
}

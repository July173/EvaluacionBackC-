using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrphanageController : GenericController<OrphanageDto, Orphanage>
    {
        private readonly IOrphanageBusiness _business;

        public OrphanageController(IOrphanageBusiness business, ILogger<OrphanageController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(OrphanageDto dto)
        {
            return dto.Id;
        }
    }
}

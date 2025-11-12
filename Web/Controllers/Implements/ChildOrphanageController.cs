using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildOrphanageController : GenericController<ChildOrphanageDto, ChildOrphanage>
    {
        private readonly IChildOrphanageBusiness _business;

        public ChildOrphanageController(IChildOrphanageBusiness business, ILogger<ChildOrphanageController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(ChildOrphanageDto dto)
        {
            return dto.Id;
        }
    }
}

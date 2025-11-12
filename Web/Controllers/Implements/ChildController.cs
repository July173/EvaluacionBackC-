using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : GenericController<ChildDto, Child>
    {
        private readonly IChildBusiness _business;

        public ChildController(IChildBusiness business, ILogger<ChildController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(ChildDto dto)
        {
            return dto.Id;
        }
    }
}

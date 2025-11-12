using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : GenericController<ParentDto, Parent>
    {
        private readonly IParentBusiness _business;

        public ParentController(IParentBusiness business, ILogger<ParentController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(ParentDto dto)
        {
            return dto.Id;
        }
    }
}

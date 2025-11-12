using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptionController : GenericController<AdoptionDto, Adoption>
    {
        private readonly IAdoptionBusiness _business;

        public AdoptionController(IAdoptionBusiness business, ILogger<AdoptionController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(AdoptionDto dto)
        {
            return dto.Id;
        }
    }
}

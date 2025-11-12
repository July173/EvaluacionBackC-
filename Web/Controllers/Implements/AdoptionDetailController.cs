using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptionDetailController : GenericController<AdoptionDetailDto, AdoptionDetail>
    {
        private readonly IAdoptionDetailBusiness _business;

        public AdoptionDetailController(IAdoptionDetailBusiness business, ILogger<AdoptionDetailController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(AdoptionDetailDto dto)
        {
            return dto.Id;
        }
    }
}

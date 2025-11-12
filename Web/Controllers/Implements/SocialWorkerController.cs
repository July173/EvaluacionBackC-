using Business.Interfaces;
using Entity.Dto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialWorkerController : GenericController<SocialWorkerDto, SocialWorker>
    {
        private readonly ISocialWorkerBusiness _business;

        public SocialWorkerController(ISocialWorkerBusiness business, ILogger<SocialWorkerController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(SocialWorkerDto dto)
        {
            return dto.Id;
        }
    }
}

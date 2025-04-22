using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.PartnershipDtos;
using Nafima.Service.Implementations;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnershipsController : ControllerBase
    {
        private IPartnershipService _partnershipService;
        public PartnershipsController(IPartnershipService partnershipService)
        {
            _partnershipService = partnershipService;
        }

        [HttpGet("")]
        public ActionResult<List<PartnershipGetDto>> GetAll()
        {
            return Ok(_partnershipService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(PartnershipCreateDto createDto)
        {
            return StatusCode(201, new { Id = _partnershipService.Create(createDto) });
        }
    }
}

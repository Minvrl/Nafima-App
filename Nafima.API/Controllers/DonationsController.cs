using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.DonationDtos;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private IDonationService _donationService;

        public DonationsController(IDonationService donationService)
        {
            _donationService = donationService;
        }

        [HttpGet("")]
        public ActionResult<List<DonationGetDto>> GetAll()
        {
            return Ok(_donationService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(DonationCreateDto createDto)
        {
            return StatusCode(201, new { Id = _donationService.Create(createDto) });
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _donationService.Delete(id);
            return NoContent();
        }
    }
}

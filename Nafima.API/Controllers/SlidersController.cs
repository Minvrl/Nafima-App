using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.PartnershipDtos;
using Nafima.Service.Dtos.SliderDtos;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private ISliderService _sliderService;
        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet("")]
        public ActionResult<List<SliderGetDto>> GetAll()
        {
            return Ok(_sliderService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(SliderCreateDto createDto)
        {
            return StatusCode(201, new { Id = _sliderService.Create(createDto) });
        }
    }
}

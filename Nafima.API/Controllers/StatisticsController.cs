using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.StatisticDtos;
using Nafima.Service.Implementations;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private IStatisticService _statisticService;
        public StatisticsController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        [HttpGet("")]
        public ActionResult<List<StatisticGetDto>> GetAll()
        {
            return Ok(_statisticService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(StatisticCreateDto createDto)
        {
            return StatusCode(201, new { Id = _statisticService.Create(createDto) });
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.ReviewDtos;
using Nafima.Service.Dtos.SettingDtos;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private ISettingService _settingService;
        public SettingsController(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpGet("")]
        public ActionResult<List<SettingGetDto>> GetAll()
        {
            return Ok(_settingService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(SettingCreateDto createDto)
        {
            return StatusCode(201, new { Key = _settingService.Create(createDto) });
        }
    }
}

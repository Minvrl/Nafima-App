using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController : ControllerBase
    {
        private IFAQService _faqService;
        public FAQsController(IFAQService faqService)
        {
            _faqService = faqService;
        }

        [HttpGet("")]
        public ActionResult<List<FAQGetDto>> GetAll()
        {
            return Ok(_faqService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(FAQCreateDto createDto)
        {
            return StatusCode(201, new { Id = _faqService.Create(createDto) });
        }
    }
}

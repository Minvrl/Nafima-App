using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nafima.Service.Dtos.DonationDtos;
using Nafima.Service.Dtos.ReviewDtos;
using Nafima.Service.Implementations;
using Nafima.Service.Interfaces;

namespace Nafima.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private IReviewService _reviewService;
        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }


        [HttpGet("")]
        public ActionResult<List<ReviewGetDto>> GetAll()
        {
            return Ok(_reviewService.GetAll());
        }

        [HttpPost("")]
        public ActionResult Create(ReviewCreateDto createDto)
        {
            return StatusCode(201, new { Id = _reviewService.Create(createDto) });
        }
    }
}

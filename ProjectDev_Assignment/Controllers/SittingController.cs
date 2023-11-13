using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDev_Assignment.Services;

namespace ProjectDev_Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SittingController : ControllerBase
    {
        private readonly SittingService _sittingService;

        public SittingController(SittingService sittingService)
        {
            _sittingService = sittingService;
        }

        [HttpGet]
        public IActionResult GetSittings()
        {
            var sittings = _sittingService.GetSittings();
            return Ok(sittings);
        }

        // Other actions for sitting management...
    }

}

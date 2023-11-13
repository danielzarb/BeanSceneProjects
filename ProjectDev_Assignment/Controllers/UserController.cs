using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectDev_Assignment.Services;
using ProjectDev_Assignment.Views;

namespace ProjectDev_Assignment.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Users credentials)
        {
            var user = _userService.Authenticate(credentials.UserName, credentials.PasswordHash);

            if (user == null)
                return Unauthorized();

            return Ok(user);
        }

        [Authorize("Manager")]
        [HttpGet("sittings")]
        public IActionResult GetSittings()
        {
            // Manager-specific logic to get sittings
            // might want to call SittingService or access your database here
            return Ok(/* sittings */);
        }

        // Other actions for user management...
    }

}

using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Felipe.Backend.Locsonging.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IAuthService _authService;

        public UserController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] string id)
        {
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginViewModel loginViewModel)
        {
            var logged = _authService.LoginUser(loginViewModel);

            if (!logged.HasValue)
            {
                return NotFound();
            }

            if (!logged.Value)
            {
                return Unauthorized();
            }

            return Ok();
        }
    }
}

using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IOnboardingService _onboardingService;
        private readonly IConfigService _configService;
        private readonly IAuthService _authService;

        public UserController(IOnboardingService onboardingService, IConfigService configService, IAuthService authService)
        {
            _onboardingService = onboardingService;
            _configService = configService;
            _authService = authService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] string id) 
            => Ok(await _configService.GetUserDataById(id));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
            => Ok(await _onboardingService.Create(userViewModel));

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginViewModel) 
            => Ok(await _authService.LoginUser(loginViewModel));
    }
}

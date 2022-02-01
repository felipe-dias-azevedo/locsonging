using Microsoft.AspNetCore.Mvc;

namespace Felipe.Backend.Locsonging.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

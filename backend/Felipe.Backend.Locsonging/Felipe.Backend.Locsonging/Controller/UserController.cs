using Microsoft.AspNetCore.Mvc;

namespace Felipe.Backend.Locsonging.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] string id)
        {
            return Ok();
        }
    }
}

using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Felipe.Backend.Locsonging.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _songService.Get());
    }
}
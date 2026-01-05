using EchoesOfTheRealmsShared.Services;
using Microsoft.AspNetCore.Mvc;

namespace EchoesOfTheRealmsAPI.Controllers
{

    [ApiController]
    [Route("api/PNJ")]
    public class PnjController : ControllerBase
    {
        private readonly AIService _aiService;

        public PnjController(AIService aiService) => _aiService = aiService;

        [HttpGet("Marchand")]
        public async Task<IActionResult> Marchand([FromQuery] string message)
            => Ok(await _aiService.SendMessage(message, "marchand"));

        [HttpGet("Reine")]
        public async Task<IActionResult> Reine([FromQuery] string message)
            => Ok(await _aiService.SendMessage(message, "reine"));
    }
}

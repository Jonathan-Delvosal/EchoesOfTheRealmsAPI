using EchoesOfTheRealmsShared.Services;
using Microsoft.AspNetCore.Mvc;

namespace EchoesOfTheRealmsAPI.Controllers
{

    [ApiController]
    [Route("api/PNJ")]
    public class NPCController : ControllerBase
    {
        private readonly AIService _aiService;

        public NPCController(AIService aiService) => _aiService = aiService;

        [HttpGet("Marchand")]
        public async Task<IActionResult> Marchand([FromQuery] string message)
        {
            // Todo chercher le preprompt du marchand dans la DB;
            string? preprompt = null;

            (string? assistantM, string? resumeurM) = await _aiService.SendMessage(message, "marchand", preprompt);

            //Todo sauver le resumeurM

            return Ok(new { assistantM, resumeurM });
        }

        [HttpGet("Reine")]
        public async Task<IActionResult> Reine([FromQuery] string message)
            => Ok(await _aiService.SendMessage(message, "reine"));
    }
}

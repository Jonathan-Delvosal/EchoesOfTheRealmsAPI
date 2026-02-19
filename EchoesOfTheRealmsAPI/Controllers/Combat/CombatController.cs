using EchoesOfTheRealmsShared.DTO.Attack;
using EchoesOfTheRealmsShared.Services.AttackService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EchoesOfTheRealmsAPI.Controllers.Combat
{
    [ApiController]
    [Route("api/Combat")]
    public class CombatController(CombatService _combatService) : ControllerBase
    {
        [HttpPost("Attack")]
        [Authorize]
        public ActionResult<AttackResultDTO> Attack([FromBody] AttackRequestDTO req)
        {
            if (req == null || req.Attacker == null || req.Defender == null)
                return BadRequest();

            if (req.AttackId <= 0)
                return BadRequest();

            var result = _combatService.ResolveAttack(req);
            return Ok(result);
        }
    }
}

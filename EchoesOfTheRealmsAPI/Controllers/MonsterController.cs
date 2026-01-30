using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Services;
using EotR.App.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EotRAPI.Controllers
{
    [ApiController]
    [Route("api/monster")]
    public class MonsterController(MonsterService _mService) : ControllerBase
    {
        [HttpGet("{id:int}")]
        //[ProducesResponseType(typeof(MonsterScreenResponseDTO), 200, "application/json")]
        [EndpointDescription("Permet d'afficher les statistiques d'un monstre, selon son ID / Allows you to display a monster's statistics, according to its ID")]

        public ActionResult<MonsterScreenResponseDTO> GetMonsterById(long id)
        {

            if (id <= 0) return BadRequest();

            MonsterScreenResponseDTO? monster = _mService.GetById(id);
            if (monster == null) { return NotFound(); }
            else
            {
                return Ok(monster);
            }



        }

        [HttpGet("Random Level")]
        //[ProducesResponseType(typeof(MonsterScreenResponseDTO), 200, "application/json")]
        [EndpointDescription("Choisi un monstre random pour lancer un combat / choose a random monster to start a fight")]
        public ActionResult<MonsterScreenResponseDTO> GetRandomMonster(int lvlMin, int lvlMax)
        {
            if (lvlMin <= 0) return BadRequest();

            // Todo mapper en DTO 
            MonsterScreenResponseDTO? monster = _mService.GetMonsterByRndLvl(lvlMin, lvlMax);
            if (monster == null) { return NotFound(); }
            else
            {
                return Ok(monster);
            }

        }

    }

}

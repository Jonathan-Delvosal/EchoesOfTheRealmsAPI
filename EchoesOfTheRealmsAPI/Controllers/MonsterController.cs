using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Services;
using EotR.App.Services;
using EotRAPI.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EotRAPI.Controllers
{
    [ApiController]
    [Route("api/monster")]
    public class MonsterController(ClasseTest _classTest, MonsterService _mService) : ControllerBase
    {

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MonsterScreenResponseDTO), 200, "application/json")]
        [EndpointDescription("Permet d'afficher les statistiques d'un monstre, selon son ID / Allows you to display a monster's statistics, according to its ID")]
        public IActionResult MonsterScreen([FromRoute] int id)
        {
            if (true) //si l'id est dans la db.... ?
            {
                _mService.GetById(id);

                return Ok(new MonsterScreenResponseDTO { id });
            }

            else return NotFound();

            //if (id == 1)
            //{
            //    return Ok(new MonsterScreenResponseDTO { ID = id, Type = "", Name = "Loup des neiges" });
            //}

            //else if (id == 2)
            //{
            //    return Ok(new MonsterScreenResponseDTO { ID = id, Name = "Loup des pairies" });
            //}




        }


    }

}

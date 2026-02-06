using EchoesOfTheRealmsAPI.DTO;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using EchoesOfTheRealmsShared.Services;
using EotR.App.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace EchoesOfTheRealmsAPI.Controllers
{
    // demander a khun pourquoi ici y'a EchoesOfTheRealmsAPI.Controllers et sur le MonsterController y'a EotRAPI.Controllers
    [ApiController]
    [Route("api/Authentication")]

    public class AuthController (UserService _uService, JwtManager jwtManager) : ControllerBase
    {

        // Todo: Get pour les connexions
        [HttpPost("login")]
        [EndpointDescription("Permet de s'authentifier")]

        public ActionResult GetConnection(LoginRequestDTO dto)
        {

            try
            {
                User User = _uService.Login(dto.Username, dto.Password);

                string token = jwtManager.CreateToken(User.Id, User.NickName, User.UserRoles.Select(r => r.Name).ToList());

                return Ok(new { Token = token });
            }
            catch (AuthenticationException)
            {

                return Unauthorized();
            }

        }

        // Todo: Post pour les inscriptions

        [HttpPost("register")]
        [EndpointDescription("Permet de créer un nouvel utilisateur")]
        public ActionResult CreateUser(RegisterDTO dto)
        {
            try
            {
                _uService.Create(dto);
                return Ok();
            }

            catch(ArgumentException)
            {
                return BadRequest("Le Nickname et l'email doivent etre unique");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // Todo: Get pour vérifier si le user à déjà un perso ou non

        //[HttpGet("CheckCharacter")]
        //[EndpointDescription("Permet de vérifier si le User possède déjà un personnage ou non")]
        //[Authorize]

        //public ActionResult CheckCharacter(UserDTO dto)
        //{
        //    var check 
        //}

    }
}

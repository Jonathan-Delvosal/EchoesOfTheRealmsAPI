using Microsoft.AspNetCore.Mvc;

namespace EchoesOfTheRealmsAPI.Controllers
{
    public class AuthController : Controller
    {

        [Route("api/[controller]")]
        [ApiController]
        public IActionResult Index()
        {
            return View();
        }
    }
}

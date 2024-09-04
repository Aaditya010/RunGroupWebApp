using Microsoft.AspNetCore.Mvc;

namespace RunGroupWebApp.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("Users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

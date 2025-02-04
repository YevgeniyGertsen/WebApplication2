using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

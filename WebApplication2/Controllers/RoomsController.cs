using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

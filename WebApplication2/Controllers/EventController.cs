using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

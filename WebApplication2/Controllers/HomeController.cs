using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult SendMessage(string name, string email, string message)
        public IActionResult SendMessage(Message userMessage)
        {
            var data = Request.Form;
            ///TODO write to db

            return View();
        }

        [HttpPost]
        public IActionResult NewsLetterSignUp(string email)
        {
            return RedirectToAction("Index");
        }
    }
}

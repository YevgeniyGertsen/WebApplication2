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
            Message message = new Message();
            message.email = "ok@ok.kz";

            //ViewBag.Test = "send your massage";

            return View(message);
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

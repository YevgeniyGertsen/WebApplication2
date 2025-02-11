using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IValidator<Message> _validator;

        public HomeController(ILogger<HomeController> logger, IValidator<Message> validator)
        {
            _validator = validator;
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
        public IActionResult Contact(Message userMessage)
        {
            MessageValidator rules = new MessageValidator();
            var result = rules.Validate(userMessage);
            var errors = result.Errors;

            if (result.IsValid)
                return RedirectToAction("SendMessage");
            else
                return View(userMessage);

            //if (ModelState.IsValid)
            //    return RedirectToAction("SendMessage"); 
            //else
            //    return View(userMessage);
        }




        [HttpPost]
        public IActionResult NewsLetterSignUp(string email)
        {
            return RedirectToAction("Index");
        }
    }
}

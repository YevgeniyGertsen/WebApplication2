using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EventController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            List<EventModel> events = new List<EventModel>();
            events.Add(new EventModel()
            {
                PictireSize = PictireSize.big,
                EventImgPath = "~/img/event/1.jpg",
                EventTitle = "management conferences",
                AuthorName = "By : Jhtyg Hyuir",
                Description= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt"
            });

            return View(events);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


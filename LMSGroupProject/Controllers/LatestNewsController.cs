using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class LatestNewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


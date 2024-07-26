using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class NewsLetterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


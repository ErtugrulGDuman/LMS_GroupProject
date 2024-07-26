using Microsoft.AspNetCore.Mvc;

namespace GroupProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


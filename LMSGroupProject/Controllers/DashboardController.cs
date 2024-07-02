using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Dashboard/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

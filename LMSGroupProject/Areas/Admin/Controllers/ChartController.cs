using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Chart/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

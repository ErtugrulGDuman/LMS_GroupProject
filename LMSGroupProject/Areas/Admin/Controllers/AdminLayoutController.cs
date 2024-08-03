using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        [Area("Admin")]
        [Route("Admin/AdminLayout/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

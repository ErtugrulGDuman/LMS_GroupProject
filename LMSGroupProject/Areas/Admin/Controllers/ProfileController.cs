using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Profile/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

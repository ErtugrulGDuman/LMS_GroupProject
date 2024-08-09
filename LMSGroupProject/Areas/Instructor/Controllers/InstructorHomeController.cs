using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Instructor.Controllers
{
    public class InstructorHomeController : Controller
    {
        [Area("Instructor")]
        [Route("Instructor/InstructorHome/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

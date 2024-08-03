using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class InstructorController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Instructor/InstructorList")]
        public IActionResult InstructorList()
        {
            return View();
        }
    }
}

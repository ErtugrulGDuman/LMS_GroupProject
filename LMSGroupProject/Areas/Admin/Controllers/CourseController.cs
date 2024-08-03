using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Course/CourseList")]
        public IActionResult CourseList()
        {
            return View();
        }
    }
}

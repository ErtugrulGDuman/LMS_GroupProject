using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Student/StudentList")]
        public IActionResult StudentList()
        {
            return View();
        }
    }
}

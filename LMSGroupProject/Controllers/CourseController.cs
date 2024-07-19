using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;


        public IActionResult Index()
        {
            return View();
        }
    }
}

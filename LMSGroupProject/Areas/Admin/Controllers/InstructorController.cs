using BusinessLayer.Abstract._2_AdminAreaServices;
using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [Route("Admin/Instructor/InstructorList")]

        public IActionResult InstructorList()
        {
            var values = _instructorService.TGetList();
            return View(values);
        }
    }
}

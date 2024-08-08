using BusinessLayer.Abstract._2_AdminAreaServices;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly ICoursesService _coursesService;

        public CourseController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        [Route("Admin/Course/CourseList")]
        public IActionResult CourseList()
        {
            var values = _coursesService.TGetList();
            return View(values);
            //return View();
        }
        //public IActionResult coursesDelete(int id)
        //{
        //    _coursesService.TDelete(id);
        //    return RedirectToAction("CourseList");
        //}

        //[HttpGet]
        //public IActionResult coursesUpdate(int id)
        //{
        //    var values = _coursesService.TGetByID(id);
        //    return View(values);
        //}
        //[HttpPost]
        //public IActionResult coursesUpdate(Courses courses)
        //{
        //    _coursesService.TUpdate(courses);
        //    return RedirectToAction("CourseList");
        //}
        //[HttpGet]
        //public IActionResult CreateCourses()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreateCourses(Courses courses)
        //{
        //    _coursesService.TInsert(courses);
        //    return RedirectToAction("CourseList");
        //}
    }
}

using BusinessLayer.Abstract._2_AdminAreaServices;
using EntityLayer.Concrete._2_AdminArea.General;
using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Controllers
{
    public class CourseCategoryController : Controller
    {
        
        private readonly ICourseCategoryService _courseCategoryService;

        public CourseCategoryController(ICourseCategoryService courseCategoryService)
        {
            _courseCategoryService = courseCategoryService;
        }
        
        public IActionResult CourseCategoryList()
        {
            var courseCategories = _courseCategoryService.TGetList();
            return View(courseCategories);
        }

        [HttpGet]

        public IActionResult CreateCourseCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourseCategory(CourseCategory courseCategory)
        {
            _courseCategoryService.TInsert(courseCategory);
            return RedirectToAction("CourseCategoryList");
        }

        public IActionResult DeleteCourseCategory(int id)
        {
            _courseCategoryService.TDelete(id);
            return RedirectToAction("CourseCategoryList");
        }
    }
}

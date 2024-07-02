using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Blogs");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultTopCategoriesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("TopCategories");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultNewsletterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Newsletter");
        }
    }
}
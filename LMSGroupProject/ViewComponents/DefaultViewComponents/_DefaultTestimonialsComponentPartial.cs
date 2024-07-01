using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
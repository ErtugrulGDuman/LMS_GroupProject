using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultMainHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("MainHeader");
        }
    }
}
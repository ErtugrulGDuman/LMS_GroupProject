using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultExperinceAdvisorsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Advisors");
        }
    }
}
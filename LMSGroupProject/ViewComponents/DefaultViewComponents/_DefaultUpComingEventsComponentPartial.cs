using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultUpComingEventsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("UpComingEvents");
        }
    }
}
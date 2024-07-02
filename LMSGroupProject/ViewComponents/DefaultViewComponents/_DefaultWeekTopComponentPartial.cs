using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultWeekTopComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("WeeklyTop");
        }
    }
}
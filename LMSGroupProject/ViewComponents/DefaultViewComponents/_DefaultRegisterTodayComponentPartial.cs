using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultRegisterTodayComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
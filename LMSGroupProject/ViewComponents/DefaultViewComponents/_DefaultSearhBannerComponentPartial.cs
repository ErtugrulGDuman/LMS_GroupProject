using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultSearhBannerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
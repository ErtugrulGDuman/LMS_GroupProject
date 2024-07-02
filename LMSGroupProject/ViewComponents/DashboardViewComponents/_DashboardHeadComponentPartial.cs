using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.ViewComponents.DashboardViewComponents
{
    public class _DashboardHeadComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("DashboardHead");
        }



    }
}

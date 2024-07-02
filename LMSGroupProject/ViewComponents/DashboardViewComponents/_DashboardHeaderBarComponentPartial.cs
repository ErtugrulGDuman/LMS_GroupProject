using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.ViewComponents.DashboardViewComponents
{
    public class _DashboardHeaderBarComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View("DashboardHeaderBar");
        }


    }
}

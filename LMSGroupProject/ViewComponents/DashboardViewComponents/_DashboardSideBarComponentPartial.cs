using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.ViewComponents.DashboardViewComponents
{
    public class _DashboardSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("DashboardSideBar");
        }
    }
}
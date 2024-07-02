using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultTopHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View("TopHeader");
        }
    }
}
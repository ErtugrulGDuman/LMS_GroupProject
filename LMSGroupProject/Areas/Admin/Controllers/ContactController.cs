using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        [Area("Admin")]
        [Route("Admin/Contact/ContactList")]
        public IActionResult ContactList()
        {
            return View();
        }
    }
}

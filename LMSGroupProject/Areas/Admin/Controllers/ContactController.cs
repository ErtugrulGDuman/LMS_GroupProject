using BusinessLayer.Abstract._1_SiteAreaServices;
using BusinessLayer.Abstract._2_AdminAreaServices;
using Microsoft.AspNetCore.Mvc;

namespace LMSGroupProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("Admin/Contact/ContactList")]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}

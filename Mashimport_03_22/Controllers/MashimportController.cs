using Mashimport_03_22.Models;
using Mashimport_03_22.Services.Interfaces;
using Mashimport_03_22.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Controllers
{
    public abstract class MashimportController : Controller
    {
        private readonly IContactsData contacts;
        private readonly ILogger<MashimportController> logger;
        protected ContactsInfo contactsInfo;

        public MashimportController(IContactsData contacts, ILogger<MashimportController> logger)
        {
            this.contacts = contacts;
            this.logger = logger;
        }
        public IActionResult About() => View();
        public IActionResult Partners() => View();
        public IActionResult Contact()
        {
            var model = new ContactsInfoViewModel()
            {
                Id = contactsInfo.Id,
                Address = contactsInfo.Address,
                TelephoneNumber = contactsInfo.TelephoneNumber,
                Email = contactsInfo.Email,
            };
            return View(model);
        }
    }
}

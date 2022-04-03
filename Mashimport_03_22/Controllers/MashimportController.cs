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
        private readonly ILanguageChanger languageChanger;
        private readonly IMenuData menuData;
        private readonly IContactFieldsData contactFieldsData;
        protected ContactsInfo contactsInfo;

        public MashimportController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData, IContactFieldsData contactFieldsData)
        {
            this.contacts = contacts;
            this.logger = logger;
            this.languageChanger = languageChanger;
            this.menuData = menuData;
            this.contactFieldsData = contactFieldsData;
        }
        public IActionResult About() => View();
        public IActionResult Partners() => View();
        public IActionResult Contact()
        {
            var model = new ContactViewModel()
            {
                InfoModel = new ContactsInfoViewModel()
                {
                    Address = contactsInfo.Address,
                    TelephoneNumber = contactsInfo.TelephoneNumber,
                    Email = contactsInfo.Email,
                },
                FieldsModel = contactFieldsData,
            };
            return View(model);
        }
    }
}

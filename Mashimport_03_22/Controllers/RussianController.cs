using Mashimport_03_22.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Controllers
{
    public class RussianController : MashimportController
    {
        public RussianController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData) : base(contacts, logger, languageChanger, menuData)
        {
            contactsInfo = contacts.GetById(1);
            languageChanger.ChangeToRussian(menuData);
        }
    }
}

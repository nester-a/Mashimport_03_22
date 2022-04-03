using Mashimport_03_22.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Controllers
{
    public class ChineseController : MashimportController
    {

        public ChineseController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData) : base(contacts, logger, languageChanger, menuData)
        {
            contactsInfo = contacts.GetById(2);
            languageChanger.ChangeToChinese(menuData);
        }
    }
}

using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Controllers
{
    public class EnglishController : MashimportController
    {
        public EnglishController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData, IContactFieldsData contactFieldsData) : base(contacts, logger, languageChanger, menuData, contactFieldsData)
        {
            contactsInfo = contacts.GetById(2);
            languageChanger.ChangeToEnglish(menuData);
            languageChanger.ChangeToEnglish(contactFieldsData);
        }
    }
}

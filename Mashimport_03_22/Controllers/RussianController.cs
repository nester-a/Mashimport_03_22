using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Controllers
{
    public class RussianController : MashimportController
    {
        public RussianController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData, IContactFieldsData contactFieldsData) : base(contacts, logger, languageChanger, menuData, contactFieldsData)
        {
            contactsInfo = contacts.GetById(1);
            languageChanger.ChangeToRussian(menuData);
            languageChanger.ChangeToRussian(contactFieldsData);
        }
    }
}

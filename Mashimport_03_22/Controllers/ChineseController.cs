using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Controllers
{
    public class ChineseController : MashimportController
    {

        public ChineseController(IContactsData contacts, ILogger<MashimportController> logger, ILanguageChanger languageChanger, IMenuData menuData, IContactFieldsData contactFieldsData) : base(contacts, logger, languageChanger, menuData, contactFieldsData)
        {
            contactsInfo = contacts.GetById(2);
            languageChanger.ChangeToChinese(menuData);
            languageChanger.ChangeToChinese(contactFieldsData);
        }
    }
}

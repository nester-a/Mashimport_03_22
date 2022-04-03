using Mashimport_03_22.Data;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Services
{
    public class LanguageChanger : ILanguageChanger
    {
        public void ChangeToChinese(IMenuData menuData)
        {
            menuData.About = TestData.Chn.About;
            menuData.Partners = TestData.Chn.Partners;
            menuData.Contact = TestData.Chn.Contact;
        }

        public void ChangeToEnglish(IMenuData menuData)
        {
            menuData.About = TestData.Eng.About;
            menuData.Partners = TestData.Eng.Partners;
            menuData.Contact = TestData.Eng.Contact;
        }

        public void ChangeToRussian(IMenuData menuData)
        {
            menuData.About = TestData.Rus.About;
            menuData.Partners = TestData.Rus.Partners;
            menuData.Contact = TestData.Rus.Contact;
        }
    }
}

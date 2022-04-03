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

        public void ChangeToChinese(IContactFieldsData contactFieldsData)
        {
            contactFieldsData.Title = TestData.ContactFieldsChn.Title;
            contactFieldsData.Address = TestData.ContactFieldsChn.Address;
            contactFieldsData.TelephoneNumber = TestData.ContactFieldsChn.TelephoneNumber;
            contactFieldsData.Email = TestData.ContactFieldsChn.Email;
        }

        public void ChangeToEnglish(IMenuData menuData)
        {
            menuData.About = TestData.Eng.About;
            menuData.Partners = TestData.Eng.Partners;
            menuData.Contact = TestData.Eng.Contact;
        }

        public void ChangeToEnglish(IContactFieldsData contactFieldsData)
        {
            contactFieldsData.Title = TestData.ContactFieldsEng.Title;
            contactFieldsData.Address = TestData.ContactFieldsEng.Address;
            contactFieldsData.TelephoneNumber = TestData.ContactFieldsEng.TelephoneNumber;
            contactFieldsData.Email = TestData.ContactFieldsEng.Email;
        }

        public void ChangeToRussian(IMenuData menuData)
        {
            menuData.About = TestData.Rus.About;
            menuData.Partners = TestData.Rus.Partners;
            menuData.Contact = TestData.Rus.Contact;
        }

        public void ChangeToRussian(IContactFieldsData contactFieldsData)
        {
            contactFieldsData.Title = TestData.ContactFieldsRus.Title;
            contactFieldsData.Address = TestData.ContactFieldsRus.Address;
            contactFieldsData.TelephoneNumber = TestData.ContactFieldsRus.TelephoneNumber;
            contactFieldsData.Email = TestData.ContactFieldsRus.Email;
        }
    }
}

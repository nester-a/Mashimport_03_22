namespace Mashimport_03_22.Services.Interfaces
{
    public interface ILanguageChanger
    {
        void ChangeToRussian(IMenuData menuData);
        void ChangeToEnglish(IMenuData menuData);
        void ChangeToChinese(IMenuData menuData);
        void ChangeToRussian(IContactFieldsData contactFieldsData);
        void ChangeToEnglish(IContactFieldsData contactFieldsData);
        void ChangeToChinese(IContactFieldsData contactFieldsData);
    }
}

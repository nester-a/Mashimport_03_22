using Mashimport_03_22.Services;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Infrastucture.Services
{
    public static class AddMyServiceExtension
    {
        public static void AddContacts(this IServiceCollection services)
        {
            services.AddSingleton<IContactsData, InMemoryContactsData>();
        }
        public static void AddLanguageChanger(this IServiceCollection services)
        {
            services.AddSingleton<ILanguageChanger, LanguageChanger>();
        }
        public static void AddMenuData(this IServiceCollection services)
        {
            services.AddSingleton<IMenuData, MenuData>();
        }
        public static void AddContactFieldsData(this IServiceCollection services)
        {
            services.AddSingleton<IContactFieldsData, ContactFieldsData>();
        }
    }
}

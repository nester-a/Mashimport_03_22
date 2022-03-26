using Mashimport_03_22.Services;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Infrastucture.Services
{
    public static class AddContacts
    {
        public static void AddContactsInfo(this IServiceCollection services)
        {
            services.AddSingleton<IContactsData, InMemoryContactsData>();
        }
    }
}

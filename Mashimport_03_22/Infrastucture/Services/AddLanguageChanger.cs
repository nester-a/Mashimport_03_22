using Mashimport_03_22.Services;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Infrastucture.Services
{
    public static class AddLanguageChanger
    {
        public static void AddLanguageChangerControllerComponent(this IServiceCollection services)
        {
            services.AddSingleton<ILanguageChanger, LanguageChanger>();
        }
    }
}

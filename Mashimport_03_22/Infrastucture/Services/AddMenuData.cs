using Mashimport_03_22.Services;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Infrastucture.Services
{
    public static class AddMenuData
    {
        public static void AddMenuButtonsData(this IServiceCollection services)
        {
            services.AddSingleton<IMenuData, MenuData>();
        }
    }
}

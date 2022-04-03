using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Services
{
    public class MenuData : IMenuData
    {
        public string About { get; set; } = string.Empty;

        public string Partners { get; set; } = string.Empty;

        public string Contact { get; set; } = string.Empty;
    }
}

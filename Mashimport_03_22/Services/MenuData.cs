using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Services
{
    public class MenuData : IMenuData
    {
        public string[] About { get; set; } = { "О компании", "About", "关于我们" };

        public string[] Partners { get; set; } = { "Партнёры", "Partners", "合作伙伴" };

        public string[] Contact { get; set; } = { "Контакты", "Contact", "联系方式" };
    }
}

using Mashimport_03_22.Services.Interfaces;
using Mashimport_03_22.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuData menuData;

        public MenuViewComponent(IMenuData menuData)
        {
            this.menuData = menuData;
        }
        public IViewComponentResult Invoke()
        {
            var model = new MenuViewModel()
            {
                About = menuData.About[0],
                Partners = menuData.Partners[0],
                Contact = menuData.Contact[0],
            };

            return View(model);
        }

    }
}

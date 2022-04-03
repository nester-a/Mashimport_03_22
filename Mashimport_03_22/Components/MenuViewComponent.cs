using AutoMapper;
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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<IMenuData, MenuViewModel>());
            var mapper = new Mapper(config);
            var model = mapper.Map<MenuViewModel>(menuData);

            return View(model);
        }

    }
}

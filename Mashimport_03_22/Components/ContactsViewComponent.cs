using Mashimport_03_22.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Components
{
    public class ContactsViewComponent : ViewComponent
    {
        public ContactsViewComponent()
        {

        }
        public IViewComponentResult Invoke(ContactViewModel model)
        {
            return View(model);
        }
    }
}

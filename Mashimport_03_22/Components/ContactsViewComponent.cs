using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Components
{
    public class ContactsViewComponent : ViewComponent
    {
        public ContactsViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

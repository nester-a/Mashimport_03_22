using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Controllers
{
    public abstract class MashimportController : Controller
    {
        public IActionResult About() => View();
        public IActionResult Partners() => View();
        public IActionResult Contact() => View();
    }
}

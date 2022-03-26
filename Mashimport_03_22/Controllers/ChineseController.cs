using Mashimport_03_22.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mashimport_03_22.Controllers
{
    public class ChineseController : MashimportController
    {
        public ChineseController(IContactsData contacts, ILogger<MashimportController> logger) : base(contacts, logger)
        {
            contactsInfo = contacts.GetById(1);
        }
    }
}

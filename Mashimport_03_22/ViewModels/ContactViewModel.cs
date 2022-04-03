using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.ViewModels
{
    public class ContactViewModel
    {
        public ContactsInfoViewModel InfoModel { get; set; }
        public IContactFieldsData FieldsModel { get; set; }
    }
}

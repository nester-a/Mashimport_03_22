using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Services
{
    public class ContactFieldsData : IContactFieldsData
    {
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TelephoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}

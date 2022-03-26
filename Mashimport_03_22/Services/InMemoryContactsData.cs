using Mashimport_03_22.Data;
using Mashimport_03_22.Models;
using Mashimport_03_22.Services.Interfaces;

namespace Mashimport_03_22.Services
{
    public class InMemoryContactsData : IContactsData
    {
        public ContactsInfo GetById(int id)
        {
            return TestData.Contacts.SingleOrDefault(c => c.Id == id);
        }
    }
}

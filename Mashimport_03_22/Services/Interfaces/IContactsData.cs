using Mashimport_03_22.Models;

namespace Mashimport_03_22.Services.Interfaces
{
    public interface IContactsData
    {
        ContactsInfo GetById(int id);
    }
}

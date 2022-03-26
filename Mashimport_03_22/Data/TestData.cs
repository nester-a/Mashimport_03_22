using Mashimport_03_22.Models;

namespace Mashimport_03_22.Data
{
    public static class TestData
    {
        static string email = @"info@mash-import.com";
        static string telephoneNumber = @"(495)663 - 33 - 93";
        public static List<ContactsInfo> Contacts = new()
        {
            new ContactsInfo() { Id = 1, Address = "107023, Москва, ул. Большая Семеновская, д.40", Email = email, TelephoneNumber = telephoneNumber },
            new ContactsInfo() { Id = 2, Address = "40, Bolshaya Semenovskaya, Moscow, 107023", Email = email, TelephoneNumber = telephoneNumber },
        };
    }
}

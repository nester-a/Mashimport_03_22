using Mashimport_03_22.Models;

namespace Mashimport_03_22.Data
{
    public static class TestData
    {
        static string email = @"info@mash-import.com";
        static string telephoneNumber = @"(495)663 - 33 - 93";
        public static List<ContactsInfo> Contacts { get; } = new()
        {
            new ContactsInfo() { Id = 1, Address = "107023, Москва, ул. Большая Семеновская, д.40", Email = email, TelephoneNumber = telephoneNumber },
            new ContactsInfo() { Id = 2, Address = "40, Bolshaya Semenovskaya, Moscow, 107023", Email = email, TelephoneNumber = telephoneNumber },
        };
        public static MenuItems Rus { get; } = new()
        {
            About = "О компании",
            Partners = "Партнёры",
            Contact = "Контакты",
        };
        public static MenuItems Eng { get; } = new()
        {
            About = "About",
            Partners = "Partners",
            Contact = "Contact",
        };
        public static MenuItems Chn { get; } = new()
        {
            About = "关于我们",
            Partners = "合作伙伴",
            Contact = "联系方式",
        };

        public static ContactFields ContactFieldsRus { get; } = new()
        {
            Title = "НАШИ КОНТАКТЫ",
            Address = "Адрес:",
            TelephoneNumber = "Тел/факс:",
            Email = "E-mail",
        };
        public static ContactFields ContactFieldsEng { get; } = new()
        {
            Title = "Our contact information",
            Address = "Address:",
            TelephoneNumber = "Tel./fax:",
            Email = "E-mail",
        };
        public static ContactFields ContactFieldsChn { get; } = new()
        {
            Title = "联系我们的方式",
            Address = "地址:",
            TelephoneNumber = "电话/传真:",
            Email = "电子邮箱:",
        };
    }
}

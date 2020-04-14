using System;

namespace BaiTapOOP2
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public string ShowContact()
        {
            return "Name: "+Name+"  \nPhone number: "+PhoneNumber+"";
        }
    }
}
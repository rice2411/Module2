using System;
using System.Collections.Generic;


namespace BaiTapOOP2
{
    class PhoneBook
    {
        public Contact[] ContactList = new Contact[0];

        public void Add(Contact contact)
        {
            Array.Resize(ref ContactList, ContactList.Length + 1);
            ContactList[ContactList.Length - 1] = contact;
        }
        public  bool Check(string name)
        {
            
            for(int i =0;i< ContactList.Length;i++)
            {
                if(name.ToLower()== ContactList[i].Name.ToLower())
                {
                    return true;
                }
                           
            }
            return false;
            
        }
        public  void Update(string name, string phonenumber)
        {
         
            for (int i = 0; i < ContactList.Length; i++)
            {
                if (name.ToLower() == ContactList[i].Name.ToLower())
                {
                    ContactList[i].PhoneNumber = phonenumber;
                }
            }
         

        }
        public  void Remove(string name)
        {
            bool flag = false;
            for(int i =0;i< ContactList.Length;i++)
            {
                if (name.ToLower() == ContactList[i].Name.ToLower())
                {
                   
                    flag = true;
                    for (int j = i; j < ContactList.Length - 1; j++)
                    {
                        ContactList[j] = ContactList[j + 1];
                    }
                }    
            }    
            if(flag==true)
            {
                Array.Resize(ref ContactList, ContactList.Length - 1);
            }    
          
        }
        public  string Search(string name)
        {
            bool flag = false;
            string result = "";
            for (int i = 0; i < ContactList.Length; i++)
            {
                if (name.ToLower() == ContactList[i].Name.ToLower())
                {
                    result += ContactList[i].ShowContact();
                    flag = true;
                }
            }
            if(flag==false)
            {
                return "Not exists";
            }
            return result;
        }
        public string ShowContact()
        {
            string result = "";
            for (int i =0;i< ContactList.Length;i++)
            {
                result += ContactList[i].ShowContact() + '\n';
            }
            return result;
        }
       
    }
}

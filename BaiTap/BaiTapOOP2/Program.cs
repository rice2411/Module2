
using System;

namespace BaiTapOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook pb = new PhoneBook();
          
            Menu(ref pb);
            
        }
        static void Menu(ref PhoneBook pb)
        {
            int choice = -1;
            while(choice < 1 || choice > 6)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. Remove Contact");
                Console.WriteLine("4. Search Contract");
                Console.WriteLine("5. Show Contacts");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice,ref pb);
            }    
        }
        static void Choice(int choice, ref PhoneBook contacts)
        {
           
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    add(ref contacts);
                    Menu( ref contacts);
                    break;
                case 2:
                    Console.Clear();
                    update(ref contacts);
                    Menu(ref contacts);
                    break;
                case 3:
                    Console.Clear();
                    rmv(ref contacts);
                    Menu(ref contacts);
                    break;
                case 4:
                    Console.Clear();
                    search(contacts);
                    Menu(ref contacts);
                    break;
                case 5:
                    Console.Clear();
                    show(contacts);
                    Menu(ref contacts);
                    break;
                case 6:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }    
        }
        static void add(ref PhoneBook contact)
        {
            Console.WriteLine("Add new contact");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone number: ");
            string phonenumber = Console.ReadLine();
            Contact newContact = new Contact(name, phonenumber);
            contact.Add(newContact);
            Console.Clear();
        }
        static void update(ref PhoneBook contact)
        {
            Console.WriteLine("Update Contact");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone number: ");
            string phonenumber = Console.ReadLine();
            contact.Update(name, phonenumber);
            Console.Clear();
        }
        static void rmv(ref PhoneBook contact)
        {
            Console.WriteLine("Enter contact you want to remove");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            contact.Remove(name);
      
        }
        static void search(PhoneBook contact)
        {
            Console.WriteLine("Enter contact you want to search");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Result: ");
            Console.WriteLine(contact.Search(name));
        
        }
        static void show(PhoneBook contact)
        {
            Console.WriteLine(contact.ShowContact());
         
        }
    }
}

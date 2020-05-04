using System;

namespace AbstratPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook arr = new PhoneBook();
            arr.InsertPhone("Trang", "123");
            arr.InsertPhone("Minh", "321");
            arr.InsertPhone("An", "321");
            arr.Sort();
            for(int i =0; i < arr.PhoneList.Length;i++)
            {
                Console.WriteLine(arr.PhoneList[i].Name);
            }
        }
    }
}

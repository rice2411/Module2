using System;
using System.Collections;
namespace DemoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrl = new ArrayList
            {
                1,
                '2',
                "34",
                null,
                new Student()
                {
                    Name = "Minh",
                    Dob = DateTime.Parse("2001/11/24")
                }
            };
            foreach (var items in arrl)
            {
                Console.WriteLine(items);
            }    
            
        }
        class Student
        {
            public string Name { get; set; }
            public DateTime Dob { get; set; }
        }
    }
}

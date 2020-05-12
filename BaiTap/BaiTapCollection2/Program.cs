using System;
using System.Collections.Generic;
namespace BaiTapCollection2
{
    class Program
    {
        public static Dictionary<int, Student> StudentList = new Dictionary<int, Student>();
       
        
        public static int ID = 1;
        static void Main(string[] args)
        {
         
            Menu();
            
            
        }
        static void Menu()
        {
            int choice = -1;
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("STUDENTS MANAGEMENT SYSTEM");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Insert new student");
                Console.WriteLine("2. View list of student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice);

            }
        }
        public static void Choice(int choice)
        {

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    InsertStudent();

                    break;
                case 2:
                
                    ShowListStudent();
           
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Name of student: ");
                    string name = Console.ReadLine();
                    Search(name);

                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            Menu();
        }
        public static void InsertStudent()
        {
            Student std = new Student();
            Console.Write("FullName: ");
            string fullname = Console.ReadLine();
            Console.Write("DOB: ");
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime inputtedDate = new DateTime(year, month, day);
            Console.Write("Class:");
            string _class = Console.ReadLine();
            Console.Write("Native");
            string native = Console.ReadLine();
            Console.Write("PhoneNo");
            string phoneno = Console.ReadLine();
            Console.Write("Mobile");
            int mobile = Convert.ToInt32(Console.ReadLine());
            std.FullName = fullname;
            std.DOB = inputtedDate;
            std.Class = _class;
            std.Native = native;
            std.PhoneNO = phoneno;
            std.Mobile = mobile;
            std.ID = ID;
            StudentList.Add(std.ID, std);
            ID++;
        }
        public  static void ShowListStudent()
        {
            foreach(var key in StudentList.Keys)
            {
                StudentList[key].Display();
            }    
        }
        public static void Search(string name)
        {
           foreach(var key in StudentList.Keys)
            {
                if (StudentList[key].FullName.ToLower() == name.ToLower())
                {
                    StudentList[key].Display();
                }
            }    

        }
    }
}

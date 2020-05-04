using System;

namespace PracticeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            Console.WriteLine(myPerson.Say());

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Say();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Say();
            myTeacher.Explain();

        }
    }
}

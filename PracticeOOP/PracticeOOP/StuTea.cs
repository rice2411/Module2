using System;

namespace PracticeOOP
{
    class Person
    {
        protected int age;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string Say()
        {
            return $"Hello!";
        }
       
    }
     class Student : Person
    {


        public string GoToClasses()
        {
            return $"I'm going to class.";
        }
        public int ShowAge()
        {
            return this.age;
        }
    }
    class Teacher : Person
    {
        public string Explain()
        {
            return $"Explanation begins";
        }
    }
}

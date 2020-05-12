using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCollection2
{
    class Student
    {
        private string fullName ;
        private int iD ;
        private DateTime dOB ;
        private string native ;
        private string _class ;
        private string phoneNo ;
        private int mobile ;

        public string FullName
        {
            get => fullName;
            set => fullName=value;
        }
        public int ID
        {
            get => iD;
            set => iD = value;
        }
        public DateTime DOB
        {
            get => dOB;
            set => dOB = value;
        }
        public string Native
        {
            get => native;
            set => native = value;
        }
        public string Class
        {
            get => _class;
            set => _class = value;
        }
        public string PhoneNO
        {
            get => phoneNo;
            set => phoneNo = value;
        }
        public int Mobile
        {
            get => mobile;
            set => mobile = value;
        }
        public void Display()
        {
            Console.WriteLine($"Fullname: {fullName}\nID:{iD}\nDOB:{dOB}\nNative:{native}\nClass:{_class}\nPhoneNo:{phoneNo}\nMobile:{mobile}");
        }
      

       
    }
}

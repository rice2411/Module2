using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCollection2
{
    interface IStudent
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public DateTime DOB { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        void Display();
    }
}

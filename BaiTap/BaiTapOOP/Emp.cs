using System;

namespace BaiTapOOP
{
    class Employee
    {

        
        public string name;
        public string email;
        public DateTime dob;
        public string address;
      
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public DateTime getDob()
        {
            return this.dob;
        }
        public void setDob()
        {
              string dob1;
            bool flag=false;
            DateTime dob = DateTime.Now;
            do
            {
                Console.WriteLine("Nhập ngày sinh (MM dd yyy):");
                dob1 = Console.ReadLine();
                try
                {
                    dob = Convert.ToDateTime(dob1);
                    flag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong.");
                    flag = false;
                }
            } while (flag == false);
            this.dob = dob;
        }
        public int GetAge(DateTime dob)
        {
            DateTime c = DateTime.Now;
            return c.Year- dob.Year;
        }
        public string showInfo()
        {
            return "Employee: " + this.name 
                     + Environment.NewLine
                    + "+Email: " + this.email
                      + Environment.NewLine
                    + "+Address: " + this.address
                    + Environment.NewLine
                    + "+DOB: " + this.dob;
        }

    }
}

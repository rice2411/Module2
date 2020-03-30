using System;
using System.Text;
namespace kiemtranamnhuan
{
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int year;
            Console.WriteLine("Nhập năm: ");
            year = Convert.ToInt32(Console.ReadLine());
            if(isLeapYear(year))
            {
                Console.WriteLine("{0} là năm nhuận", year);
            } else
            {
                Console.WriteLine("{0} là năm không nhuận", year);
            }                
        }
        public static bool isLeapYear(int yea)
        {
            if (yea % 4 == 0)
            {
                if (yea % 100 == 0)
                {
                    if (yea % 400 == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}

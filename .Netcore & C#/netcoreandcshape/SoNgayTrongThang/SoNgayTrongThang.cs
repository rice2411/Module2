using System;
using System.Text;
namespace SoNgayTrongThang
{
    class SoNgayTrongThang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int month;
            Console.WriteLine("Nhập số tháng: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dayinmonth(month));
            
        }
        public static string dayinmonth(int mont)
        {
            switch(mont)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return ("Tháng "+mont+" có 31 ngày");
                    break;
                case 2:
                    return ("Tháng " + mont +" có 28 hoặc 29 ngày");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    return ("Tháng " + mont + " có 30 ngày");
                    break;
                default:
                    {
                        return ("Số bạn nhập không phải tháng");
                        break;
                    }

            }    
        }
    }
}

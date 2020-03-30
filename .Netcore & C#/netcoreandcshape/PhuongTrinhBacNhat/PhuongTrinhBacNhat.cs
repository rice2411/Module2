using System;
using System.Text;
namespace PhuongTrinhBacNhat
{
    class PhuongTrinhBacNhat
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b;
            Console.WriteLine("Nhập a: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Phương trình của bạn là {0}x+{1}=0", a, b);
            Console.WriteLine(result(a, b));
        }
        public static string result(double num1, double num2)
        {
            if (num1 == 0)
            {
                return "Đây không phải là phương trình bậc nhất";
            } else
            {
                return "Nghiệm của phương trình là: " + -num2 / num1;
            }
            
        }
    }
}

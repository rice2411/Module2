using System;
using System.Text;
namespace tienlai
{
    class tienlai
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double money;
            int month;
            double intersetRate;
            Console.WriteLine("Nhập số tiền gửi: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất: ");
            intersetRate = Double.Parse(Console.ReadLine());
            Console.WriteLine("Tổng lãi của bạn là: {0}", total(money, month, intersetRate));
        }
        public static double total(double mon, int mont, double rat)
        {

            return mon * (rat / 100) * 12 * mont;
        }
    }
}

using System;
using System.Text;
namespace ChuyenTien
{
    class Chuyentien
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int money = 0;
            Console.WriteLine("Nhập số tiền của bạn (USD): ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mệnh giá VND là: {0} VND", convert(money));
        }
        public static int convert(int num)
        {
            return num * 23000;
        }
    }
}

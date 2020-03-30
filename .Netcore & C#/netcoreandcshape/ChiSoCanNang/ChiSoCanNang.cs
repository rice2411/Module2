using System;
using System.Text;
namespace ChiSoCanNang
{
    class ChiSoCanNang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double wei, hei;
            Console.WriteLine("Nhập chiều cao của bạn (m): ");
            hei = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng của bạn (kg): ");
            wei = Double.Parse(Console.ReadLine());
            Console.WriteLine(check(wei, hei));

        }
        public static string check(double weight, double height)
        {
            double bmi = weight / (Math.Pow(height, 2));
            bmi = Math.Round(bmi, 1);
            if (bmi < 18.5)
            {
                return "Thiếu cân";
            }
            else if (bmi < 25 && bmi >= 18.5)
            {
                return "Bình thường";
            }
            else if (bmi < 30 && bmi >= 25)
            {
                return "Quá cân";
            }
            return "Béo Phì";
        }
    }
}

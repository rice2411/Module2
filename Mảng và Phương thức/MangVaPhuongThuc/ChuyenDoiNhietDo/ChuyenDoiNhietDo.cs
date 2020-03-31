using System;
using System.Text;
namespace dotnet_change_temperature
{
    class ChuyenDoiNhietDo
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Đổi từ Fahrenheit sang Celsius");
                Console.WriteLine("2. Đổi từ Celsius sang Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhập độ fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit sang Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.WriteLine("Nhập Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius sang Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;
                    case 0:

                        Console.WriteLine("Nhấn phím bất kì để thoát");
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
}
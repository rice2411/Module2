using System;
using System.Text;
namespace SoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int number;
            Console.WriteLine("Nhập vào một số: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(isPrime(number))
            {
                Console.WriteLine("{0} là số nguyên tố.", number);
            }else
            {
                Console.WriteLine("{0} không phải là số nguyên tố.", number);
            }    
        }
        public static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for(int i =2;i<num-1;i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

    }
}


using System;
using System.Text;
namespace SNT20
{
    class SNT20
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int dem = 0;
            int i = 0;
            Console.WriteLine("20 số nguyên tố đầu tiên là :");
           while(dem<20)
            {
               if(isPrime(i))
                {
                    Console.WriteLine(i);
                    dem++;
                }
                i++;
            }    
        }
        public static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}

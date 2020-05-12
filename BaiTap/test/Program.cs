using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            Console.WriteLine(GT(x));
        }
        static long GT(long n)
        {
            if(n<2)
            {
                return  1;
            }
            return n * GT(n - 1);
        }
    }
}

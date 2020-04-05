using System;

namespace Access_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            sum a = new sum();
            sum2 b = new sum2();
            Console.WriteLine(a.Sum(2, 2));
            Console.WriteLine(b.Sum(2, 2));

        }
        class sum
        {
        
             internal int Sum(int a, int b)
            {
                return a + b;
            }
        }
        class sum2
        {
     
            public  int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}

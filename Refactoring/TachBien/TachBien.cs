using System;

namespace TachBien
{
    class TachBien
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(15));
        }
        public static String FizzBuzz(int number)
        {
            bool isFizz = number % 3 == 0;
            bool isBuzz = number % 5 == 0;
            if (isFizz && isBuzz)
                return "FizzBuzz";

            if (isFizz)
                return "Fizz";

            if (isBuzz)
                return "Buzz";

            return number + "";
        }
    }
}

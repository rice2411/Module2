using System;

namespace IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Triangle a = new Triangle();
            Square b = new Square();
            Console.WriteLine(a.getArea());
            Console.WriteLine(b.HowtoColor());
        }
    }
}

using System;

namespace TachPhuongThuc
{
    class TachPhuongThuc
    {
        static void Main(string[] args)
        {
            double result = CylinderDemo.GetVolume(2, 4);
            Console.WriteLine(result);
        }
        class CylinderDemo
        {
            public static double GetVolume(int radius, int height)
            {
                double baseArea = GetBaseArea(radius);
                double perimeter = GetPerimeter(radius);
                double volume = perimeter * height + 2 * baseArea;
                return volume;
            }

            private static double GetPerimeter(int radius)
            {
                return 2 * Math.PI * radius;
            }

            private static double GetBaseArea(int radius)
            {
                return Math.PI * radius * radius;
            }
        }
    }
}

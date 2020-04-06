using System;

namespace CircleandCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle(1,"red");
            Console.WriteLine(a);
            a.setColor("green");
            Console.WriteLine(a.getColor());
            Cylinder b = new Cylinder(2, 1, "blue");
            Console.WriteLine(b);
        }
    }
}

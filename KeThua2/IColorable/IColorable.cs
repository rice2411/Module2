using System;

namespace IColorable
{
   public abstract class Shape
    {
        public abstract double getArea();
    }
    public interface iColorable
    {
        public string HowtoColor();
    }
    public class Triangle : Shape
    {
        public override double getArea()
        {
            return 1;
        }
    }
    public class Rectangle : Shape
    {
        public override double getArea()
        {
            return 2;
        }
    }
    public class Square: Shape, iColorable
    {
        public override double getArea()
        {
            return 3;
        }
        public  string HowtoColor()
        {
            return "Color all four sides";
        }

    }
}

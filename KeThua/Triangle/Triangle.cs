using System;

namespace Triangle
{
    class Triangle : Shape
    {
        private double side1 = 1.0;
        private double side2 = 1.0;
        private double side3 = 1.0;
        public Triangle()
        {  }
        public Triangle(double side1, double side2, double size3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side2;

        }
        public double GetPerimeter()
        {
            return this.side1 + this.side2 + this.side3;
        }
        public double GetArea()

        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.side1) * (p - this.side2) * (p - this.side3));
        }
        public override string ToString()
        {
            return "Triangle: "
                + " Side 1: " + this.side1
                + " Side 2: " + this.side2
                + " Side 3: " + this.side3
                + " Perimeter: " + GetPerimeter()
                + " Area:" + GetArea();
        }
    }
}

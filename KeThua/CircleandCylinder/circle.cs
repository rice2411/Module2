using System;

namespace CircleandCylinder
{
   public class Circle
    {
        private double radius = 0;
        private string color = "";
        
        public Circle ()
        { }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        
        }

        public double getRadius()
        {
            return this.radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            return Math.Pow(this.radius, 2) *Math.PI;
        }
        public override string ToString()
        {
            return "This circle: " 
                 + " Raidus: "
                  + getRadius()
                 + " Color: "
                 + getColor()
                 + " Area: "
                 + getArea();

        }
    }
}

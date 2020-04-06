using System;

namespace CircleandCylinder
{
    public class Cylinder : Circle
    {
        private double height;
       public Cylinder()
        { }
        public Cylinder(double height,double raidus, string color) : base(raidus,color)
        {
            this.height = height;
        }
        public void getHeigt(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return Math.PI * Math.Pow(getRadius(), 2) * this.height;
        }
        public double GetArea()
        {
            return 2 * Math.PI * getRadius() * this.height;
        }
        public override string ToString()
        {
            return "This circle: "
                 + " Raidus: "
                 + getRadius()
                 + " Color: "
                 + getColor()
                 + " Area: "
                 + GetArea()
                 + " Volume: "
                 + getVolume();
        }   
    }
}

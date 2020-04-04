using System;

namespace LopFan
{
    class LopFan
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, 10, "yellow", true);
            Fan fan2 = new Fan(1, 5, "blue", false);
            fan1.toString();
            fan2.toString();
        }
        public class Fan
        {
            const int SLOW = 1;
            const int MEDIUM = 2;
            const int FAST = 3;
            int SPEED = 0;
            bool ON_OFF = true;
            double RADIUS = 0;
            string COLOR = "";
            public int speed()
            {
               if(this.SPEED != 0)
                {
                    return this.SPEED;
                }
                return 1;
            }
            private bool on_off()
            {
                if(this.ON_OFF==true)
                {
                    return true;
                }    
                return false;
            }
             private  double radius()
            {
                if(RADIUS!=0)
                {
                    return this.RADIUS;
                }
                return 5;
            }
            public string color()
            {
                if(this.COLOR!="")
                {
                    return this.COLOR;
                }
                return "blue";
            }
            public  Fan(int sp,double rad,string col,bool onoff)
            {
                this.SPEED = sp;
                this.RADIUS = rad;
                this.ON_OFF = onoff;
                this.COLOR = col;
            }
            public void toString()
            {
                Console.WriteLine("Fan:");
                Console.WriteLine("+Speed: {0}", this.SPEED);
                Console.WriteLine("+Radius: {0}", this.RADIUS);
                Console.WriteLine("+Color: {0}", this.COLOR);
                Console.WriteLine("+Status: {0}", this.ON_OFF);
            }
        }
    }
}

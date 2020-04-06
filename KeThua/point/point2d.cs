using System;

namespace point
{
    class Point2d
    {
        private float x=0;
        private float y=0;
        public Point2d()
        { }
        public Point2d(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX()
        {
            return this.x;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public float getY()
        {
            return this.y;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void getXY()
        {
            float[] arr = { this.x, this.y };

            Console.WriteLine("[{0}]", string.Join(",", arr)); 
        }
        public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }
    }
}

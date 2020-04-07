using System;

namespace movepoint
{
    class MoveablePoint : Point2d
    {
        private float xSpeed = 0;
        private float ySpeed = 0;
        public MoveablePoint()
        { }
        public MoveablePoint(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public float getxSpeed()
        {
            return this.xSpeed;
        }
        public void setxSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float getySpeed()
        {
            return this.ySpeed;
        }
        public void setySpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public void getSPEED()
        {
            float[] arr = { this.xSpeed, this.ySpeed };

            Console.WriteLine("[{0}]", string.Join(",", arr));
        }
        public override string ToString()
        {
            return "(" + this.xSpeed + "," + this.ySpeed + ")";
        }
        public void Move(float x, float y)
        {
            float x1 = x;
            float y1 = y;
            Console.WriteLine("({0},{1})", x1+getxSpeed(),y1+getySpeed());
        }
    }
}

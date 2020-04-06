using System;

namespace point
{
    class Point3d : Point2d
    {
        private float z=0;
       
        public Point3d()
        { }
        public Point3d(float x, float y, float z) : base(x, y)
        {
            this.z=z;
        }
        public float getZ()
        {
            return this.z;
        }
        public void setZ(float z)
        {
            this.z =z;
        }
        public void getXYZ()
        {
            float[] arr = { getX(), getY(), getZ() };

            Console.WriteLine("[{0}]", string.Join(",", arr));
        }
        public override string ToString()
        {
            return "(" + getX() + "," + getY() + "," + getZ() + ")";
        }
    }
}

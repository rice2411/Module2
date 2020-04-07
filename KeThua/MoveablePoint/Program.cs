using System;

namespace movepoint
{
    class Program 
    {
        static void Main(string[] args)
        {
            Point2d a = new Point2d(1, 1);
            Console.WriteLine(a.getX());
            MoveablePoint b = new MoveablePoint(2, 2);
     
            b.Move(a.getX(),a.getY());
        }
    }
}

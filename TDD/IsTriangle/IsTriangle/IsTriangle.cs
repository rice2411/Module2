using System;

namespace IsTriangle
{
    public class CheckTriangle
    {
        private int code { get; set; }
        public bool Istriangle(double side1, double side2, double side3)
        {
            code = 3;
            if (side1 < 0 || side2 < 0 || side3 <0)
            {
                return false;
            }    
           else if(side1+side2<side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                /*  return $"Is not triangle"; */
                code = 0;
                return false;
            } else if(side1 == side2 && side2 == side3 )
            {
                /*    return $"Equilateral triangle";*/
                code = 1;
                return true;
            } else if(side1==side2 && side1!=side3 || side1==side3 && side1!=side2 || side2==side3 && side2!=side1)
            {
                /*    return $"isosceles triangle";*/
                code = 2;
                return true;
            }
            /*    return $"Is normal triangle";*/
          
            return true;
        }
        public string TypeOfTriangle()
        {
            switch(code)
            {
                case 0:
                    return $"Is not triangle";
                    break;
                case 1:
                    return   $"Equilateral triangle"; ;
                    break;
                case 2:
                    return $"isosceles triangle";
                    break;
                case 3:
                    return $"Is normal triangle";
                    break;
            }
            return $"Something went wrong";
        }
    }
}
